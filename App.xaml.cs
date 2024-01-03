using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Logi
{
	// Token: 0x0200001E RID: 30
	public partial class App : Application
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
		public string Brand
		{
			get
			{
				if (this._brand == null)
				{
					this._brand = Utils.GetBrandName();
				}
				return this._brand;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000E003 File Offset: 0x0000C203
		public App()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000E055 File Offset: 0x0000C255
		[STAThread]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public static void Main()
		{
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}

		// Token: 0x04000151 RID: 337
		private string _brand;
	}
}
