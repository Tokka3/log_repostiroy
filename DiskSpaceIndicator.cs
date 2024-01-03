using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Logi
{
	// Token: 0x02000006 RID: 6
	public class DiskSpaceIndicator : UserControl, IComponentConnector
	{
		// Token: 0x0600001A RID: 26 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		public DiskSpaceIndicator()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		private void update()
		{
			string text = this.InstallPath.Equals("") ? "" : this.InstallPath.Substring(0, 1);
			if (this.Available < 500L)
			{
				this.ErrorText = string.Format(Strings.Get(STRING.INSTALLER_DISK_INDICATOR_ERROR), text);
				return;
			}
			if (this.Available < 1000L)
			{
				this.WarningText = string.Format(Strings.Get(STRING.INSTALLER_DISK_INDICATOR_WARNING), text);
				return;
			}
			long num = this.Available / 1024L;
			this.NormalText = string.Format(Strings.Get(STRING.INSTALLER_DISK_INDICATOR_NORMAL), num, text);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000AC67 File Offset: 0x00008E67
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000AC79 File Offset: 0x00008E79
		public long Available
		{
			get
			{
				return (long)base.GetValue(DiskSpaceIndicator.AvailableProperty);
			}
			set
			{
				base.SetValue(DiskSpaceIndicator.AvailableProperty, value);
				this.update();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000AC92 File Offset: 0x00008E92
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		public string InstallPath
		{
			get
			{
				return (string)base.GetValue(DiskSpaceIndicator.InstallPathProperty);
			}
			set
			{
				base.SetValue(DiskSpaceIndicator.InstallPathProperty, value);
				this.update();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000ACCA File Offset: 0x00008ECA
		public string WarningText
		{
			get
			{
				return (string)base.GetValue(DiskSpaceIndicator.WarningTextProperty);
			}
			set
			{
				base.SetValue(DiskSpaceIndicator.WarningTextProperty, value);
				this.Notification.Visibility = Visibility.Hidden;
				this.WarningNotification.Visibility = Visibility.Visible;
				this.ErrorNotification.Visibility = Visibility.Hidden;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000ACFC File Offset: 0x00008EFC
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000AD0E File Offset: 0x00008F0E
		public string ErrorText
		{
			get
			{
				return (string)base.GetValue(DiskSpaceIndicator.ErrorTextProperty);
			}
			set
			{
				base.SetValue(DiskSpaceIndicator.ErrorTextProperty, value);
				this.Notification.Visibility = Visibility.Hidden;
				this.WarningNotification.Visibility = Visibility.Hidden;
				this.ErrorNotification.Visibility = Visibility.Visible;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000AD40 File Offset: 0x00008F40
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000AD52 File Offset: 0x00008F52
		public string NormalText
		{
			get
			{
				return (string)base.GetValue(DiskSpaceIndicator.NormalTextProperty);
			}
			set
			{
				base.SetValue(DiskSpaceIndicator.NormalTextProperty, value);
				this.Notification.Visibility = Visibility.Visible;
				this.WarningNotification.Visibility = Visibility.Hidden;
				this.ErrorNotification.Visibility = Visibility.Hidden;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000AD84 File Offset: 0x00008F84
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/diskspaceindicator.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.WarningNotification = (StackPanel)target;
				return;
			case 2:
				this.ErrorNotification = (StackPanel)target;
				return;
			case 3:
				this.Notification = (Grid)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040000AC RID: 172
		public static readonly DependencyProperty AvailableProperty = DependencyProperty.Register("Available", typeof(long), typeof(DiskSpaceIndicator), new PropertyMetadata(0L));

		// Token: 0x040000AD RID: 173
		public static readonly DependencyProperty InstallPathProperty = DependencyProperty.Register("InstallPath", typeof(string), typeof(DiskSpaceIndicator), new PropertyMetadata(""));

		// Token: 0x040000AE RID: 174
		public static readonly DependencyProperty WarningTextProperty = DependencyProperty.Register("WarningText", typeof(string), typeof(DiskSpaceIndicator), new PropertyMetadata(""));

		// Token: 0x040000AF RID: 175
		public static readonly DependencyProperty ErrorTextProperty = DependencyProperty.Register("ErrorText", typeof(string), typeof(DiskSpaceIndicator), new PropertyMetadata(""));

		// Token: 0x040000B0 RID: 176
		public static readonly DependencyProperty NormalTextProperty = DependencyProperty.Register("NormalText", typeof(string), typeof(DiskSpaceIndicator), new PropertyMetadata(""));

		// Token: 0x040000B1 RID: 177
		internal StackPanel WarningNotification;

		// Token: 0x040000B2 RID: 178
		internal StackPanel ErrorNotification;

		// Token: 0x040000B3 RID: 179
		internal Grid Notification;

		// Token: 0x040000B4 RID: 180
		private bool _contentLoaded;
	}
}
