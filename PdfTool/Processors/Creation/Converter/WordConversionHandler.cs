using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal class WordConversionHandler : IConversionHandler
    {
        public Task ConvertAsync(string inputString)
        {
            var tcs = new TaskCompletionSource<int>();

            var libreOfficePath = GetApplicationPath();

            var procStartInfo = new ProcessStartInfo(libreOfficePath, $"--convert-to pdf --nologo --headless --outdir \"{Path.GetDirectoryName(inputString)}\" \"{inputString}\"")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Environment.CurrentDirectory
            };

            var process = new Process { StartInfo = procStartInfo };
            process.EnableRaisingEvents = true;

            process.Exited += (_, _) =>
            {
                if (process.ExitCode != 0)
                {
                    tcs.SetException(new Exception($"Application exited with Error Code: {process.ExitCode}"));
                }
                else
                {
                    tcs.SetResult(process.ExitCode);
                }

                process.Dispose();
            };

            process.Start();

            return tcs.Task;
        }
        private static string GetApplicationPath()
        {
            string path;
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                    path = "/usr/bin/soffice";
                    break;
                case PlatformID.Win32NT:
                    var binaryDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    path = Path.Combine(binaryDirectory, "Libre", "program", "soffice.exe");
                    break;
                default:
                    throw new PlatformNotSupportedException("Your Operating System is not supported");
            }
            return path;
        }
    }
}
