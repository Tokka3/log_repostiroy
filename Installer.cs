using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Logi
{
	// Token: 0x02000019 RID: 25
	public class Installer
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000AE RID: 174 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		// (remove) Token: 0x060000AF RID: 175 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public event Installer.UpdateEventHandler ProgressUpdateEvent;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000B0 RID: 176 RVA: 0x0000D228 File Offset: 0x0000B428
		// (remove) Token: 0x060000B1 RID: 177 RVA: 0x0000D260 File Offset: 0x0000B460
		public event Installer.InstallerErrorEventHandler InstallerErrorEvent;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000B2 RID: 178 RVA: 0x0000D298 File Offset: 0x0000B498
		// (remove) Token: 0x060000B3 RID: 179 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
		public event Installer.InstallerStateChangeEventHandler InstallerStateChangeEvent;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000B4 RID: 180 RVA: 0x0000D308 File Offset: 0x0000B508
		// (remove) Token: 0x060000B5 RID: 181 RVA: 0x0000D340 File Offset: 0x0000B540
		public event Installer.DownloadRetryEventHandler DownloadRetryEvent;

		// Token: 0x060000B6 RID: 182 RVA: 0x0000D378 File Offset: 0x0000B578
		public void Download(bool isSilent)
		{
			Dispatcher.CurrentDispatcher.BeginInvoke(new Action(delegate()
			{
				object downloadLock = this._downloadLock;
				lock (downloadLock)
				{
					this._callback = delegate(int status, int error_code, int progress_type, float percent, float rate, float downloaded, float total_to_download, uint retry_countdown)
					{
						if (this.State == Installer.STATE.ERROR)
						{
							Utils.Log("Installer::State = error with code: {error_code}");
							return;
						}
						object downloadLock2;
						switch (status)
						{
						case 2:
						case 8:
							Utils.Log("Installer::Download and unpacking are done");
							downloadLock2 = this._downloadLock;
							lock (downloadLock2)
							{
								if (!isSilent)
								{
									InstallerStateChangeArgs installerStateChangeArgs = new InstallerStateChangeArgs();
									installerStateChangeArgs.State = Installer.STATE.INSTALLING;
									this.InstallerStateChangeEvent(this, installerStateChangeArgs);
								}
								this.Install();
								return;
							}
							break;
						case 3:
						case 9:
						case 10:
						case 11:
							return;
						case 4:
							Utils.Log("Installer::Downloading new update");
							new Thread(new ThreadStart(Engine.DownloadUpdates.Invoke)).Start();
							return;
						case 5:
						{
							Utils.Log("Installer::Updater error with only-keys detected on fresh install.");
							InstallerErrorArgs installerErrorArgs = new InstallerErrorArgs();
							installerErrorArgs.ErrorCode = error_code;
							this.InstallerErrorEvent(this, installerErrorArgs);
							return;
						}
						case 6:
						case 7:
						{
							if (error_code != 0)
							{
								string text = Engine.GetErrorMessage(error_code);
								if (retry_countdown > 0U)
								{
									string text2 = Strings.Get(STRING.INSTALLER_RETRY_COUNTDOWN);
									text2 = text2.Replace("%d", Convert.ToString(retry_countdown));
									text = text + " " + text2;
								}
								DownloadRetryArgs downloadRetryArgs = new DownloadRetryArgs();
								downloadRetryArgs.Message = text;
								this.DownloadRetryEvent(this, downloadRetryArgs);
							}
							else if (!isSilent)
							{
								Engine.PROGRESS_TYPE progressType = (6 == status) ? Engine.PROGRESS_TYPE.DOWNLOAD : Engine.PROGRESS_TYPE.UNCOMPRESS;
								this.ProgressUpdateEvent(this, new ProgressUpdateArgs(progressType, percent, downloaded, total_to_download));
							}
							string text3 = (6 == status) ? "Downloading" : "Unpacking";
							Utils.Log(string.Format(string.Format("Installer::{0} {1:0.00}% | errorcode: {2} | retrycount: {3}", new object[]
							{
								text3,
								percent,
								error_code,
								retry_countdown
							}), new object[0]));
							return;
						}
						case 12:
							break;
						case 13:
						{
							Utils.Log("Installer::Incompatible OS version detected, aborting.");
							InstallerErrorArgs installerErrorArgs2 = new InstallerErrorArgs();
							installerErrorArgs2.ErrorCode = error_code;
							this.InstallerErrorEvent(this, installerErrorArgs2);
							return;
						}
						default:
							return;
						}
						Utils.Log(string.Format("Installer::Download error with code: {0}", error_code));
						downloadLock2 = this._downloadLock;
						lock (downloadLock2)
						{
							this.State = Installer.STATE.ERROR;
						}
						InstallerErrorArgs installerErrorArgs3 = new InstallerErrorArgs();
						installerErrorArgs3.ErrorCode = error_code;
						this.InstallerErrorEvent(this, installerErrorArgs3);
					};
					Utils.Log("Installer::Checking for updates");
					Engine.SetNativeCallback(this._callback);
					if (Engine.CheckForUpdates())
					{
						this.State = Installer.STATE.DOWNLOADING;
					}
				}
			}), new object[0]);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000D3B6 File Offset: 0x0000B5B6
		public void Install()
		{
			if (this.MayInstall && !this._isInstallationRunning)
			{
				this._isInstallationRunning = true;
				Application.Current.Dispatcher.BeginInvoke(new Action(delegate()
				{
					Utils.Log("Installer::Starting the updater process for installation");
					if (this.launch_updater_install())
					{
						this._agentCheckTimer = new DispatcherTimer();
						this._agentCheckTimer.Tick += this.dispatcherTimer_Tick;
						this._agentCheckTimer.Interval = new TimeSpan(0, 0, 1);
						this._agentCheckTimer.Start();
						return;
					}
					InstallerErrorArgs installerErrorArgs = new InstallerErrorArgs();
					installerErrorArgs.ErrorCode = -4;
					this.InstallerErrorEvent(this, installerErrorArgs);
				}), new object[0]);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		private void dispatcherTimer_Tick(object sender, EventArgs e)
		{
			if (this.isAgentRunning())
			{
				Utils.Log("Installer::Installation completed");
				this._agentCheckTimer.Stop();
				Application.Current.Dispatcher.Invoke(new Action(delegate()
				{
					Engine.Destroy();
					Core.Cleanup();
					Utils.Log("Installer::Exiting");
					Application.Current.Shutdown();
				}), new object[0]);
				return;
			}
			Utils.Log("Installer::No agent process detected, retrying in 2s");
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000D460 File Offset: 0x0000B660
		public Installer.INSTALLATION_INTEGRITY GetInstallationIntegrity()
		{
			if (Utils.IsLGSInstalled())
			{
				return Installer.INSTALLATION_INTEGRITY.LGS_INSTALLED;
			}
			bool flag = Utils.IsAlreadyInstalled();
			bool flag2 = Directory.Exists(Utils.GetProgramDataPath());
			bool flag3 = Directory.Exists(Utils.GetProgramFilesPath());
			bool flag4 = false;
			if (flag2)
			{
				flag4 = File.Exists(Utils.GetProgramDataPath() + "/installation.json");
			}
			bool flag5 = false;
			if (flag3)
			{
				flag5 = File.Exists(Utils.GetProgramFilesPath() + "/lghub_updater.exe");
			}
			if (flag4 && flag && flag5)
			{
				return Installer.INSTALLATION_INTEGRITY.COMPLETE;
			}
			if (flag4 && !flag && flag5)
			{
				return Installer.INSTALLATION_INTEGRITY.REGISTRY_MISSING;
			}
			if (!flag && !flag5 && !flag4)
			{
				return Installer.INSTALLATION_INTEGRITY.NO_INSTALL;
			}
			return Installer.INSTALLATION_INTEGRITY.BAD_INSTALL;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		public void CleanProgramData()
		{
			try
			{
				if (Directory.Exists(Utils.GetProgramDataPath()))
				{
					Utils.Log("Installer::Cleaning ProgramData");
					string text = Utils.GetProgramDataPath() + Guid.NewGuid().ToString();
					Directory.Move(Utils.GetProgramDataPath(), text);
					Directory.Delete(text, true);
				}
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000D564 File Offset: 0x0000B764
		public void ResumeInstallation()
		{
			if (!this.MayInstall)
			{
				Installer.STATE state = this.State;
				if (state <= Installer.STATE.UNPACKING)
				{
					this.MayInstall = true;
					return;
				}
				if (state != Installer.STATE.INSTALLING)
				{
					return;
				}
				this.MayInstall = true;
				this.Install();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000D59E File Offset: 0x0000B79E
		private bool isAgentRunning()
		{
			return Process.GetProcessesByName("lghub_agent").Length != 0;
		}

		// Token: 0x04000122 RID: 290
		public Installer.STATE State;

		// Token: 0x04000123 RID: 291
		public bool MayInstall = true;

		// Token: 0x04000124 RID: 292
		private DispatcherTimer _agentCheckTimer;

		// Token: 0x04000125 RID: 293
		private bool _isInstallationRunning;

		// Token: 0x04000126 RID: 294
		private object _downloadLock = new object();

		// Token: 0x04000127 RID: 295
		private Engine.InstallCallback _callback;

		// Token: 0x0400012C RID: 300
		public Installer.launch_updater_installDelegate launch_updater_install = Core.GetDllFunction<Installer.launch_updater_installDelegate>("logi_installer_shared.dll", "launch_updater_install");

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000164 RID: 356
		public delegate void UpdateEventHandler(object sender, ProgressUpdateArgs args);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000168 RID: 360
		public delegate void InstallerErrorEventHandler(object sender, InstallerErrorArgs args);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600016C RID: 364
		public delegate void InstallerStateChangeEventHandler(object sender, InstallerStateChangeArgs args);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000170 RID: 368
		public delegate void DownloadRetryEventHandler(object sender, DownloadRetryArgs args);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000174 RID: 372
		public delegate bool launch_updater_installDelegate();

		// Token: 0x02000040 RID: 64
		public enum STATE
		{
			// Token: 0x040001BC RID: 444
			FAILED_STARTING_INSTALL = -4,
			// Token: 0x040001BD RID: 445
			FAILED_DLL_LOADING,
			// Token: 0x040001BE RID: 446
			FAILED_UNPACKING,
			// Token: 0x040001BF RID: 447
			ERROR,
			// Token: 0x040001C0 RID: 448
			SETUP,
			// Token: 0x040001C1 RID: 449
			DOWNLOADING,
			// Token: 0x040001C2 RID: 450
			UNPACKING,
			// Token: 0x040001C3 RID: 451
			SUCCESS_UNPACKING,
			// Token: 0x040001C4 RID: 452
			INSTALLING,
			// Token: 0x040001C5 RID: 453
			INSTALLED,
			// Token: 0x040001C6 RID: 454
			GHUB_INSTALLED,
			// Token: 0x040001C7 RID: 455
			LGS_INSTALLED,
			// Token: 0x040001C8 RID: 456
			BAD_INSTALL,
			// Token: 0x040001C9 RID: 457
			UNINSTALLING,
			// Token: 0x040001CA RID: 458
			NEEDS_REBOOT
		}

		// Token: 0x02000041 RID: 65
		public enum INSTALLATION_INTEGRITY
		{
			// Token: 0x040001CC RID: 460
			COMPLETE,
			// Token: 0x040001CD RID: 461
			REGISTRY_MISSING,
			// Token: 0x040001CE RID: 462
			LGS_INSTALLED,
			// Token: 0x040001CF RID: 463
			NO_INSTALL,
			// Token: 0x040001D0 RID: 464
			BAD_INSTALL
		}
	}
}
