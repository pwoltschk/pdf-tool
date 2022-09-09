using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI
{
    internal interface ICommandFactory<TCommand>
        where TCommand : class, ICommand
    {
        public ICommand Create();
    }
}
