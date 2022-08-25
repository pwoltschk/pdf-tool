using PdfTool.CLI;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            switch (args[0])
            {
                case "help":
                case "--help":
                case "-h":
                    await new HelpCommand().ExecuteAsync(null);
                break;
                default:
                return;
            }
        }
    }
}