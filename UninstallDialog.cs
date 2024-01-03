using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Logi
{
	// Token: 0x0200000B RID: 11
	public class UninstallDialog : UserControl, IComponentConnector
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000BA68 File Offset: 0x00009C68
		public UninstallDialog(Grid container, Action exitInstaller, Action<bool> confirmUninstall, bool isBadInstall, bool isUninstall = false)
		{
			this.InitializeComponent();
			this._state = UninstallDialog.STATE.SETUP;
			this._exitInstaller = exitInstaller;
			this._confirmUninstall = confirmUninstall;
			this._isBadInstall = isBadInstall;
			this._isUninstall = isUninstall;
			if (!this._isUninstall)
			{
				this.createSetupPage();
			}
			else
			{
				this.createUninstallPage();
			}
			container.Children.Clear();
			container.Children.Add(this);
			container.Visibility = Visibility.Visible;
			this._container = container;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000BAE2 File Offset: 0x00009CE2
		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			this.RadioButtonLaunch.ClickEvent += this.OnLaunchRadio;
			this.RadioButtonReinstall.ClickEvent += this.OnReinstallRadio;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000BB14 File Offset: 0x00009D14
		private void createSetupPage()
		{
			if (!this._isBadInstall)
			{
				this.DialogDescription.Text = Strings.Get(STRING.UNINSTALLER_ALREADY_INSTALLED);
				this.ContainerLauncher.Visibility = Visibility.Visible;
				this.RadioButtonLaunch.Text = Strings.Get(STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH);
				this.RadioButtonLaunch.Active = true;
				this.RadioButtonReinstall.Text = Strings.Get(STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL);
				this.RadioButtonReinstall.Active = false;
				this.CheckboxSaveSettings.Visibility = Visibility.Collapsed;
				this.BtnRightContent = Strings.Get(STRING.INSTALLER_GENERIC_LAUNCH_GHUB);
			}
			else
			{
				this.DialogDescription.Text = Strings.Get(STRING.UNINSTALLER_ALREADY_INSTALLED_BAD);
				this.BtnRightContent = Strings.Get(STRING.INSTALLER_GENERIC_REINSTALL);
			}
			this.DialogTitle = Strings.Get(STRING.INSTALLER_MODAL_TITLE_EXITING_SW);
			this.BtnLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
			this.BtnLeftVisible = Visibility.Visible;
			this.BtnRightVisible = Visibility.Visible;
			this._state = UninstallDialog.STATE.SETUP;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000BBEC File Offset: 0x00009DEC
		private void createUninstallPage()
		{
			this.DialogTitle = Strings.Get(STRING.UNINSTALLER_TITLE);
			this.DialogDescription.Text = Strings.Get(STRING.UNINSTALLER_DESCRIPTION);
			this.BtnLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
			this.BtnRightContent = Strings.Get(STRING.INSTALLER_GENERIC_UNINSTALL);
			this.BtnLeftVisible = Visibility.Visible;
			this.BtnRightVisible = Visibility.Visible;
			this._state = UninstallDialog.STATE.UNINSTALL;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000BC48 File Offset: 0x00009E48
		private void createConfirmationPage()
		{
			this.ContainerLauncher.Visibility = Visibility.Collapsed;
			this.DialogTitle = Strings.Get(STRING.INSTALLER_MODAL_TITLE_CONFIRM);
			this.DialogDescription.Text = Strings.Get(STRING.UNINSTALLER_MODAL_DESCRIPTION);
			this.BtnLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_BACK);
			this.BtnRightContent = Strings.Get(STRING.INSTALLER_GENERIC_REINSTALL);
			if (Utils.SettingsExist())
			{
				this.CheckboxSaveSettings.Text = Strings.Get(STRING.UNINSTALLER_MODAL_SETTINGS);
				this.CheckboxSaveSettings.Checked = true;
				this.CheckboxSaveSettings.Visibility = Visibility.Visible;
			}
			this._state = UninstallDialog.STATE.CONFIRMATION;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		private void OnLeftButtonClick(object sender, RoutedEventArgs e)
		{
			switch (this._state)
			{
			case UninstallDialog.STATE.SETUP:
			case UninstallDialog.STATE.UNINSTALL:
				this._exitInstaller();
				return;
			case UninstallDialog.STATE.CONFIRMATION:
				this.createSetupPage();
				return;
			default:
				return;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000BD0C File Offset: 0x00009F0C
		private void OnRightButtonClick(object sender, RoutedEventArgs e)
		{
			UninstallDialog.STATE state = this._state;
			if (state != UninstallDialog.STATE.SETUP)
			{
				if (state - UninstallDialog.STATE.CONFIRMATION > 1)
				{
					return;
				}
				if (this.CheckboxSaveSettings.Checked && !this._isUninstall)
				{
					this._saveSettings = true;
				}
				this._container.Visibility = Visibility.Hidden;
				this._confirmUninstall(this._saveSettings);
				return;
			}
			else
			{
				if (this._isBadInstall)
				{
					this.createConfirmationPage();
					return;
				}
				if (this.RadioButtonLaunch.Active)
				{
					Utils.StartGHUB();
					this._exitInstaller();
					return;
				}
				this.createConfirmationPage();
				return;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000BD98 File Offset: 0x00009F98
		private void OnLaunchRadio(object sender, RadioArgs e)
		{
			this.RadioButtonReinstall.Active = false;
			this.BtnRightContent = Strings.Get(STRING.INSTALLER_GENERIC_LAUNCH_GHUB);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000BDB2 File Offset: 0x00009FB2
		private void OnReinstallRadio(object sender, RadioArgs e)
		{
			this.RadioButtonLaunch.Active = false;
			this.BtnRightContent = Strings.Get(STRING.INSTALLER_GENERIC_REINSTALL);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000BDCC File Offset: 0x00009FCC
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000BDDE File Offset: 0x00009FDE
		public string DialogTitle
		{
			get
			{
				return (string)base.GetValue(UninstallDialog.TitleProperty);
			}
			set
			{
				base.SetValue(UninstallDialog.TitleProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000BDEC File Offset: 0x00009FEC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000BDFE File Offset: 0x00009FFE
		public string BtnLeftContent
		{
			get
			{
				return (string)base.GetValue(UninstallDialog.ButtonLeftContentProperty);
			}
			set
			{
				base.SetValue(UninstallDialog.ButtonLeftContentProperty, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000BE0C File Offset: 0x0000A00C
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000BE1E File Offset: 0x0000A01E
		public Visibility BtnLeftVisible
		{
			get
			{
				return (Visibility)base.GetValue(UninstallDialog.ButtonLeftVisibleProperty);
			}
			set
			{
				base.SetValue(UninstallDialog.ButtonLeftVisibleProperty, value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000BE31 File Offset: 0x0000A031
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000BE43 File Offset: 0x0000A043
		public string BtnRightContent
		{
			get
			{
				return (string)base.GetValue(UninstallDialog.ButtonRightContentProperty);
			}
			set
			{
				base.SetValue(UninstallDialog.ButtonRightContentProperty, value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000BE51 File Offset: 0x0000A051
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000BE63 File Offset: 0x0000A063
		public Visibility BtnRightVisible
		{
			get
			{
				return (Visibility)base.GetValue(UninstallDialog.ButtonRightVisibleProperty);
			}
			set
			{
				base.SetValue(UninstallDialog.ButtonRightVisibleProperty, value);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000BE78 File Offset: 0x0000A078
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/uninstalldialog.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((UninstallDialog)target).Loaded += this.OnLoaded;
				return;
			case 2:
				this.DialogDescription = (TextBlock)target;
				return;
			case 3:
				this.ContainerLauncher = (StackPanel)target;
				return;
			case 4:
				this.RadioButtonLaunch = (RadioButton)target;
				return;
			case 5:
				this.RadioButtonReinstall = (RadioButton)target;
				return;
			case 6:
				this.CheckboxSaveSettings = (Checkbox)target;
				return;
			case 7:
				this.ContainerButtons = (Grid)target;
				return;
			case 8:
				((Button)target).Click += this.OnLeftButtonClick;
				return;
			case 9:
				((Button)target).Click += this.OnRightButtonClick;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040000CB RID: 203
		private UninstallDialog.STATE _state;

		// Token: 0x040000CC RID: 204
		private Action _exitInstaller;

		// Token: 0x040000CD RID: 205
		private Action<bool> _confirmUninstall;

		// Token: 0x040000CE RID: 206
		private bool _isBadInstall;

		// Token: 0x040000CF RID: 207
		private bool _isUninstall;

		// Token: 0x040000D0 RID: 208
		private bool _saveSettings;

		// Token: 0x040000D1 RID: 209
		private Grid _container;

		// Token: 0x040000D2 RID: 210
		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("DialogTitle", typeof(string), typeof(UninstallDialog), new PropertyMetadata(""));

		// Token: 0x040000D3 RID: 211
		public static readonly DependencyProperty ButtonLeftContentProperty = DependencyProperty.Register("BtnLeftContent", typeof(string), typeof(UninstallDialog), new PropertyMetadata(""));

		// Token: 0x040000D4 RID: 212
		public static readonly DependencyProperty ButtonLeftVisibleProperty = DependencyProperty.Register("BtnLeftVisible", typeof(Visibility), typeof(ModalDialog), new PropertyMetadata(Visibility.Visible));

		// Token: 0x040000D5 RID: 213
		public static readonly DependencyProperty ButtonRightContentProperty = DependencyProperty.Register("BtnRightContent", typeof(string), typeof(UninstallDialog), new PropertyMetadata(""));

		// Token: 0x040000D6 RID: 214
		public static readonly DependencyProperty ButtonRightVisibleProperty = DependencyProperty.Register("BtnRightVisible", typeof(Visibility), typeof(ModalDialog), new PropertyMetadata(Visibility.Visible));

		// Token: 0x040000D7 RID: 215
		internal TextBlock DialogDescription;

		// Token: 0x040000D8 RID: 216
		internal StackPanel ContainerLauncher;

		// Token: 0x040000D9 RID: 217
		internal RadioButton RadioButtonLaunch;

		// Token: 0x040000DA RID: 218
		internal RadioButton RadioButtonReinstall;

		// Token: 0x040000DB RID: 219
		internal Checkbox CheckboxSaveSettings;

		// Token: 0x040000DC RID: 220
		internal Grid ContainerButtons;

		// Token: 0x040000DD RID: 221
		private bool _contentLoaded;

		// Token: 0x02000022 RID: 34
		public enum STATE
		{
			// Token: 0x04000184 RID: 388
			SETUP,
			// Token: 0x04000185 RID: 389
			CONFIRMATION,
			// Token: 0x04000186 RID: 390
			UNINSTALL
		}
	}
}
