using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Logi
{
	// Token: 0x0200000C RID: 12
	public class VideoPlayer : Image
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000C080 File Offset: 0x0000A280
		public VideoPlayer()
		{
			VideoPlayer.create();
			base.Loaded += this.onLoaded;
			this._animationTimer = new DispatcherTimer(DispatcherPriority.Render, Application.Current.Dispatcher);
			this._animationTimer.Tick += this.animationTick;
			this._animationTimer.Interval = new TimeSpan(0, 0, 0, 0, 30);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000C100 File Offset: 0x0000A300
		~VideoPlayer()
		{
			this.cleanUp();
			VideoPlayer.destroy();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000C138 File Offset: 0x0000A338
		private void cleanUp()
		{
			if (this._decoderHandle != 0UL)
			{
				VideoPlayer.webp_close_decoder(this._decoderHandle);
			}
			this._decoderHandle = 0UL;
			if (this._unmanagedBuffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(this._unmanagedBuffer);
			}
			if (this._unmanagedVideoData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(this._unmanagedVideoData);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000C1B2 File Offset: 0x0000A3B2
		public new Uri Source
		{
			get
			{
				return (Uri)base.GetValue(VideoPlayer.SourceProperty);
			}
			set
			{
				base.SetValue(VideoPlayer.SourceProperty, value);
				this.onSourceChanged();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000C1C6 File Offset: 0x0000A3C6
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
		public float PlaybackSpeed
		{
			get
			{
				return (float)base.GetValue(VideoPlayer.PlaybackSpeedProperty);
			}
			set
			{
				base.SetValue(VideoPlayer.PlaybackSpeedProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000C1EB File Offset: 0x0000A3EB
		public int VideoWidth
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000C1F3 File Offset: 0x0000A3F3
		public int VideoHeight
		{
			get
			{
				return this._height;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000C1FB File Offset: 0x0000A3FB
		public int FrameCount
		{
			get
			{
				return this._frameCount;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000C203 File Offset: 0x0000A403
		public int LoopCount
		{
			get
			{
				return this._loopCount;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000C20C File Offset: 0x0000A40C
		public Color BackgroundColor
		{
			get
			{
				byte a = (byte)(this._bgcolor >> 24 & 255);
				byte r = (byte)(this._bgcolor >> 16 & 255);
				byte g = (byte)(this._bgcolor >> 8 & 255);
				byte b = (byte)(this._bgcolor & 255);
				return Color.FromArgb(a, r, g, b);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C260 File Offset: 0x0000A460
		private void onLoaded(object sender, RoutedEventArgs e)
		{
			RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.LowQuality);
			base.SizeChanged += this.onSizeChanged;
			this.onSourceChanged();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000C284 File Offset: 0x0000A484
		private void onSourceChanged()
		{
			object bufferlock = this._bufferlock;
			lock (bufferlock)
			{
				this._animationTimer.Stop();
				this.cleanUp();
				Uri uri = (Uri)base.GetValue(VideoPlayer.SourceProperty);
				if (uri != null)
				{
					Stream stream = Application.GetResourceStream(uri).Stream;
					if (stream == null)
					{
						Console.WriteLine("Failed to open resource uri");
					}
					else
					{
						byte[] array = new byte[stream.Length];
						stream.Read(array, 0, array.Length);
						this._unmanagedVideoData = Marshal.AllocHGlobal((int)stream.Length);
						Marshal.Copy(array, 0, this._unmanagedVideoData, array.Length);
						this._decoderHandle = VideoPlayer.webp_open_decoder(this._unmanagedVideoData, array.Length);
						if (VideoPlayer.webp_get_anim_info(this._decoderHandle, out this._width, out this._height, out this._frameCount, out this._loopCount, out this._bgcolor) == 0)
						{
							this.cleanUp();
							Console.WriteLine("Failed to parse video file");
						}
						else
						{
							this._bufferSize = this._width * this._height * 4;
							this._unmanagedBuffer = Marshal.AllocHGlobal(this._bufferSize);
							this._buffer = new byte[this._bufferSize];
							this._loopCounter = 0;
							this._animationTimer.Start();
						}
					}
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		private void onSizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (this._decoderHandle != 0UL)
			{
				this.render();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000C40C File Offset: 0x0000A60C
		private void animationTick(object sender, EventArgs e)
		{
			object bufferlock = this._bufferlock;
			lock (bufferlock)
			{
				int num;
				for (;;)
				{
					VideoPlayer.CODECSMANAGER_STATUS codecsmanager_STATUS = (VideoPlayer.CODECSMANAGER_STATUS)VideoPlayer.webp_get_frame(this._decoderHandle, this._unmanagedBuffer, this._bufferSize, out num);
					if (codecsmanager_STATUS == VideoPlayer.CODECSMANAGER_STATUS.CODECSMANAGER_E_OK)
					{
						break;
					}
					if (codecsmanager_STATUS != VideoPlayer.CODECSMANAGER_STATUS.CODECSMANAGER_E_NO_FRAMES)
					{
						goto IL_D0;
					}
					VideoPlayer.webp_reset(this._decoderHandle);
					this._loopCounter++;
					if (this._loopCounter == this._loopCount)
					{
						goto Block_7;
					}
				}
				Marshal.Copy(this._unmanagedBuffer, this._buffer, 0, this._bufferSize);
				if (this._prevTimestamp != 0)
				{
					int num2 = (int)((float)(num - this._prevTimestamp) * this.PlaybackSpeed);
					if (num2 > 0)
					{
						this._animationTimer.Interval = new TimeSpan(0, 0, 0, 0, num2);
					}
				}
				this._prevTimestamp = num;
				goto IL_DC;
				Block_7:
				this._loopCounter = 0;
				this._animationTimer.Stop();
				IL_D0:;
			}
			IL_DC:
			this.render();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000C50C File Offset: 0x0000A70C
		private void render()
		{
			object bufferlock = this._bufferlock;
			lock (bufferlock)
			{
				base.Source = BitmapSource.Create(this._width, this._height, 96.0, 96.0, PixelFormats.Bgra32, null, this._buffer, this._width * 4);
			}
		}

		// Token: 0x040000DE RID: 222
		private DispatcherTimer _animationTimer;

		// Token: 0x040000DF RID: 223
		private ulong _decoderHandle;

		// Token: 0x040000E0 RID: 224
		private object _bufferlock = new object();

		// Token: 0x040000E1 RID: 225
		private IntPtr _unmanagedVideoData;

		// Token: 0x040000E2 RID: 226
		private IntPtr _unmanagedBuffer;

		// Token: 0x040000E3 RID: 227
		private byte[] _buffer;

		// Token: 0x040000E4 RID: 228
		private int _bufferSize;

		// Token: 0x040000E5 RID: 229
		private int _loopCounter;

		// Token: 0x040000E6 RID: 230
		private int _prevTimestamp;

		// Token: 0x040000E7 RID: 231
		private int _width;

		// Token: 0x040000E8 RID: 232
		private int _height;

		// Token: 0x040000E9 RID: 233
		private int _frameCount;

		// Token: 0x040000EA RID: 234
		private int _loopCount;

		// Token: 0x040000EB RID: 235
		private int _bgcolor;

		// Token: 0x040000EC RID: 236
		public new static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(Uri), typeof(VideoPlayer));

		// Token: 0x040000ED RID: 237
		public static readonly DependencyProperty PlaybackSpeedProperty = DependencyProperty.Register("PlaybackSpeed", typeof(float), typeof(VideoPlayer), new PropertyMetadata(1f));

		// Token: 0x040000EE RID: 238
		public static VideoPlayer.createDelegate create = Core.GetDllFunction<VideoPlayer.createDelegate>("logi_codecs_shared.dll", "create");

		// Token: 0x040000EF RID: 239
		public static VideoPlayer.destroyDelegate destroy = Core.GetDllFunction<VideoPlayer.destroyDelegate>("logi_codecs_shared.dll", "destroy");

		// Token: 0x040000F0 RID: 240
		public static VideoPlayer.webp_open_decoderDelegate webp_open_decoder = Core.GetDllFunction<VideoPlayer.webp_open_decoderDelegate>("logi_codecs_shared.dll", "webp_open_decoder");

		// Token: 0x040000F1 RID: 241
		public static VideoPlayer.webp_close_decoderDelegate webp_close_decoder = Core.GetDllFunction<VideoPlayer.webp_close_decoderDelegate>("logi_codecs_shared.dll", "webp_close_decoder");

		// Token: 0x040000F2 RID: 242
		public static VideoPlayer.webp_get_frameDelegate webp_get_frame = Core.GetDllFunction<VideoPlayer.webp_get_frameDelegate>("logi_codecs_shared.dll", "webp_get_frame");

		// Token: 0x040000F3 RID: 243
		public static VideoPlayer.webp_resetDelegate webp_reset = Core.GetDllFunction<VideoPlayer.webp_resetDelegate>("logi_codecs_shared.dll", "webp_reset");

		// Token: 0x040000F4 RID: 244
		public static VideoPlayer.webp_get_infoDelegate webp_get_info = Core.GetDllFunction<VideoPlayer.webp_get_infoDelegate>("logi_codecs_shared.dll", "webp_get_info");

		// Token: 0x040000F5 RID: 245
		public static VideoPlayer.webp_get_anim_infoDelegate webp_get_anim_info = Core.GetDllFunction<VideoPlayer.webp_get_anim_infoDelegate>("logi_codecs_shared.dll", "webp_get_anim_info");

		// Token: 0x02000023 RID: 35
		private enum CODECSMANAGER_STATUS
		{
			// Token: 0x04000188 RID: 392
			CODECSMANAGER_E_FAIL,
			// Token: 0x04000189 RID: 393
			CODECSMANAGER_E_OK,
			// Token: 0x0400018A RID: 394
			CODECSMANAGER_E_NO_FRAMES
		}

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000120 RID: 288
		public delegate void createDelegate();

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000124 RID: 292
		public delegate void destroyDelegate();

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000128 RID: 296
		public delegate ulong webp_open_decoderDelegate(IntPtr data, int data_size);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600012C RID: 300
		public delegate ulong webp_close_decoderDelegate(ulong hndl);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000130 RID: 304
		public delegate int webp_get_frameDelegate(ulong hndl, IntPtr buffer, int buffer_size, out int timestamp);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000134 RID: 308
		public delegate void webp_resetDelegate(ulong hndl);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000138 RID: 312
		public delegate int webp_get_infoDelegate(byte[] data, int data_size, out int width, out int height);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600013C RID: 316
		public delegate int webp_get_anim_infoDelegate(ulong hdnl, out int width, out int height, out int frame_count, out int loop_count, out int bgcolor);
	}
}
