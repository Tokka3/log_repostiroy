using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Navigation;
using Microsoft.Win32;

namespace Logi
{
	// Token: 0x0200001D RID: 29
	public class Utils
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000D998 File Offset: 0x0000BB98
		public static void Log(string message)
		{
			if (Utils._logToFile)
			{
				try
				{
					using (StreamWriter streamWriter = File.AppendText(Utils._logFilePath))
					{
						streamWriter.WriteLine(string.Format("{0:Hh:mm:ss}: ", DateTime.Now) + message);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000DA04 File Offset: 0x0000BC04
		public static void EnableLogs()
		{
			Utils._logFilePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\lghub_" + DateTime.Now.ToString("MM_dd_yyyy") + ".log";
			Utils._logToFile = true;
			try
			{
				using (StreamWriter streamWriter = File.AppendText(Utils._logFilePath))
				{
					streamWriter.WriteLine(">> ----------------------------------------------");
					streamWriter.WriteLine(">> New Log Entry");
					streamWriter.WriteLine(">> ----------------------------------------------");
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000DAA8 File Offset: 0x0000BCA8
		public static string GetProgramFilesPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "LGHUB");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000DABB File Offset: 0x0000BCBB
		public static string GetProgramDataPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "LGHUB");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000DACE File Offset: 0x0000BCCE
		public static string GetLocalAppDataPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LGHUB");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000DAE1 File Offset: 0x0000BCE1
		public static bool IsAlreadyInstalled()
		{
			return Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{521c89be-637f-4274-a840-baaf7460c2b2}", "DisplayName", null) != null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		public static bool IsLGSInstalled()
		{
			object value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Logitech Gaming Software", "VersionMajor", null);
			object value2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Logitech Gaming Software", "VersionMinor", null);
			return value != null && value2 != null && (int)value <= 8 && ((int)value != 8 || (int)value2 < 98);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000DB50 File Offset: 0x0000BD50
		public static void FocusExistingApp()
		{
			Utils.semaphore = new Semaphore(0, 1, Assembly.GetExecutingAssembly().GetName().Name, ref Utils.unique);
			if (!Utils.unique)
			{
				Process currentProcess = Process.GetCurrentProcess();
				foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
				{
					if (process.Id != currentProcess.Id)
					{
						Core.SetForegroundWindow(process.MainWindowHandle);
						Core.ShowWindow(process.MainWindowHandle, 9U);
						break;
					}
				}
				Environment.Exit(0);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		public static bool SettingsExist()
		{
			return Directory.Exists(Utils.GetLocalAppDataPath()) && File.Exists(Utils.GetLocalAppDataPath() + "\\settings.db");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000DC00 File Offset: 0x0000BE00
		public static bool BackupExistingSettings()
		{
			if (Utils.SettingsExist())
			{
				try
				{
					string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LGHUB_BKP");
					Directory.CreateDirectory(text);
					File.Copy(Utils.GetLocalAppDataPath() + "\\settings.db", text + "\\settings.bkp", true);
					return true;
				}
				catch (Exception ex)
				{
					Utils.Log("Utils::BackupExitingSettings -> " + ex.Message);
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000DC80 File Offset: 0x0000BE80
		public static bool RestoreBackupSettings()
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LGHUB_BKP") + "\\settings.bkp";
			if (File.Exists(text))
			{
				try
				{
					Directory.CreateDirectory(Utils.GetLocalAppDataPath());
					File.Copy(text, Utils.GetLocalAppDataPath() + "\\settings.db", true);
					return true;
				}
				catch (Exception ex)
				{
					Utils.Log("Utils::RestoreBackupSettings -> " + ex.Message);
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000DD04 File Offset: 0x0000BF04
		public static bool StartGHUB()
		{
			if (Directory.Exists(Utils.GetProgramFilesPath()))
			{
				string text = Utils.GetProgramFilesPath() + "\\lghub.exe";
				if (File.Exists(text))
				{
					try
					{
						Process.Start(text);
						return true;
					}
					catch (Exception ex)
					{
						Utils.Log("Utils::StartGHUB -> " + ex.Message);
						return false;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public static void OpenExternalHyperlink(object sender, RequestNavigateEventArgs e)
		{
			Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
			e.Handled = true;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000DD90 File Offset: 0x0000BF90
		public static string GetBrandName()
		{
			string text = "Logitech";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://util.logitech.io/brand");
			httpWebRequest.Timeout = 2000;
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					if (httpWebResponse.StatusDescription == "OK")
					{
						using (Stream responseStream = httpWebResponse.GetResponseStream())
						{
							using (StreamReader streamReader = new StreamReader(responseStream))
							{
								text = streamReader.ReadToEnd();
								text = Regex.Replace(text, "\\t|\\n|\\r", "");
								Utils.Log("Using brand: " + text);
							}
						}
					}
				}
			}
			catch (WebException)
			{
				Utils.Log("Acquisition of the brand failed, using default: " + text);
			}
			return text;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000DE84 File Offset: 0x0000C084
		public static string WithBrand(string text, string brandName)
		{
			return Regex.Replace(text.Replace("Logitech", brandName).Replace("Logitech".ToUpper(), brandName.ToUpper()).Replace("Logicool", brandName).Replace("Logicool".ToUpper(), brandName.ToUpper()), "\\t|\\n|\\r", "");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		public static bool CopyUninstallerAndRun()
		{
			bool result;
			try
			{
				string text = Utils.GetProgramFilesPath() + "\\lghub_uninstaller.exe";
				if (File.Exists(text))
				{
					string destFileName = Path.GetTempPath() + "\\lghub_uninstaller.exe".Substring(1);
					File.Copy(text, destFileName, true);
					Process.Start(new ProcessStartInfo
					{
						FileName = "cmd.exe",
						WorkingDirectory = Path.GetTempPath(),
						Arguments = "/c start " + "\\lghub_uninstaller.exe".Substring(1),
						UseShellExecute = true,
						WindowStyle = ProcessWindowStyle.Hidden
					});
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				Utils.Log("Failed to copy the uninstaller to the tmp folder" + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		public static bool IsVCRedistInstalled()
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\DevDiv\\VC\\Servicing\\14.0\\RuntimeMinimum", false);
			return registryKey != null && ((string)registryKey.GetValue("Version")).StartsWith("14");
		}

		// Token: 0x04000147 RID: 327
		public const string InstallationFolderName = "\\LGHUB";

		// Token: 0x04000148 RID: 328
		private const string _settingsFileName = "\\settings.db";

		// Token: 0x04000149 RID: 329
		private const string _settingsBackupFileName = "\\settings.bkp";

		// Token: 0x0400014A RID: 330
		private const string _settingsBackupFolderName = "LGHUB_BKP";

		// Token: 0x0400014B RID: 331
		private const string _frontendExecutableName = "\\lghub.exe";

		// Token: 0x0400014C RID: 332
		private const string _UninstallerExecutableName = "\\lghub_uninstaller.exe";

		// Token: 0x0400014D RID: 333
		private static bool _logToFile;

		// Token: 0x0400014E RID: 334
		private static string _logFilePath;

		// Token: 0x0400014F RID: 335
		private static Semaphore semaphore;

		// Token: 0x04000150 RID: 336
		private static bool unique;
	}
}
