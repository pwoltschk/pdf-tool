using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI
{
    internal interface ICommandFactory<ICommand>
    {
        public ICommand Create();
    }
}
