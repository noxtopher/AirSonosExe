using System;
using System.Diagnostics;

namespace AirSonos
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("StartingAirSonos");

			{
				Process[] processes = Process.GetProcessesByName("cmd");
				foreach (var process in processes) {
				//process.Kill();

				}

				
				string hostname = "google.com".PadLeft(11);
				ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "ping" + hostname);
				Process proc = new Process();
				procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				procStartInfo.UseShellExecute = false;
				procStartInfo.RedirectStandardOutput = true;
				//procStartInfo.CreateNoWindow = true;
				proc.StartInfo = procStartInfo;
				proc.Start();
				string output2 = proc.StandardOutput.ReadToEnd();
				proc.WaitForExit(300);
				Console.WriteLine (output2);

				//var process2 = Process.Start ("cmd.exe", @"/c ping 8.8.8.8");
				//process2.WaitForExit();
				System.Threading.Thread.Sleep (5000);

			}

			{
				
			}
		}
	}
}
	

