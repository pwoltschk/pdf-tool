using PdfTool.Processors;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal interface ICommand
    {
        void Validate(ProcessorArgs args);

        Task ExecuteAsync(string[] args);
    }
}
