using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Logi
{
	// Token: 0x0200000D RID: 13
	internal class Bootstrap
	{
		// Token: 0x06000080 RID: 128
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDefaultDllDirectories(Bootstrap.DIRECTORY_FLAGS flags);

		// Token: 0x06000081 RID: 129 RVA: 0x0000C686 File Offset: 0x0000A886
		[STAThread]
		private static void Main()
		{
			Bootstrap.SetDefaultDllDirectories(Bootstrap.DIRECTORY_FLAGS.LOAD_LIBRARY_SEARCH_SYSTEM32);
			Thread thread = new Thread(new ThreadStart(Bootstrap.InitThread));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		private static void InitThread()
		{
			new App().Run();
		}

		// Token: 0x0200002C RID: 44
		[Flags]
		public enum DIRECTORY_FLAGS : uint
		{
			// Token: 0x0400018C RID: 396
			LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 512U,
			// Token: 0x0400018D RID: 397
			LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 4096U,
			// Token: 0x0400018E RID: 398
			LOAD_LIBRARY_SEARCH_SYSTEM32 = 2048U,
			// Token: 0x0400018F RID: 399
			LOAD_LIBRARY_SEARCH_USER_DIRS = 1024U
		}
	}
}
