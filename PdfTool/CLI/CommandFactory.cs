using PdfTool.CLI.Commands;

namespace PdfTool.CLI
{
    internal class CommandFactory<TCommand> : ICommandFactory<TCommand>
        where TCommand : class, ICommand
    {
        readonly ICommand _command;
        public CommandFactory(TCommand command)
        {

            _command = command;
        }
        public ICommand Create()
        {
            return _command;
        }
    }
}
