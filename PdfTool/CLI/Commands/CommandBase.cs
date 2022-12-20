﻿using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal abstract class CommandBase : ICommand
    {
        private readonly IProcessor _processor;
        private readonly IArgumentsFactory _argumentsFactory;

        public CommandBase(
            IProcessor processor,
            IArgumentsFactory argumentsFactor)
        {
            _processor = processor;
            _argumentsFactory = argumentsFactor;
        }

        public virtual async Task ExecuteAsync(string[] args)
        {
            var processorArgs = _argumentsFactory.Create(args);

            Validate(processorArgs);

            if (args[1] is "--help" or "-h")
            {
                Console.WriteLine("help text......");

            }
            else
            {
                await _processor.ExecuteAsync(processorArgs);

            }
        }
        public abstract void Validate(ProcessorArgs args);
    }
}