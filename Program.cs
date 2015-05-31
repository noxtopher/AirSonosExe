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
					process.Kill();
					Console.WriteLine ("Testing Chanhhhges");
					Console.WriteLine ("Testing Chjjkkanhhges");
					Console.WriteLine ("Testing Chanjjgdfdes");
					Console.WriteLine ("Testing Cha23232323nges");
					Console.WriteLine ("Testing 333");
					Console.WriteLine ("Testing 32323232323232323");
				}
				
				var process2 = Process.Start ("cmd.exe", @"/c C:\Users\Screen\AppData\Roaming\npm\airsonos.cmd");
				process2.WaitForExit();
				System.Threading.Thread.Sleep (5000);

			}

			{
				
			}
		}
	}
}



