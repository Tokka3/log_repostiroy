using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Logi
{
	// Token: 0x0200001C RID: 28
	public class Uninstaller
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000C0 RID: 192 RVA: 0x0000D680 File Offset: 0x0000B880
		// (remove) Token: 0x060000C1 RID: 193 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		public event Uninstaller.UninstallerEventHandler UninstallEvent;

		// Token: 0x060000C2 RID: 194 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
		public Uninstaller(bool isBadInstall, bool saveSettings)
		{
			this._isBadInstall = isBadInstall;
			this._saveSettings = saveSettings;
			this._updatesPollingTimer = new DispatcherTimer();
			this._updatesPollingTimer.Tick += this.UpdateProgress;
			this._updatesPollingTimer.Interval = new TimeSpan(0, 0, 0, 0, 200);
			this._callback = delegate(int status)
			{
				Utils.Log(string.Format("Uninstaller callback: Status update: {0}", status));
				this._lastStatus = status;
				this.ProcessProgress(status, Uninstaller.get_uninstall_progress());
			};
			Uninstaller.set_uninstall_status_callback(this._callback);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000D779 File Offset: 0x0000B979
		public void Uninstall()
		{
			if (this._saveSettings)
			{
				this._settingsSaved = Utils.BackupExistingSettings();
			}
			this.uninstallFull();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000D794 File Offset: 0x0000B994
		private void UpdateProgress(object sender, EventArgs e)
		{
			this.ProcessProgress(this._lastStatus, Uninstaller.get_uninstall_progress());
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		private void ProcessProgress(int status, float progress)
		{
			Dispatcher.CurrentDispatcher.BeginInvoke(new Action(delegate()
			{
				object progressUpdateLock = this._progressUpdateLock;
				lock (progressUpdateLock)
				{
					if (0 > status)
					{
						Utils.Log(string.Format("Uninstaller progress error: Status: {0} / Progress: {1}", status, progress));
						if (!this._hasError)
						{
							this._hasError = true;
						}
						else
						{
							this._updatesPollingTimer.Stop();
							UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.ERROR, 100f, this.GetErrorMessage(status));
							this.UninstallEvent(this, args);
						}
					}
					else if (status == 0)
					{
						if ((this._hasError && !this._nukeStarted) || this._isBadInstall)
						{
							Utils.Log("Uninstaller progress: Forcefully removing remaining files");
							this._nukeStarted = true;
							this._isBadInstall = false;
							UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.FINALIZING, 100f, Strings.Get(STRING.INSTALLER_STEP_FINALIZING) + " uninstall");
							this.UninstallEvent(this, args);
							this.uninstallNuke();
						}
						else
						{
							if (this._settingsSaved)
							{
								Utils.RestoreBackupSettings();
							}
							if (!this._isFinished)
							{
								this._isFinished = true;
								this._updatesPollingTimer.Stop();
								UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.SUCCESS, 100f, "");
								this.UninstallEvent(this, args);
							}
						}
					}
					else if (!this._nukeStarted)
					{
						switch (status)
						{
						case 1:
						{
							UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.INITIALIZING, (float)(5 + (int)(progress * 10f)), Strings.Get(STRING.INSTALLER_STEP_INITIALIZE));
							this.UninstallEvent(this, args);
							break;
						}
						case 2:
						{
							UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.UNINSTALLING, (float)(15 + (int)(progress * 60f)), Strings.Get(STRING.UNINSTALLER_STEP_UNINSTALLING));
							this.UninstallEvent(this, args);
							break;
						}
						case 3:
						{
							UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.REMOVING_FILES, (float)(75 + (int)(progress * 15f)), Strings.Get(STRING.UNINSTALLER_STEP_RM_FILES));
							this.UninstallEvent(this, args);
							break;
						}
						case 4:
						{
							UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.REMOVING_EXTRA_FILES, 90f, Strings.Get(STRING.UNINSTALLER_STEP_RM_EXTRA_FILES));
							this.UninstallEvent(this, args);
							break;
						}
						}
						Utils.Log(string.Format("Uninstaller progress: Status: {0} / Progress: {1}", status, progress));
					}
					else
					{
						UninstallerArgs args = new UninstallerArgs(UNINSTALL_STATE.FINALIZING, 90f, Strings.Get(STRING.INSTALLER_STEP_FINALIZING) + " uninstall");
						this.UninstallEvent(this, args);
					}
				}
			}), new object[0]);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000D7F1 File Offset: 0x0000B9F1
		private void uninstallFull()
		{
			this._lastStatus = 1;
			new Task(delegate()
			{
				Uninstaller.full_uninstall();
			}).Start();
			this._updatesPollingTimer.Start();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D82E File Offset: 0x0000BA2E
		private void uninstallNuke()
		{
			this._lastStatus = 1;
			new Task(delegate()
			{
				Uninstaller.nuke();
			}).Start();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D860 File Offset: 0x0000BA60
		public string GetErrorMessage(int errorCode)
		{
			string str = Strings.Get(STRING.UNINSTALLER_ERROR_DESCRIPTION_P1);
			switch (errorCode)
			{
			case -5:
				str += Strings.Get(STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL);
				break;
			case -4:
				str += Strings.Get(STRING.UNINSTALLER_ERROR_FOLDER_DELETION);
				break;
			case -3:
				str += Strings.Get(STRING.UNINSTALLER_ERROR_FILE_DELETION);
				break;
			case -2:
				str += Strings.Get(STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL);
				break;
			case -1:
				str += Strings.Get(STRING.UNINSTALLER_ERROR_PROCESS_KILL);
				break;
			default:
				str += string.Format(Strings.Get(STRING.UNINSTALLER_ERROR_UNKNOWN), errorCode);
				break;
			}
			return str + Strings.Get(STRING.UNINSTALLER_ERROR_DESCRIPTION_P2);
		}

		// Token: 0x04000139 RID: 313
		private Uninstaller.UninstallCallback _callback;

		// Token: 0x0400013A RID: 314
		private int _lastStatus;

		// Token: 0x0400013B RID: 315
		private DispatcherTimer _updatesPollingTimer;

		// Token: 0x0400013C RID: 316
		private bool _isBadInstall;

		// Token: 0x0400013D RID: 317
		private bool _saveSettings;

		// Token: 0x0400013E RID: 318
		private bool _settingsSaved;

		// Token: 0x0400013F RID: 319
		private bool _hasError;

		// Token: 0x04000140 RID: 320
		private bool _nukeStarted;

		// Token: 0x04000141 RID: 321
		private bool _isFinished;

		// Token: 0x04000142 RID: 322
		private object _progressUpdateLock = new object();

		// Token: 0x04000143 RID: 323
		public static Uninstaller.full_uninstallDelegate full_uninstall = Core.GetDllFunction<Uninstaller.full_uninstallDelegate>("logi_installer_shared.dll", "full_uninstall");

		// Token: 0x04000144 RID: 324
		public static Uninstaller.nukeDelegate nuke = Core.GetDllFunction<Uninstaller.nukeDelegate>("logi_installer_shared.dll", "nuke");

		// Token: 0x04000145 RID: 325
		public static Uninstaller.set_uninstall_status_callbackDelegate set_uninstall_status_callback = Core.GetDllFunction<Uninstaller.set_uninstall_status_callbackDelegate>("logi_installer_shared.dll", "set_uninstall_status_callback");

		// Token: 0x04000146 RID: 326
		public static Uninstaller.get_uninstall_progressDelegate get_uninstall_progress = Core.GetDllFunction<Uninstaller.get_uninstall_progressDelegate>("logi_installer_shared.dll", "get_uninstall_progress");

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x0600017E RID: 382
		public delegate void UninstallerEventHandler(object sender, UninstallerArgs args);

		// Token: 0x02000045 RID: 69
		public enum STATE
		{
			// Token: 0x040001D6 RID: 470
			PRODUCT_REMOVAL_FAILURE = -5,
			// Token: 0x040001D7 RID: 471
			FOLDER_DELETION_FAILURE,
			// Token: 0x040001D8 RID: 472
			FILE_DELETION_FAILURE,
			// Token: 0x040001D9 RID: 473
			SERVICE_REMOVAL_FAILURE,
			// Token: 0x040001DA RID: 474
			PROCESS_KILL_FAILURE,
			// Token: 0x040001DB RID: 475
			SUCCESS,
			// Token: 0x040001DC RID: 476
			INITIALIZING,
			// Token: 0x040001DD RID: 477
			UNINSTALLING_SOFTWARE,
			// Token: 0x040001DE RID: 478
			REMOVING_FILES,
			// Token: 0x040001DF RID: 479
			REMOVING_EXTRA_FILES
		}

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000182 RID: 386
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void UninstallCallback(int status);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000186 RID: 390
		public delegate void full_uninstallDelegate();

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600018A RID: 394
		public delegate void nukeDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600018E RID: 398
		public delegate void set_uninstall_status_callbackDelegate([MarshalAs(UnmanagedType.FunctionPtr)] Uninstaller.UninstallCallback callback);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000192 RID: 402
		public delegate float get_uninstall_progressDelegate();
	}
}
