
using PdfTool.Processors.Creation;
using System.Linq;
using System.Threading.Tasks;

namespace PdfTool.Processors
{
    internal class CreationProcessor : IProcessor
    {
        private readonly IConversionHandlerFactory _conversionHandlerFactory;

        public CreationProcessor(IConversionHandlerFactory conversionHandlerFactory)
        {
            _conversionHandlerFactory = conversionHandlerFactory;
        }
        public async Task ExecuteAsync(ProcessorArgs args)
        {
            await Task.Run(() =>  Create(args.ReferencePaths.Single()));
        }


        public void Create(string inputPath)
        {
            var converter = _conversionHandlerFactory.Create(inputPath);

            converter.Convert(inputPath);
        }
    }
}
