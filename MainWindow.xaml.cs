using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace Logi
{
	// Token: 0x0200001F RID: 31
	public partial class MainWindow : Window
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x0000E068 File Offset: 0x0000C268
		public MainWindow()
		{
			if (Environment.CommandLine.Contains("--log"))
			{
				Utils.EnableLogs();
			}
			this._IsSilent = Environment.CommandLine.Contains("--silent");
			this._IsUninstall = Environment.CommandLine.Contains("--uninstall");
			this._IsUninstallFull = Environment.CommandLine.Contains("--full");
			this._IsRepair = Environment.CommandLine.Contains("--repair");
			Utils.Log("Main: Command line arguments:\n" + string.Format("\tSilent: {0}\n", this._IsSilent) + string.Format("\tUninstall: {0} {1}", this._IsUninstall, this._IsUninstallFull ? "- Full\n" : "\n") + string.Format("\tRepair: {0}", this._IsRepair));
			if (this._IsUninstall && this._IsUninstallFull && Utils.CopyUninstallerAndRun())
			{
				this.quit();
				return;
			}
			Utils.FocusExistingApp();
			Engine.Initialize();
			this._Installer = new Installer();
			switch (this._Installer.GetInstallationIntegrity())
			{
			case Installer.INSTALLATION_INTEGRITY.COMPLETE:
				this._Installer.State = Installer.STATE.GHUB_INSTALLED;
				break;
			case Installer.INSTALLATION_INTEGRITY.REGISTRY_MISSING:
			case Installer.INSTALLATION_INTEGRITY.BAD_INSTALL:
				this._Installer.State = Installer.STATE.BAD_INSTALL;
				break;
			case Installer.INSTALLATION_INTEGRITY.LGS_INSTALLED:
				this._Installer.State = Installer.STATE.LGS_INSTALLED;
				break;
			case Installer.INSTALLATION_INTEGRITY.NO_INSTALL:
				this._Installer.State = Installer.STATE.SETUP;
				break;
			}
			Core.RemoveAppFromStartup();
			if (Core.UNPACK_RESULT.NOT_PERFORMED_YET == Core.unpackResult)
			{
				Core.unpackResult = Core.UnpackAndInstallRedist();
			}
			if (Core.unpackResult != Core.UNPACK_RESULT.SUCCESS)
			{
				if (Core.UNPACK_RESULT.FAILED_DLL_LOADING == Core.unpackResult)
				{
					this._Installer.State = Installer.STATE.FAILED_DLL_LOADING;
				}
				else if (Core.UNPACK_RESULT.NEEDS_REBOOT == Core.unpackResult)
				{
					this._Installer.State = Installer.STATE.NEEDS_REBOOT;
				}
				else
				{
					this._Installer.State = Installer.STATE.FAILED_UNPACKING;
				}
			}
			if (!this._IsSilent || this._IsUninstall)
			{
				Utils.Log("Main::Displaying application");
				this.InitializeComponent();
				base.ShowInTaskbar = true;
				base.Visibility = Visibility.Visible;
				return;
			}
			if (this._Installer.State == Installer.STATE.LGS_INSTALLED || this._Installer.State == Installer.STATE.GHUB_INSTALLED)
			{
				Utils.Log("G HUB or LGS is already installed, exiting");
				this.quit();
				return;
			}
			Utils.Log("Main::Silently installing");
			if (!this._PipelineCreated)
			{
				try
				{
					Engine.Create();
					this._PipelineCreated = true;
				}
				catch (Exception ex)
				{
					Utils.Log("Main::Failed to create engine with error -> " + ex.Message);
				}
			}
			this.startSilentInstallation();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			this.initializeUI();
			try
			{
				Engine.Create();
				this._PipelineCreated = true;
			}
			catch (Exception ex)
			{
				Utils.Log("Main::Failed to create engine with error -> " + ex.Message);
				ModalDialog modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_UNPACKING);
				modalDialog.CenterClick += delegate(object ss, EventArgs ev)
				{
					this.quit();
				};
				modalDialog.Show(this.DialogContainer);
				return;
			}
			if (this._IsUninstall)
			{
				if (Installer.STATE.GHUB_INSTALLED == this._Installer.State)
				{
					new UninstallDialog(this.DialogContainer, delegate()
					{
						this.quit();
					}, delegate(bool saveSettings)
					{
						this.startUninstallation(false, saveSettings);
					}, false, true);
					this.applyNewState(Installer.STATE.SETUP);
				}
				else
				{
					new UninstallDialog(this.DialogContainer, delegate()
					{
						this.quit();
					}, delegate(bool saveSettings)
					{
						this.startUninstallation(true, saveSettings);
					}, true, true);
					this.applyNewState(Installer.STATE.SETUP);
				}
			}
			else
			{
				if ((this._Installer.State != Installer.STATE.GHUB_INSTALLED || this._Installer.State != Installer.STATE.BAD_INSTALL) && !Engine.IsCompatibleOSVersion())
				{
					ModalDialog modalDialog2 = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_OS_VERSION);
					modalDialog2.CenterClick += delegate(object ss, EventArgs ev)
					{
						this.quit();
					};
					modalDialog2.Show(this.DialogContainer);
				}
				Installer.STATE state = this._Installer.State;
				if (state != Installer.STATE.FAILED_DLL_LOADING)
				{
					if (state != Installer.STATE.FAILED_UNPACKING)
					{
						switch (state)
						{
						case Installer.STATE.GHUB_INSTALLED:
							if (Engine.IsCompatibleOSVersion())
							{
								new UninstallDialog(this.DialogContainer, delegate()
								{
									this.quit();
								}, delegate(bool saveSettings)
								{
									this.startUninstallation(false, saveSettings);
								}, false, false);
								this.applyNewState(Installer.STATE.SETUP);
							}
							else
							{
								new UninstallDialog(this.DialogContainer, delegate()
								{
									this.quit();
								}, delegate(bool saveSettings)
								{
									this.startUninstallation(false, saveSettings);
								}, true, true);
								this.applyNewState(Installer.STATE.SETUP);
							}
							break;
						case Installer.STATE.LGS_INSTALLED:
						{
							ModalDialog modalDialog3 = new ModalDialog(ModalDialog.DIALOG_TYPE.LGS_INSTALLED);
							modalDialog3.CenterClick += delegate(object ss, EventArgs ev)
							{
								this.quit();
							};
							modalDialog3.Show(this.DialogContainer);
							break;
						}
						case Installer.STATE.BAD_INSTALL:
							if (Engine.IsCompatibleOSVersion())
							{
								new UninstallDialog(this.DialogContainer, delegate()
								{
									this.quit();
								}, delegate(bool saveSettings)
								{
									this.startUninstallation(true, saveSettings);
								}, true, false);
								this.applyNewState(Installer.STATE.SETUP);
							}
							else
							{
								new UninstallDialog(this.DialogContainer, delegate()
								{
									this.quit();
								}, delegate(bool saveSettings)
								{
									this.startUninstallation(false, saveSettings);
								}, true, true);
								this.applyNewState(Installer.STATE.SETUP);
							}
							break;
						case Installer.STATE.NEEDS_REBOOT:
						{
							ModalDialog modalDialog4 = new ModalDialog(ModalDialog.DIALOG_TYPE.REBOOT_CTA);
							modalDialog4.LeftClick += delegate(object ss, EventArgs ev)
							{
								this.quit();
							};
							modalDialog4.RightClick += delegate(object ss, EventArgs ev)
							{
								Process.Start("shutdown.exe", "-r -t 0");
								this.quit();
							};
							modalDialog4.Show(this.DialogContainer);
							break;
						}
						}
					}
					else
					{
						ModalDialog modalDialog5 = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_UNPACKING);
						modalDialog5.CenterClick += delegate(object ss, EventArgs ev)
						{
							this.quit();
						};
						modalDialog5.Show(this.DialogContainer);
					}
				}
				else
				{
					ModalDialog modalDialog6 = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_LOADING_DLL);
					modalDialog6.CenterClick += delegate(object ss, EventArgs ev)
					{
						this.quit();
					};
					modalDialog6.Show(this.DialogContainer);
				}
			}
			this._Installer.ProgressUpdateEvent += this.onUpdateProgress;
			this._Installer.InstallerErrorEvent += this.onInstallerError;
			this._Installer.InstallerStateChangeEvent += this.onInstallerStateChange;
			this._Installer.DownloadRetryEvent += this.onDownloadRetry;
			this._DiskMonitor.DiskCheckEvent += this.onDiskCheckEvent;
			this._DownloadMonitor.SlowDownloadEvent += this.onSlowDownload;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000E680 File Offset: 0x0000C880
		private void applyNewState(Installer.STATE state)
		{
			if (this._Installer.State != state)
			{
				this._Installer.State = state;
				if (!this._IsSilent)
				{
					if (state == Installer.STATE.SETUP)
					{
						this.ButtonClose.IsEnabled = true;
						return;
					}
					if (Installer.STATE.DOWNLOADING == state)
					{
						if (this._IsReinstall)
						{
							this._uninstallProgressCap = 0.2;
							this.Progressbar.Value = 20.0;
						}
						else
						{
							this._uninstallProgressCap = 1.0;
							this.Progressbar.Value = 0.0;
							this.Progressbar.IsEnabled = true;
							this.DownloadInfo.Visibility = Visibility.Visible;
							this.InstallationSpinner.Visibility = Visibility.Hidden;
							this.TransferInfo = Strings.Get(STRING.INSTALLER_STEP_INITIALIZE);
							this.ContainerSetup.Visibility = Visibility.Hidden;
							this.ContainerInstallation.Visibility = Visibility.Visible;
						}
						this.DownloadTooltip = Strings.Get(STRING.INSTALLER_TOOLTIP_INSTALL);
						this.ButtonClose.IsEnabled = true;
						return;
					}
					if (Installer.STATE.UNPACKING == state)
					{
						this.Progressbar.IsEnabled = false;
						this.DownloadInfo.Visibility = Visibility.Hidden;
						this.ButtonClose.IsEnabled = true;
						this.InstallationInfo.Text = Strings.Get(STRING.INSTALLER_STEP_UNPACK);
						this.InstallationInfo.Visibility = Visibility.Visible;
						this.InstallationSpinner.Visibility = Visibility.Visible;
						return;
					}
					if (Installer.STATE.INSTALLING == state)
					{
						this.Progressbar.IsEnabled = false;
						this.DownloadInfo.Visibility = Visibility.Hidden;
						this.InstallationInfo.Text = Strings.Get(STRING.INSTALLER_STEP_INSTALLING);
						this.InstallationInfo.Visibility = Visibility.Visible;
						this.InstallationSpinner.Visibility = Visibility.Visible;
						this.ButtonClose.IsEnabled = false;
						return;
					}
					if (Installer.STATE.INSTALLED == state)
					{
						this.ButtonClose.IsEnabled = true;
						return;
					}
					if (Installer.STATE.UNINSTALLING == state)
					{
						if (this._IsUninstall)
						{
							this._uninstallProgressCap = 1.0;
						}
						else
						{
							this._uninstallProgressCap = 0.2;
						}
						this.Progressbar.Value = 0.0;
						this.Progressbar.IsEnabled = true;
						this.TransferInfo = Strings.Get(STRING.INSTALLER_STEP_INITIALIZE);
						this.DownloadInfo.Visibility = Visibility.Visible;
						this.InstallationSpinner.Visibility = Visibility.Hidden;
						this.DownloadTooltip = Strings.Get(STRING.UNINSTALLER_STATE_TOOLTIP);
						this.ContainerSetup.Visibility = Visibility.Hidden;
						this.ContainerInstallation.Visibility = Visibility.Visible;
						this.ButtonClose.IsEnabled = false;
					}
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000E8DC File Offset: 0x0000CADC
		private void initializeUI()
		{
			this.DialogContainer.Visibility = Visibility.Hidden;
			this.ContainerInstallation.Visibility = Visibility.Hidden;
			this.VersionText = string.Format(Strings.Get(STRING.INSTALLER_INFO_VERSION), Strings.Get(STRING.INSTALLER_VERSION));
			this.onDiskCheckEvent(null, null);
			this._DiskMonitor.Start();
			this.InstallButtonText = Strings.Get(STRING.INSTALLER_INSTALL_BUTTON);
			Hyperlink hyperlink = new Hyperlink(new Run(Strings.Get(STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT)));
			hyperlink.NavigateUri = new Uri(Strings.Get(STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK));
			hyperlink.RequestNavigate += Utils.OpenExternalHyperlink;
			hyperlink.Foreground = (SolidColorBrush)Application.Current.Resources["BrushTextGrey"];
			hyperlink.FontWeight = FontWeights.Light;
			hyperlink.TextDecorations = null;
			this.UserAgreement.Inlines.Add(new TextBlock
			{
				Text = Strings.Get(STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT)
			});
			this.UserAgreement.Inlines.Add(hyperlink);
			this.ContainerBranding.Visibility = Visibility.Visible;
			this.ContainerSetup.Visibility = Visibility.Visible;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		private void startInstallation()
		{
			this._DownloadMonitor.Reset();
			this._Installer.Download(this._IsSilent);
			this.applyNewState(Installer.STATE.DOWNLOADING);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000EA11 File Offset: 0x0000CC11
		private void startSilentInstallation()
		{
			this._Installer.Download(this._IsSilent);
			this.applyNewState(Installer.STATE.DOWNLOADING);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000EA2B File Offset: 0x0000CC2B
		private void startUninstallation(bool isBadInstall, bool saveSettings)
		{
			this._Uninstaller = new Uninstaller(isBadInstall, saveSettings);
			this._Uninstaller.UninstallEvent += this.onUninstallEvent;
			this._Uninstaller.Uninstall();
			this.applyNewState(Installer.STATE.UNINSTALLING);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000EA64 File Offset: 0x0000CC64
		private void onDiskCheckEvent(object sender, DiskArgs e)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\LGHUB";
			this.InstallPathText = string.Format(Strings.Get(STRING.INSTALLER_INFO_DESTINATION), text);
			long spaceOnDisk = this._DiskMonitor.GetSpaceOnDisk(Utils.GetProgramFilesPath());
			this.DiskSpaceIndicator.Available = spaceOnDisk;
			this.DiskSpaceIndicator.InstallPath = text;
			if (spaceOnDisk < 500L)
			{
				this.ButtonInstall.IsEnabled = false;
				return;
			}
			this.ButtonInstall.IsEnabled = true;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		private void onUpdateProgress(object sender, ProgressUpdateArgs args)
		{
			base.Dispatcher.BeginInvoke(new Action(delegate()
			{
				if (args.ProgressType == Engine.PROGRESS_TYPE.DOWNLOAD)
				{
					if (args.TotalToDownload > 2f)
					{
						Math.Max(Math.Min(args.Percent, 100f), 0f);
						if (this._IsReinstall)
						{
							this.Progressbar.Value = 20.0 + (double)Math.Max(Math.Min(args.Percent, 100f), 0f) * 0.8;
						}
						else
						{
							this.Progressbar.Value = (double)Math.Max(Math.Min(args.Percent, 100f), 0f);
						}
						double num = Math.Max(this._DownloadMonitor.GetRate(args.Downloaded), 0.0);
						if (num > 1000.0)
						{
							this.TransferInfo = string.Format(Strings.Get(STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS), string.Format("{0:0.0}", args.Downloaded), string.Format("{0:0.0}", args.TotalToDownload), string.Format("{0:0.00}", num / 1000.0));
							return;
						}
						this.TransferInfo = string.Format(Strings.Get(STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS), string.Format("{0:0.0}", args.Downloaded), string.Format("{0:0.0}", args.TotalToDownload), string.Format("{0:0.00}", num));
						return;
					}
				}
				else if (Engine.PROGRESS_TYPE.UNCOMPRESS == args.ProgressType)
				{
					this._DownloadMonitor.Stop();
					this.DownloadTooltip = Strings.Get(STRING.INSTALLER_TOOLTIP_INSTALL);
					this.applyNewState(Installer.STATE.UNPACKING);
				}
			}), new object[0]);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000EB24 File Offset: 0x0000CD24
		private void onUninstallEvent(object sender, UninstallerArgs args)
		{
			base.Dispatcher.BeginInvoke(new Action(delegate()
			{
				switch (args.Status)
				{
				case UNINSTALL_STATE.SUCCESS:
				{
					if (!this._IsUninstall)
					{
						Engine.Reset();
						this._IsReinstall = true;
						this.startInstallation();
						return;
					}
					ModalDialog modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.GHUB_UNINSTALLED);
					modalDialog.CenterClick += delegate(object ss, EventArgs ev)
					{
						this.quit();
					};
					modalDialog.Show(this.DialogContainer);
					return;
				}
				case UNINSTALL_STATE.ERROR:
					Utils.Log("Error uninstalling");
					return;
				case UNINSTALL_STATE.INITIALIZING:
					this.TransferInfo = args.Message;
					this.Progressbar.Value = (double)args.Progress * this._uninstallProgressCap;
					return;
				case UNINSTALL_STATE.UNINSTALLING:
					this.TransferInfo = args.Message;
					this.Progressbar.Value = (double)args.Progress * this._uninstallProgressCap;
					return;
				case UNINSTALL_STATE.REMOVING_FILES:
					this.TransferInfo = args.Message;
					this.Progressbar.Value = (double)args.Progress * this._uninstallProgressCap;
					return;
				case UNINSTALL_STATE.REMOVING_EXTRA_FILES:
					this.TransferInfo = args.Message;
					this.Progressbar.Value = (double)args.Progress * this._uninstallProgressCap;
					return;
				case UNINSTALL_STATE.FINALIZING:
					this.TransferInfo = args.Message;
					this.Progressbar.Value = (double)args.Progress * this._uninstallProgressCap;
					return;
				default:
					return;
				}
			}), new object[0]);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000EB64 File Offset: 0x0000CD64
		private void onInstallerStateChange(object sender, InstallerStateChangeArgs args)
		{
			base.Dispatcher.BeginInvoke(new Action(delegate()
			{
				this.applyNewState(args.State);
			}), new object[0]);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		private void onDownloadRetry(object sender, DownloadRetryArgs args)
		{
			base.Dispatcher.BeginInvoke(new Action(delegate()
			{
				this.TransferInfo = args.Message;
			}), new object[0]);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		private void onInstallerError(object sender, InstallerErrorArgs args)
		{
			base.Dispatcher.BeginInvoke(new Action(delegate()
			{
				int errorCode = args.ErrorCode;
				ModalDialog modalDialog;
				if (errorCode != -4)
				{
					switch (errorCode)
					{
					case 2:
					case 8:
					case 9:
						Utils.Log("Error: Failed to initialize");
						modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_FAILED_INITIALIZE);
						goto IL_E1;
					case 3:
					case 6:
						Utils.Log("Error: Failed to download");
						modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_FAILED_DOWNLOAD);
						goto IL_E1;
					case 4:
					case 7:
					case 10:
					case 11:
						break;
					case 5:
						Utils.Log("Error: Write to disk failed");
						modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_DISK_FULL);
						goto IL_E1;
					case 12:
						modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_OS_VERSION);
						modalDialog.CenterClick += delegate(object ss, EventArgs ev)
						{
							this.quit();
						};
						goto IL_E1;
					default:
						if (errorCode - 600 <= 2)
						{
							Utils.Log("Error: Failed to get or parse update summary");
							modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_SUMMARY);
							goto IL_E1;
						}
						break;
					}
					Utils.Log("Error: Unknown error");
					modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_GENERIC);
				}
				else
				{
					Utils.Log("Error: Failed to start the installation");
					modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.ERROR_SUMMARY);
				}
				IL_E1:
				modalDialog.LeftClick += delegate(object ss, EventArgs ev)
				{
					Engine.Reset();
					this.initializeUI();
				};
				modalDialog.RightClick += delegate(object ss, EventArgs ev)
				{
					Engine.Reset();
					this.DialogContainer.Visibility = Visibility.Hidden;
					this.startInstallation();
				};
				modalDialog.Show(this.DialogContainer);
			}), new object[0]);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000EC23 File Offset: 0x0000CE23
		private void onSlowDownload(object sender, MonitorArgs e)
		{
			this.DownloadTooltip = e.UserMessage;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000EC31 File Offset: 0x0000CE31
		private void quit()
		{
			Utils.Log("Main::Exiting installer");
			base.Dispatcher.BeginInvoke(new Action(delegate()
			{
				if (this._PipelineCreated)
				{
					Engine.Destroy();
				}
				Core.Cleanup();
				Application.Current.Shutdown();
			}), new object[0]);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000EC5B File Offset: 0x0000CE5B
		private void onDownloadButtonClick(object sender, RoutedEventArgs e)
		{
			this._DiskMonitor.Stop();
			this.startInstallation();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000EC6E File Offset: 0x0000CE6E
		private void Application_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000EC80 File Offset: 0x0000CE80
		private void onButtonCloseClick(object sender, RoutedEventArgs e)
		{
			if (this._Installer.State == Installer.STATE.SETUP)
			{
				ModalDialog modalDialog = new ModalDialog(ModalDialog.DIALOG_TYPE.CONFIRM_EXIT);
				modalDialog.LeftClick += delegate(object ss, EventArgs ev)
				{
					this.DialogContainer.Visibility = Visibility.Hidden;
				};
				modalDialog.RightClick += delegate(object ss, EventArgs ev)
				{
					this.quit();
				};
				modalDialog.Show(this.DialogContainer);
				return;
			}
			if (this._Installer.State == Installer.STATE.DOWNLOADING || this._Installer.State == Installer.STATE.UNPACKING)
			{
				this._Installer.MayInstall = false;
				ModalDialog modalDialog2 = new ModalDialog(ModalDialog.DIALOG_TYPE.CONFIRM_EXIT);
				modalDialog2.LeftClick += delegate(object ss, EventArgs ev)
				{
					this.DialogContainer.Visibility = Visibility.Hidden;
					this._Installer.ResumeInstallation();
				};
				modalDialog2.RightClick += delegate(object ss, EventArgs ev)
				{
					this.quit();
				};
				modalDialog2.Show(this.DialogContainer);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000ED2D File Offset: 0x0000CF2D
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000ED3F File Offset: 0x0000CF3F
		public string VersionText
		{
			get
			{
				return (string)base.GetValue(MainWindow.VersionTextProperty);
			}
			set
			{
				base.SetValue(MainWindow.VersionTextProperty, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000ED4D File Offset: 0x0000CF4D
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000ED5F File Offset: 0x0000CF5F
		public string InstallPathText
		{
			get
			{
				return (string)base.GetValue(MainWindow.InstallLocationTextProperty);
			}
			set
			{
				base.SetValue(MainWindow.InstallLocationTextProperty, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000ED6D File Offset: 0x0000CF6D
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000ED7F File Offset: 0x0000CF7F
		public string DownloadTooltip
		{
			get
			{
				return (string)base.GetValue(MainWindow.DownloadTooltipProperty);
			}
			set
			{
				base.SetValue(MainWindow.DownloadTooltipProperty, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000ED8D File Offset: 0x0000CF8D
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000ED9F File Offset: 0x0000CF9F
		public string TransferInfo
		{
			get
			{
				return (string)base.GetValue(MainWindow.TransferInfoProperty);
			}
			set
			{
				base.SetValue(MainWindow.TransferInfoProperty, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000EDAD File Offset: 0x0000CFAD
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000EDBF File Offset: 0x0000CFBF
		public string InstallInfo
		{
			get
			{
				return (string)base.GetValue(MainWindow.InstallInfoProperty);
			}
			set
			{
				base.SetValue(MainWindow.InstallInfoProperty, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000EDCD File Offset: 0x0000CFCD
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000EDDF File Offset: 0x0000CFDF
		public string InstallButtonText
		{
			get
			{
				return (string)base.GetValue(MainWindow.InstallButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(MainWindow.InstallButtonVisibilityProperty, value);
			}
		}

		// Token: 0x04000153 RID: 339
		private DiskMonitor _DiskMonitor = new DiskMonitor();

		// Token: 0x04000154 RID: 340
		private DownloadMonitor _DownloadMonitor = new DownloadMonitor();

		// Token: 0x04000155 RID: 341
		private Installer _Installer;

		// Token: 0x04000156 RID: 342
		private Uninstaller _Uninstaller;

		// Token: 0x04000157 RID: 343
		private double _uninstallProgressCap;

		// Token: 0x04000158 RID: 344
		private bool _IsSilent;

		// Token: 0x04000159 RID: 345
		private bool _IsUninstall;

		// Token: 0x0400015A RID: 346
		private bool _IsReinstall;

		// Token: 0x0400015B RID: 347
		private bool _IsRepair;

		// Token: 0x0400015C RID: 348
		private bool _IsUninstallFull;

		// Token: 0x0400015D RID: 349
		private bool _PipelineCreated;

		// Token: 0x0400015E RID: 350
		public static readonly DependencyProperty VersionTextProperty = DependencyProperty.Register("VersionText", typeof(string), typeof(MainWindow), new PropertyMetadata(""));

		// Token: 0x0400015F RID: 351
		public static readonly DependencyProperty InstallLocationTextProperty = DependencyProperty.Register("InstallPathText", typeof(string), typeof(MainWindow), new PropertyMetadata(""));

		// Token: 0x04000160 RID: 352
		public static readonly DependencyProperty DownloadTooltipProperty = DependencyProperty.Register("DownloadTooltip", typeof(string), typeof(MainWindow), new PropertyMetadata(""));

		// Token: 0x04000161 RID: 353
		public static readonly DependencyProperty TransferInfoProperty = DependencyProperty.Register("TransferInfo", typeof(string), typeof(MainWindow), new PropertyMetadata(""));

		// Token: 0x04000162 RID: 354
		public static readonly DependencyProperty InstallInfoProperty = DependencyProperty.Register("InstallInfo", typeof(string), typeof(MainWindow), new PropertyMetadata(""));

		// Token: 0x04000163 RID: 355
		public static readonly DependencyProperty InstallButtonVisibilityProperty = DependencyProperty.Register("InstallButtonText", typeof(string), typeof(MainWindow), new PropertyMetadata(""));
	}
}
