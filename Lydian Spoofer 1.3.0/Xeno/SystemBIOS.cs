using System;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Xeno
{
	internal class SystemBIOS
	{
		public static void SystemBiosSpoof()
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.Start();
			process.StandardInput.WriteLine("cd C:\\Windows");
			process.StandardInput.WriteLine("AMIDEWINx64.exe /BS " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SS " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SU auto");
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SK " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SF " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /CS " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /PSN " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("exit");
			process.WaitForExit();
		}

		public static void DownloadDriver()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995784910569473/AMIDEWINx64.exe", "C:\\Windows\\AMIDEWINx64.exe");
			webClient.Proxy = null;
		}

		public static void DownloadSys2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995776588939294/amide.sys", "C:\\Windows\\amide.sys");
			webClient.Proxy = null;
		}

		public static void DownloadDriver2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995780942888960/AMIDEWIN.EXE", "C:\\Windows\\AMIDEWIN.exe");
			webClient.Proxy = null;
		}

		public static void DownloadSys()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995784818294801/amifldrv64.sys", "C:\\Windows\\amifldrv64.sys");
			webClient.Proxy = null;
		}

		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[SystemBIOS.random.Next(s.Length)]).ToArray<char>());
		}

		public static string Serials = Console.ReadLine();

		private static Random random = new Random();
	}
}
