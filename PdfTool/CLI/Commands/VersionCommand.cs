﻿using System;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
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
