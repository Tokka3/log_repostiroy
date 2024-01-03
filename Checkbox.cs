using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Logi
{
	// Token: 0x02000004 RID: 4
	public class Checkbox : UserControl, IComponentConnector
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000A277 File Offset: 0x00008477
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000A289 File Offset: 0x00008489
		public bool Checked
		{
			get
			{
				return (bool)base.GetValue(Checkbox.StateProperty);
			}
			set
			{
				base.SetValue(Checkbox.StateProperty, value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000A29C File Offset: 0x0000849C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000A2AE File Offset: 0x000084AE
		public string Text
		{
			get
			{
				return (string)base.GetValue(Checkbox.TextProperty);
			}
			set
			{
				base.SetValue(Checkbox.TextProperty, value);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000A2BC File Offset: 0x000084BC
		public Checkbox()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000A2CA File Offset: 0x000084CA
		public void OnClick(object sender, EventArgs e)
		{
			this.Checked = !this.Checked;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000A2DC File Offset: 0x000084DC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/checkbox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000A30C File Offset: 0x0000850C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((TextBlock)target).PreviewMouseDown += new MouseButtonEventHandler(this.OnClick);
				return;
			}
			if (connectionId != 2)
			{
				this._contentLoaded = true;
				return;
			}
			this.Trigger = (Button)target;
			this.Trigger.Click += new RoutedEventHandler(this.OnClick);
		}

		// Token: 0x04000094 RID: 148
		public static readonly DependencyProperty StateProperty = DependencyProperty.Register("Checked", typeof(bool), typeof(Checkbox), new PropertyMetadata(true));

		// Token: 0x04000095 RID: 149
		public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(Checkbox), new PropertyMetadata(""));

		// Token: 0x04000096 RID: 150
		internal Button Trigger;

		// Token: 0x04000097 RID: 151
		private bool _contentLoaded;
	}
}
