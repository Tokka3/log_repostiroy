using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;

namespace Logi
{
	// Token: 0x02000007 RID: 7
	public class ModalDialog : UserControl, IComponentConnector
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000AEF8 File Offset: 0x000090F8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000AF0A File Offset: 0x0000910A
		public string Title
		{
			get
			{
				return (string)base.GetValue(ModalDialog.TitleProperty);
			}
			set
			{
				base.SetValue(ModalDialog.TitleProperty, value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600002B RID: 43 RVA: 0x0000AF18 File Offset: 0x00009118
		// (remove) Token: 0x0600002C RID: 44 RVA: 0x0000AF50 File Offset: 0x00009150
		public event EventHandler<EventArgs> LeftClick;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002D RID: 45 RVA: 0x0000AF88 File Offset: 0x00009188
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x0000AFC0 File Offset: 0x000091C0
		public event EventHandler<EventArgs> CenterClick;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002F RID: 47 RVA: 0x0000AFF8 File Offset: 0x000091F8
		// (remove) Token: 0x06000030 RID: 48 RVA: 0x0000B030 File Offset: 0x00009230
		public event EventHandler<EventArgs> RightClick;

		// Token: 0x06000031 RID: 49 RVA: 0x0000B065 File Offset: 0x00009265
		public ModalDialog(ModalDialog.DIALOG_TYPE type)
		{
			this.InitializeComponent();
			this._dialogType = type;
			this.createDialogByType(this._dialogType);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000B086 File Offset: 0x00009286
		private void OnLeftClick(object sender, RoutedEventArgs e)
		{
			EventHandler<EventArgs> leftClick = this.LeftClick;
			if (leftClick == null)
			{
				return;
			}
			leftClick(this, e);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000B09A File Offset: 0x0000929A
		private void OnCenterClick(object sender, RoutedEventArgs e)
		{
			EventHandler<EventArgs> centerClick = this.CenterClick;
			if (centerClick == null)
			{
				return;
			}
			centerClick(this, e);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000B0AE File Offset: 0x000092AE
		private void OnRightClick(object sender, RoutedEventArgs e)
		{
			EventHandler<EventArgs> rightClick = this.RightClick;
			if (rightClick == null)
			{
				return;
			}
			rightClick(this, e);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000B0C2 File Offset: 0x000092C2
		public void Show(Grid container)
		{
			container.Children.Clear();
			container.Children.Add(this);
			container.Visibility = Visibility.Visible;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000B0E4 File Offset: 0x000092E4
		private void createDialogByType(ModalDialog.DIALOG_TYPE type)
		{
			switch (this._dialogType)
			{
			case ModalDialog.DIALOG_TYPE.CONFIRM_EXIT:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_EXIT);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_MODAL_CONFIRM_EXIT);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_CANCEL);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			case ModalDialog.DIALOG_TYPE.LGS_INSTALLED:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED);
				this.ButtonLeftVisible = Visibility.Hidden;
				this.ButtonRightVisible = Visibility.Hidden;
				this.ButtonCenterVisible = Visibility.Visible;
				this.ButtonCenterContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			case ModalDialog.DIALOG_TYPE.GHUB_INSTALLED:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_EXITING_SW);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_REINSTALL);
				return;
			case ModalDialog.DIALOG_TYPE.GHUB_UNINSTALLED:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS);
				this.DescriptionText = Strings.Get(STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE);
				this.ButtonLeftVisible = Visibility.Hidden;
				this.ButtonRightVisible = Visibility.Hidden;
				this.ButtonCenterVisible = Visibility.Visible;
				this.ButtonCenterContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_FAILED_INITIALIZE:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_DOWNLOAD_INIT);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_CANCEL);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_TRY_AGAIN);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_FAILED_DOWNLOAD:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_NETWORK_ISSUE);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_CANCEL);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_TRY_AGAIN);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_SUMMARY:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_UPDATE_SUMMARY);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_CANCEL);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_TRY_AGAIN);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_DISK_FULL:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_DISK_FULL);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_CANCEL);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_TRY_AGAIN);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_GENERIC:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_UNCAUGHT_ERROR);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_CANCEL);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_TRY_AGAIN);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_UNPACKING:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_INIT_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_UNPACKING);
				this.ButtonLeftVisible = Visibility.Hidden;
				this.ButtonRightVisible = Visibility.Hidden;
				this.ButtonCenterVisible = Visibility.Visible;
				this.ButtonCenterContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_LOADING_DLL:
			{
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_INIT_FAILED);
				Hyperlink hyperlink = new Hyperlink(new Run(Strings.Get(STRING.INSTALLER_OFFICIAL_WEBSITE)));
				hyperlink.NavigateUri = new Uri(Strings.Get(STRING.INSTALLER_OFFICIAL_WEBSITE_LINK));
				hyperlink.RequestNavigate += Utils.OpenExternalHyperlink;
				hyperlink.Foreground = (SolidColorBrush)Application.Current.Resources["BrushAzuro"];
				hyperlink.FontWeight = FontWeights.Light;
				hyperlink.TextDecorations = null;
				this.DialogDescription.Inlines.Add(new TextBlock
				{
					Text = Strings.Get(STRING.INSTALLER_ERROR_DLL_LOADING) + "\n"
				});
				this.DialogDescription.Inlines.Add(new TextBlock
				{
					Text = Strings.Get(STRING.INSTALLER_ERROR_REDOWNLOAD)
				});
				this.DialogDescription.Inlines.Add(hyperlink);
				this.ButtonLeftVisible = Visibility.Hidden;
				this.ButtonRightVisible = Visibility.Hidden;
				this.ButtonCenterVisible = Visibility.Visible;
				this.ButtonCenterContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			}
			case ModalDialog.DIALOG_TYPE.ERROR_START_INSTALL:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_START_INSTALL);
				this.ButtonLeftVisible = Visibility.Hidden;
				this.ButtonRightVisible = Visibility.Hidden;
				this.ButtonCenterVisible = Visibility.Visible;
				this.ButtonCenterContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			case ModalDialog.DIALOG_TYPE.ERROR_OS_VERSION:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_FAILED);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_ERROR_OS_VERSION);
				this.ButtonLeftVisible = Visibility.Hidden;
				this.ButtonRightVisible = Visibility.Hidden;
				this.ButtonCenterVisible = Visibility.Visible;
				this.ButtonCenterContent = Strings.Get(STRING.INSTALLER_GENERIC_QUIT);
				return;
			case ModalDialog.DIALOG_TYPE.REBOOT_CTA:
				this.Title = Strings.Get(STRING.INSTALLER_MODAL_TITLE_REBOOT);
				this.DescriptionText = Strings.Get(STRING.INSTALLER_MODAL_REBOOT);
				this.ButtonLeftContent = Strings.Get(STRING.INSTALLER_GENERIC_REBOOT_LATER);
				this.ButtonRightContent = Strings.Get(STRING.INSTALLER_GENERIC_REBOOT_NOW);
				return;
			default:
				return;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000B4FB File Offset: 0x000096FB
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000B50D File Offset: 0x0000970D
		public string DescriptionText
		{
			get
			{
				return (string)base.GetValue(ModalDialog.DescriptionTextProperty);
			}
			set
			{
				base.SetValue(ModalDialog.DescriptionTextProperty, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000B51B File Offset: 0x0000971B
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000B52D File Offset: 0x0000972D
		public string ButtonLeftContent
		{
			get
			{
				return (string)base.GetValue(ModalDialog.ButtonLeftContentProperty);
			}
			set
			{
				base.SetValue(ModalDialog.ButtonLeftContentProperty, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000B53B File Offset: 0x0000973B
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000B54D File Offset: 0x0000974D
		public Visibility ButtonLeftVisible
		{
			get
			{
				return (Visibility)base.GetValue(ModalDialog.ButtonLeftVisibleProperty);
			}
			set
			{
				base.SetValue(ModalDialog.ButtonLeftVisibleProperty, value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000B560 File Offset: 0x00009760
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000B572 File Offset: 0x00009772
		public string ButtonCenterContent
		{
			get
			{
				return (string)base.GetValue(ModalDialog.ButtonCenterContentProperty);
			}
			set
			{
				base.SetValue(ModalDialog.ButtonCenterContentProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000B580 File Offset: 0x00009780
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000B592 File Offset: 0x00009792
		public Visibility ButtonCenterVisible
		{
			get
			{
				return (Visibility)base.GetValue(ModalDialog.ButtonCenterVisibleProperty);
			}
			set
			{
				base.SetValue(ModalDialog.ButtonCenterVisibleProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000B5A5 File Offset: 0x000097A5
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000B5B7 File Offset: 0x000097B7
		public string ButtonRightContent
		{
			get
			{
				return (string)base.GetValue(ModalDialog.ButtonRightContentProperty);
			}
			set
			{
				base.SetValue(ModalDialog.ButtonRightContentProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000B5C5 File Offset: 0x000097C5
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000B5D7 File Offset: 0x000097D7
		public Visibility ButtonRightVisible
		{
			get
			{
				return (Visibility)base.GetValue(ModalDialog.ButtonRightVisibleProperty);
			}
			set
			{
				base.SetValue(ModalDialog.ButtonRightVisibleProperty, value);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000B5EC File Offset: 0x000097EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/modaldialog.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000B61C File Offset: 0x0000981C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.DialogDescription = (TextBlock)target;
				return;
			case 2:
				((Button)target).Click += this.OnLeftClick;
				return;
			case 3:
				((Button)target).Click += this.OnCenterClick;
				return;
			case 4:
				((Button)target).Click += this.OnRightClick;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040000B5 RID: 181
		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(ModalDialog), new PropertyMetadata(""));

		// Token: 0x040000B6 RID: 182
		private ModalDialog.DIALOG_TYPE _dialogType;

		// Token: 0x040000BA RID: 186
		public static readonly DependencyProperty DescriptionTextProperty = DependencyProperty.Register("DescriptionText", typeof(string), typeof(ModalDialog), new PropertyMetadata(""));

		// Token: 0x040000BB RID: 187
		public static readonly DependencyProperty ButtonLeftContentProperty = DependencyProperty.Register("ButtonLeftContent", typeof(string), typeof(ModalDialog), new PropertyMetadata(""));

		// Token: 0x040000BC RID: 188
		public static readonly DependencyProperty ButtonLeftVisibleProperty = DependencyProperty.Register("ButtonLeftVisible", typeof(Visibility), typeof(ModalDialog), new PropertyMetadata(Visibility.Visible));

		// Token: 0x040000BD RID: 189
		public static readonly DependencyProperty ButtonCenterContentProperty = DependencyProperty.Register("ButtonCenterContent", typeof(string), typeof(ModalDialog), new PropertyMetadata(""));

		// Token: 0x040000BE RID: 190
		public static readonly DependencyProperty ButtonCenterVisibleProperty = DependencyProperty.Register("ButtonCenterVisible", typeof(Visibility), typeof(ModalDialog), new PropertyMetadata(Visibility.Hidden));

		// Token: 0x040000BF RID: 191
		public static readonly DependencyProperty ButtonRightContentProperty = DependencyProperty.Register("ButtonRightContent", typeof(string), typeof(ModalDialog), new PropertyMetadata(""));

		// Token: 0x040000C0 RID: 192
		public static readonly DependencyProperty ButtonRightVisibleProperty = DependencyProperty.Register("ButtonRightVisible", typeof(Visibility), typeof(ModalDialog), new PropertyMetadata(Visibility.Visible));

		// Token: 0x040000C1 RID: 193
		internal TextBlock DialogDescription;

		// Token: 0x040000C2 RID: 194
		private bool _contentLoaded;

		// Token: 0x02000020 RID: 32
		public enum DIALOG_TYPE
		{
			// Token: 0x04000174 RID: 372
			NONE,
			// Token: 0x04000175 RID: 373
			CONFIRM_EXIT,
			// Token: 0x04000176 RID: 374
			LGS_INSTALLED,
			// Token: 0x04000177 RID: 375
			GHUB_INSTALLED,
			// Token: 0x04000178 RID: 376
			GHUB_UNINSTALLED,
			// Token: 0x04000179 RID: 377
			ERROR_FAILED_INITIALIZE,
			// Token: 0x0400017A RID: 378
			ERROR_FAILED_DOWNLOAD,
			// Token: 0x0400017B RID: 379
			ERROR_SUMMARY,
			// Token: 0x0400017C RID: 380
			ERROR_DISK_FULL,
			// Token: 0x0400017D RID: 381
			ERROR_GENERIC,
			// Token: 0x0400017E RID: 382
			ERROR_UNPACKING,
			// Token: 0x0400017F RID: 383
			ERROR_LOADING_DLL,
			// Token: 0x04000180 RID: 384
			ERROR_START_INSTALL,
			// Token: 0x04000181 RID: 385
			ERROR_OS_VERSION,
			// Token: 0x04000182 RID: 386
			REBOOT_CTA
		}
	}
}
