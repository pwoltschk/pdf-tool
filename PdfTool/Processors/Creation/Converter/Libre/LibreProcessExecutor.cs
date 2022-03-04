using System.Diagnostics;
using System;
using System.IO;
using System.Reflection;

namespace PdfTool.Processors.Creation.Converter.Libre
{
    public static class LibreProcessExecutor
    {
        public static void ConvertToPdf(string docxFile, string pdfFile)
        {
            var libreOfficePath =  GetApplicationPath();

            var procStartInfo = new ProcessStartInfo(libreOfficePath, $"--convert-to pdf --nologo --headless --outdir {Path.GetDirectoryName(pdfFile)} {docxFile}")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Environment.CurrentDirectory
            };

            using var process = new Process { StartInfo = procStartInfo };
            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new Exception($"Application exited with Error Code: {process.ExitCode}");
            }

            string sourcePdfFile = Path.Combine(Path.GetDirectoryName(pdfFile), $"{Path.GetFileNameWithoutExtension(docxFile)}.pdf");
            File.Move(sourcePdfFile, pdfFile);
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
                    string binaryDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    path = Path.Combine(binaryDirectory, "Windows", "program", "soffice.exe");
                    break;
                default:
                    throw new PlatformNotSupportedException("Your Operating System is not supported");
            }
            return path;
        }
    }
}
