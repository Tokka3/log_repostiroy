using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace Logi
{
	// Token: 0x0200000A RID: 10
	public class Spinner : UserControl, IComponentConnector
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000BA0C File Offset: 0x00009C0C
		public Spinner()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000BA1C File Offset: 0x00009C1C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/spinner.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000BA4C File Offset: 0x00009C4C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.AnimatedRotateTransform = (RotateTransform)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x040000C9 RID: 201
		internal RotateTransform AnimatedRotateTransform;

		// Token: 0x040000CA RID: 202
		private bool _contentLoaded;
	}
}
