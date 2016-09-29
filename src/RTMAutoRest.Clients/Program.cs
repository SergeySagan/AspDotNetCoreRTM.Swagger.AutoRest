using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RTMAutoRest.Clients
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            cmd.StandardInput.WriteLine(@"%USERPROFILE%\.nuget\packages\AutoRest\0.16.0\tools\AutoRest.exe " +
                                        @"-Input http://localhost:8474/swagger/v1/swagger.json " +
                                        @"-Namespace RTMAutoRest.Clients " +
                                        @"-OutputDirectory .\Clients\");
            cmd.StandardInput.Flush();
            cmd.Dispose();
        }
    }
}
