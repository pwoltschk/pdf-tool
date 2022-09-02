using PdfTool.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI
{
    internal class VersionCommand : ICommand
    {
        public async Task ExecuteAsync(string[] args)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("0.0");
            });
        }
    }
}
