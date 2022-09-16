using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal interface ICommand
    {
        Task ExecuteAsync(string[] args);
    }
}
