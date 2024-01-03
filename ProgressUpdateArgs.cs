using System;

namespace Logi
{
	// Token: 0x02000015 RID: 21
	public class ProgressUpdateArgs : EventArgs
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0000D190 File Offset: 0x0000B390
		public ProgressUpdateArgs(Engine.PROGRESS_TYPE progressType, float percent, float downloaded, float totalToDownload)
		{
			this.ProgressType = progressType;
			this.Percent = percent;
			this.Downloaded = downloaded;
			this.TotalToDownload = totalToDownload;
		}

		// Token: 0x0400011B RID: 283
		public Engine.PROGRESS_TYPE ProgressType;

		// Token: 0x0400011C RID: 284
		public float Percent;

		// Token: 0x0400011D RID: 285
		public float Downloaded;

		// Token: 0x0400011E RID: 286
		public float TotalToDownload;
	}
}
