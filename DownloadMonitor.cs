using System;
using System.Windows.Threading;

namespace Logi
{
	// Token: 0x02000013 RID: 19
	public class DownloadMonitor
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600009E RID: 158 RVA: 0x0000CD08 File Offset: 0x0000AF08
		// (remove) Token: 0x0600009F RID: 159 RVA: 0x0000CD40 File Offset: 0x0000AF40
		public event DownloadMonitor.MonitorEventHandler SlowDownloadEvent;

		// Token: 0x060000A0 RID: 160 RVA: 0x0000CD78 File Offset: 0x0000AF78
		public DownloadMonitor()
		{
			this._lastDownloadSum = 0.0;
			this.fillMessagesArray();
			this._downloadMonitorTimer = new DispatcherTimer();
			this._downloadMonitorTimer.Tick += this.onDownloadMonitorTick;
			this._downloadMonitorTimer.Interval = new TimeSpan(0, 0, 15);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000CDD6 File Offset: 0x0000AFD6
		public void Reset()
		{
			this._lastDownloadSum = 0.0;
			this._downloadTime = 0;
			this._lastDownloadUpdateTime = DateTime.Now;
			this._downloadMonitorTimer.Start();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000CE04 File Offset: 0x0000B004
		public void Stop()
		{
			this._downloadMonitorTimer.Stop();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000CE14 File Offset: 0x0000B014
		private void onDownloadMonitorTick(object sender, EventArgs e)
		{
			this._downloadTime += 15;
			if (this._downloadTime == 75)
			{
				MonitorArgs monitorArgs = new MonitorArgs();
				monitorArgs.UserMessage = this._userMessages[0];
				this.SlowDownloadEvent(this, monitorArgs);
			}
			if (this._downloadTime > 75)
			{
				MonitorArgs monitorArgs2 = new MonitorArgs();
				monitorArgs2.UserMessage = this._userMessages[new Random().Next(1, this._userMessages.Length)];
				this.SlowDownloadEvent(this, monitorArgs2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000CE98 File Offset: 0x0000B098
		public double GetRate(float downloaded)
		{
			double result = 0.0;
			this._currentTime = DateTime.Now;
			double totalSeconds = (this._currentTime - this._lastDownloadUpdateTime).TotalSeconds;
			if (totalSeconds > 0.0)
			{
				result = ((double)downloaded - this._lastDownloadSum) / totalSeconds * 1024.0;
			}
			this._lastDownloadSum = (double)downloaded;
			this._lastDownloadUpdateTime = this._currentTime;
			return result;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000CF0C File Offset: 0x0000B10C
		private void fillMessagesArray()
		{
			this._userMessages = new string[22];
			this._userMessages[0] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_0);
			this._userMessages[1] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_1);
			this._userMessages[2] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_2);
			this._userMessages[3] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_3);
			this._userMessages[4] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_4);
			this._userMessages[5] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_5);
			this._userMessages[6] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_6);
			this._userMessages[7] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_7);
			this._userMessages[8] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_8);
			this._userMessages[9] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_9);
			this._userMessages[10] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_10);
			this._userMessages[11] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_11);
			this._userMessages[12] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_12);
			this._userMessages[13] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_13);
			this._userMessages[14] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_14);
			this._userMessages[15] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_15);
			this._userMessages[16] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_16);
			this._userMessages[17] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_17);
			this._userMessages[18] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_18);
			this._userMessages[19] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_19);
			this._userMessages[20] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_20);
			this._userMessages[21] = Strings.Get(STRING.INSTALLER_LOADING_MESSAGE_21);
		}

		// Token: 0x0400010D RID: 269
		private const int _slowDownloadSpeed = 75;

		// Token: 0x0400010E RID: 270
		private DateTime _currentTime;

		// Token: 0x0400010F RID: 271
		private DateTime _lastDownloadUpdateTime;

		// Token: 0x04000110 RID: 272
		private double _lastDownloadSum;

		// Token: 0x04000111 RID: 273
		private DispatcherTimer _downloadMonitorTimer;

		// Token: 0x04000112 RID: 274
		private int _downloadTime;

		// Token: 0x04000113 RID: 275
		private string[] _userMessages;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000144 RID: 324
		public delegate void MonitorEventHandler(object sender, MonitorArgs args);
	}
}
