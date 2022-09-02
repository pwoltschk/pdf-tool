using PdfTool.Processors;
using System.Threading.Tasks;

namespace PdfTool.CLI
{
    internal interface ICommand
    { 
        Task ExecuteAsync(string[] args)
    }
}
