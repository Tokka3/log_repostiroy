using System;
using System.IO;
using System.Windows.Threading;

namespace Logi
{
	// Token: 0x02000011 RID: 17
	public class DiskMonitor
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000096 RID: 150 RVA: 0x0000CBA8 File Offset: 0x0000ADA8
		// (remove) Token: 0x06000097 RID: 151 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		public event DiskMonitor.DiskCheckEventHandler DiskCheckEvent;

		// Token: 0x06000098 RID: 152 RVA: 0x0000CC15 File Offset: 0x0000AE15
		public DiskMonitor()
		{
			this._diskMonitorTimer = new DispatcherTimer();
			this._diskMonitorTimer.Tick += this.onDiskMonitorTick;
			this._diskMonitorTimer.Interval = new TimeSpan(0, 0, 5);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000CC52 File Offset: 0x0000AE52
		public void Start()
		{
			if (!this._diskMonitorTimer.IsEnabled)
			{
				this._diskMonitorTimer.Start();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		public void Stop()
		{
			this._diskMonitorTimer.Stop();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000CC7C File Offset: 0x0000AE7C
		private void onDiskMonitorTick(object sender, EventArgs e)
		{
			DiskArgs args = new DiskArgs();
			this.DiskCheckEvent(this, args);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000CC9C File Offset: 0x0000AE9C
		public long GetSpaceOnDisk(string installPath)
		{
			long num = 0L;
			if (installPath.Length > 2)
			{
				string b = installPath.Substring(0, 3);
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					if (driveInfo.IsReady && driveInfo.Name == b)
					{
						num = driveInfo.AvailableFreeSpace;
					}
				}
			}
			return num / 1024L / 1024L;
		}

		// Token: 0x0400010A RID: 266
		private DispatcherTimer _diskMonitorTimer;

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000140 RID: 320
		public delegate void DiskCheckEventHandler(object sender, DiskArgs args);
	}
}
