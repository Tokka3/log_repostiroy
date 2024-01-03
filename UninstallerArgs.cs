using System;

namespace Logi
{
	// Token: 0x0200001B RID: 27
	public class UninstallerArgs : EventArgs
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000D660 File Offset: 0x0000B860
		public UninstallerArgs(UNINSTALL_STATE status, float progress, string message)
		{
			this.Status = status;
			this.Progress = progress;
			this.Message = message;
		}

		// Token: 0x04000135 RID: 309
		public UNINSTALL_STATE Status;

		// Token: 0x04000136 RID: 310
		public float Progress;

		// Token: 0x04000137 RID: 311
		public string Message;
	}
}
