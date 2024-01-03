using System;
using System.Runtime.InteropServices;

namespace Logi
{
	// Token: 0x02000014 RID: 20
	public class Engine
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000D080 File Offset: 0x0000B280
		public static void Initialize()
		{
			Engine.Create = Core.GetDllFunction<Engine.CreateDelegate>("logi_installer_shared.dll", "create");
			Engine.Destroy = Core.GetDllFunction<Engine.DestroyDelegate>("logi_installer_shared.dll", "destroy");
			Engine.SetNativeCallback = Core.GetDllFunction<Engine.SetNativeCallbackDelegate>("logi_installer_shared.dll", "set_native_callback");
			Engine.IsCompatibleOSVersion = Core.GetDllFunction<Engine.CheckForOSVersionDelegate>("logi_installer_shared.dll", "check_os_version");
			Engine.CheckForUpdates = Core.GetDllFunction<Engine.CheckForUpdatesDelegate>("logi_installer_shared.dll", "check_for_updates");
			Engine.DownloadUpdates = Core.GetDllFunction<Engine.DownloadUpdatesDelegate>("logi_installer_shared.dll", "download_updates");
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000D105 File Offset: 0x0000B305
		public static void Reset()
		{
			Utils.Log("Engine::resetting");
			Engine.Destroy();
			Engine.Create();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000D128 File Offset: 0x0000B328
		public static string GetErrorMessage(int error_code)
		{
			switch (error_code)
			{
			case 2:
			case 8:
			case 9:
				return Strings.Get(STRING.INSTALLER_ERROR_INITIALIZE);
			case 3:
			case 6:
				return Strings.Get(STRING.INSTALLER_ERROR_TIMEOUT);
			case 4:
			case 7:
				break;
			case 5:
				return Strings.Get(STRING.INSTALLER_ERROR_WRITE);
			default:
				if (error_code - 600 <= 2)
				{
					return Strings.Get(STRING.INSTALLER_ERROR_SUMMARY);
				}
				break;
			}
			return Strings.Get(STRING.INSTALLER_ERROR_GENERIC);
		}

		// Token: 0x04000115 RID: 277
		public static Engine.CreateDelegate Create;

		// Token: 0x04000116 RID: 278
		public static Engine.DestroyDelegate Destroy;

		// Token: 0x04000117 RID: 279
		public static Engine.SetNativeCallbackDelegate SetNativeCallback;

		// Token: 0x04000118 RID: 280
		public static Engine.CheckForOSVersionDelegate IsCompatibleOSVersion;

		// Token: 0x04000119 RID: 281
		public static Engine.CheckForUpdatesDelegate CheckForUpdates;

		// Token: 0x0400011A RID: 282
		public static Engine.DownloadUpdatesDelegate DownloadUpdates;

		// Token: 0x02000031 RID: 49
		public enum STATE
		{
			// Token: 0x0400019A RID: 410
			INVALID,
			// Token: 0x0400019B RID: 411
			INITIALIZING,
			// Token: 0x0400019C RID: 412
			NO_UPDATES,
			// Token: 0x0400019D RID: 413
			CHECKING_FOR_UPDATES,
			// Token: 0x0400019E RID: 414
			UPDATE_AVAILABLE,
			// Token: 0x0400019F RID: 415
			FEATURE_KEYS_AVAILABLE,
			// Token: 0x040001A0 RID: 416
			UPDATE_DOWNLOADING,
			// Token: 0x040001A1 RID: 417
			UPDATE_UNPACKING,
			// Token: 0x040001A2 RID: 418
			UPDATE_READY,
			// Token: 0x040001A3 RID: 419
			UPDATE_INSTALLING,
			// Token: 0x040001A4 RID: 420
			RESTARTING,
			// Token: 0x040001A5 RID: 421
			DEPOTS_DOWNLOADING,
			// Token: 0x040001A6 RID: 422
			UPDATER_ERROR,
			// Token: 0x040001A7 RID: 423
			UNSUPPORTED_OS_VERSION
		}

		// Token: 0x02000032 RID: 50
		public enum PROGRESS_TYPE
		{
			// Token: 0x040001A9 RID: 425
			DOWNLOAD,
			// Token: 0x040001AA RID: 426
			UNCOMPRESS
		}

		// Token: 0x02000033 RID: 51
		public enum RESULT_CODE
		{
			// Token: 0x040001AC RID: 428
			SUCCESS = 200,
			// Token: 0x040001AD RID: 429
			INVALID = 0,
			// Token: 0x040001AE RID: 430
			FAILED,
			// Token: 0x040001AF RID: 431
			FAILED_INIT,
			// Token: 0x040001B0 RID: 432
			FAILED_CONNECT,
			// Token: 0x040001B1 RID: 433
			PARTIAL_FILE,
			// Token: 0x040001B2 RID: 434
			WRITE_ERROR,
			// Token: 0x040001B3 RID: 435
			TIMEOUT,
			// Token: 0x040001B4 RID: 436
			MAX_RETRIES,
			// Token: 0x040001B5 RID: 437
			NOT_FOUND,
			// Token: 0x040001B6 RID: 438
			NOT_AUTHORIZED,
			// Token: 0x040001B7 RID: 439
			UNSUPPORTED_OS_ERROR = 12,
			// Token: 0x040001B8 RID: 440
			EMPTY_UPDATE_SUMMARY = 600,
			// Token: 0x040001B9 RID: 441
			FAILED_PARSE_UPDATE_SUMMARY,
			// Token: 0x040001BA RID: 442
			INVALID_UPDATE_SUMMARY
		}

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000148 RID: 328
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void InstallCallback(int state, int error_code, int progress_type, float progress, float rate, float current_download, float expected_download, uint retry_countdown);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600014C RID: 332
		public delegate void CreateDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000150 RID: 336
		public delegate void DestroyDelegate();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000154 RID: 340
		public delegate void SetNativeCallbackDelegate([MarshalAs(UnmanagedType.FunctionPtr)] Engine.InstallCallback callback);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000158 RID: 344
		public delegate bool CheckForOSVersionDelegate();

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600015C RID: 348
		public delegate bool CheckForUpdatesDelegate();

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000160 RID: 352
		public delegate void DownloadUpdatesDelegate();
	}
}
