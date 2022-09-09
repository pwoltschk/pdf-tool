using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI
{
    internal class CommandFactory<TCommand> : ICommandFactory<TCommand>
        where TCommand : class, ICommand
    {
        ICommand _command;
        public CommandFactory(TCommand command) {
            
            _command = command;
        }
        public ICommand Create()
        {
            return _command;
        }
    }
}
