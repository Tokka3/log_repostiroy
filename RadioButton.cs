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
	// Token: 0x02000009 RID: 9
	public class RadioButton : UserControl, IComponentConnector
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000049 RID: 73 RVA: 0x0000B828 File Offset: 0x00009A28
		// (remove) Token: 0x0600004A RID: 74 RVA: 0x0000B860 File Offset: 0x00009A60
		public event RadioButton.UpdateEventHandler ClickEvent;

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000B895 File Offset: 0x00009A95
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000B8A7 File Offset: 0x00009AA7
		public bool Active
		{
			get
			{
				return (bool)base.GetValue(RadioButton.StateProperty);
			}
			set
			{
				base.SetValue(RadioButton.StateProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000B8BA File Offset: 0x00009ABA
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000B8CC File Offset: 0x00009ACC
		public string Text
		{
			get
			{
				return (string)base.GetValue(RadioButton.TextProperty);
			}
			set
			{
				base.SetValue(RadioButton.TextProperty, value);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000B8DA File Offset: 0x00009ADA
		public RadioButton()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		public void OnClick(object sender, EventArgs e)
		{
			if (!this.Active)
			{
				this.Active = !this.Active;
				this.ClickEvent(this, new RadioArgs(this.Active));
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000B918 File Offset: 0x00009B18
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/radiobutton.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000B948 File Offset: 0x00009B48
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

		// Token: 0x040000C5 RID: 197
		public static readonly DependencyProperty StateProperty = DependencyProperty.Register("Active", typeof(bool), typeof(RadioButton), new PropertyMetadata(true));

		// Token: 0x040000C6 RID: 198
		public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(RadioButton), new PropertyMetadata(""));

		// Token: 0x040000C7 RID: 199
		internal Button Trigger;

		// Token: 0x040000C8 RID: 200
		private bool _contentLoaded;

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600011C RID: 284
		public delegate void UpdateEventHandler(object sender, RadioArgs args);
	}
}
