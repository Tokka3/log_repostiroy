using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Logi
{
	// Token: 0x0200000F RID: 15
	public class Core
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000C710 File Offset: 0x0000A910
		public static D GetDllFunction<D>(string dllName, string procName) where D : Delegate
		{
			object resource_load_lock = Core._resource_load_lock;
			lock (resource_load_lock)
			{
				if (Core.unpackResult == Core.UNPACK_RESULT.NOT_PERFORMED_YET)
				{
					Core.unpackResult = Core.UnpackAndInstallRedist();
				}
			}
			IntPtr intPtr = Core.LoadLibraryW(Path.Combine(Path.GetTempPath(), dllName).Replace("/", "\\"));
			if (intPtr == IntPtr.Zero)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new ArgumentException(string.Format("Core::Failed to load DLL {0} ({1})", dllName, lastWin32Error));
			}
			IntPtr procAddress = Core.GetProcAddress(intPtr, procName);
			if (procAddress == IntPtr.Zero)
			{
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				throw new ArgumentException(string.Format("Core::Failed to load function {0} from {1} ({2})", procName, dllName, lastWin32Error2));
			}
			return (D)((object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(D)));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		public static Core.UNPACK_RESULT UnpackAndInstallRedist()
		{
			Utils.Log("Core::Unpacking resources");
			Core.UNPACK_RESULT result;
			try
			{
				Utils.Log("Core::Unpacking runtime");
				Core.unpackResource("vc_redist.x64.exe");
				Core.unpackResource("vc_redist.x86.exe");
				Utils.Log("Core::Installing runtime");
				Core.REDIST_RESULT redist_RESULT = Core.installRuntime("vc_redist.x64.exe");
				Utils.Log(string.Format("Core::Unpacking redist x64 with code {0}", redist_RESULT));
				Core.REDIST_RESULT redist_RESULT2 = Core.installRuntime("vc_redist.x86.exe");
				Utils.Log(string.Format("Core::Unpacking redist x86 with code {0}", redist_RESULT2));
				Core.unpackResource("logi_installer_shared.dll");
				Core.unpackResource("logi_codecs_shared.dll");
				Core._dllHandleSharedInstaller = Core.LoadLibraryW(Path.Combine(Path.GetTempPath(), "logi_installer_shared.dll").Replace("/", "\\"));
				if (Core._dllHandleSharedInstaller == IntPtr.Zero)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					Utils.Log(string.Format("Core::Failed to load the shared installer dll ({0}), exiting", lastWin32Error));
					result = Core.UNPACK_RESULT.FAILED_DLL_LOADING;
				}
				else
				{
					Core._dllHandleWebp = Core.LoadLibraryW(Path.Combine(Path.GetTempPath(), "logi_codecs_shared.dll").Replace("/", "\\"));
					if (Core._dllHandleWebp == IntPtr.Zero)
					{
						int lastWin32Error2 = Marshal.GetLastWin32Error();
						Utils.Log(string.Format("Core::Failed to load the shared codecs dll ({0}), exiting", lastWin32Error2));
						result = Core.UNPACK_RESULT.FAILED_DLL_LOADING;
					}
					else if (Core.REDIST_RESULT.NEEDS_REBOOT == redist_RESULT || Core.REDIST_RESULT.NEEDS_REBOOT == redist_RESULT2)
					{
						result = Core.UNPACK_RESULT.NEEDS_REBOOT;
					}
					else
					{
						result = Core.UNPACK_RESULT.SUCCESS;
					}
				}
			}
			catch (Exception ex)
			{
				Utils.Log("Core::Error: " + ex.Message);
				result = Core.UNPACK_RESULT.FAILED_UNPACKING;
			}
			return result;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C984 File Offset: 0x0000AB84
		public static void Cleanup()
		{
			try
			{
				if (IntPtr.Zero != Core._dllHandleSharedInstaller)
				{
					Core.FreeLibrary(Core._dllHandleSharedInstaller);
					Core._dllHandleSharedInstaller = IntPtr.Zero;
				}
				if (IntPtr.Zero != Core._dllHandleWebp)
				{
					Core.FreeLibrary(Core._dllHandleWebp);
					Core._dllHandleWebp = IntPtr.Zero;
				}
			}
			catch (Exception ex)
			{
				Utils.Log("Failed to release DLLs with error " + ex.Message);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000CA08 File Offset: 0x0000AC08
		private static bool unpackResource(string resource)
		{
			bool result;
			using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
			{
				if (manifestResourceStream != null)
				{
					byte[] bytes = new BinaryReader(manifestResourceStream).ReadBytes((int)manifestResourceStream.Length);
					File.WriteAllBytes(Path.Combine(Path.GetTempPath(), resource), bytes);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		private static Core.REDIST_RESULT installRuntime(string runtime_package)
		{
			Process process = new Process();
			process.StartInfo.FileName = Path.Combine(Path.GetTempPath(), runtime_package);
			process.StartInfo.Arguments = "/install /quiet /norestart";
			process.Start();
			process.WaitForExit();
			Utils.Log(string.Format("Core::Installing redist with code {0}", process.ExitCode));
			if (process.ExitCode == 3010)
			{
				Core.AddAppToStartup();
				return Core.REDIST_RESULT.NEEDS_REBOOT;
			}
			return Core.REDIST_RESULT.SUCCESS;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		public static void AddAppToStartup()
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
			{
				string location = Assembly.GetExecutingAssembly().Location;
				registryKey.SetValue("G HUB Installer", "\"" + location + "\"");
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000CB44 File Offset: 0x0000AD44
		public static void RemoveAppFromStartup()
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
			{
				registryKey.DeleteValue("G HUB Installer", false);
			}
		}

		// Token: 0x0600008E RID: 142
		[DllImport("kernel32", SetLastError = true)]
		public static extern IntPtr LoadLibraryW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

		// Token: 0x0600008F RID: 143
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr module);

		// Token: 0x06000090 RID: 144
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000091 RID: 145
		[DllImport("user32.dll")]
		internal static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x06000092 RID: 146
		[DllImport("user32.dll")]
		internal static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

		// Token: 0x040000F6 RID: 246
		public const string NativeRuntime_x64 = "vc_redist.x64.exe";

		// Token: 0x040000F7 RID: 247
		public const string NativeRuntime_x86 = "vc_redist.x86.exe";

		// Token: 0x040000F8 RID: 248
		public const string NativeLibrary = "logi_installer_shared.dll";

		// Token: 0x040000F9 RID: 249
		public const string NativeCodecsLibrary = "logi_codecs_shared.dll";

		// Token: 0x040000FA RID: 250
		public const string GHUBRegistryEntry = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{521c89be-637f-4274-a840-baaf7460c2b2}";

		// Token: 0x040000FB RID: 251
		public const string GHUBRegistryKey = "DisplayName";

		// Token: 0x040000FC RID: 252
		public const string GHUBProgramPath = "LGHUB";

		// Token: 0x040000FD RID: 253
		public const string GHUBRegistryName = "G HUB Installer";

		// Token: 0x040000FE RID: 254
		public const string LegacyRegistryEntry = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Logitech Gaming Software";

		// Token: 0x040000FF RID: 255
		public const string LegacyRegistryKeyMajor = "VersionMajor";

		// Token: 0x04000100 RID: 256
		public const string LegacyRegistryKeyMinor = "VersionMinor";

		// Token: 0x04000101 RID: 257
		public const string Logitech = "Logitech";

		// Token: 0x04000102 RID: 258
		public const string Logicool = "Logicool";

		// Token: 0x04000103 RID: 259
		public const int ValidLegacyVersionMajor = 8;

		// Token: 0x04000104 RID: 260
		public const int ValidLegacyVersionMinor = 98;

		// Token: 0x04000105 RID: 261
		public static Core.UNPACK_RESULT unpackResult = Core.UNPACK_RESULT.NOT_PERFORMED_YET;

		// Token: 0x04000106 RID: 262
		private static readonly object _resource_load_lock = new object();

		// Token: 0x04000107 RID: 263
		private const int _redistRebootRequiredCode = 3010;

		// Token: 0x04000108 RID: 264
		private static IntPtr _dllHandleSharedInstaller;

		// Token: 0x04000109 RID: 265
		private static IntPtr _dllHandleWebp;

		// Token: 0x0200002D RID: 45
		public enum UNPACK_RESULT
		{
			// Token: 0x04000191 RID: 401
			NOT_PERFORMED_YET = -1,
			// Token: 0x04000192 RID: 402
			SUCCESS,
			// Token: 0x04000193 RID: 403
			FAILED_DLL_LOADING,
			// Token: 0x04000194 RID: 404
			FAILED_UNPACKING,
			// Token: 0x04000195 RID: 405
			NEEDS_REBOOT
		}

		// Token: 0x0200002E RID: 46
		public enum REDIST_RESULT
		{
			// Token: 0x04000197 RID: 407
			SUCCESS,
			// Token: 0x04000198 RID: 408
			NEEDS_REBOOT
		}
	}
}
