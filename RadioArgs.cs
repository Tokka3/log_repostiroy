using System;

namespace Logi
{
	// Token: 0x02000008 RID: 8
	public class RadioArgs : EventArgs
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000B818 File Offset: 0x00009A18
		public RadioArgs(bool active)
		{
			this.Active = active;
		}

		// Token: 0x040000C3 RID: 195
		public bool Active;
	}
}
