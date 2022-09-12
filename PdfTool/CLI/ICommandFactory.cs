namespace PdfTool.CLI
{
    internal interface ICommandFactory<TCommand>
        where TCommand : class, ICommand
    {
        public ICommand Create();
    }
}
