using PdfTool.Processors.Adapter;
using System;
using System.Linq;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    public class ReplaceProcessor : IProcessor
    {
        private readonly IPdfReader _reader;
        private readonly IPdfWriter _writer;

        public ReplaceProcessor(IPdfReader reader, IPdfWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public async Task ExecuteAsync(ProcessorArgs args)
        {
            await Replace(args.ReferencePaths.Single(), args.FromPage, args.ToPage);
        }


        public async Task Replace(string inputPdfPath, int page1, int page2)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_replacedPage{page1}with{page2}.pdf";

            await Task.Run(() =>
            {
                using IPdfDocument inputDocument = _reader.Read(inputPdfPath);
                using IPdfDocument outputDocument = _writer.Write(outputPdfPath);
                int pageCount = inputDocument.GetNumberOfPages();

                if (page1 < 1 || page2 < 1 || page1 > pageCount || page2 > pageCount)
                {
                    throw new ArgumentException("Invalid page numbers. Both page1 and page2 should be valid page numbers.");
                }

                for (int page = 1; page <= pageCount; page++)
                {
                    if (page == page1)
                    {
                        IPdfPage pageToSwap = inputDocument.GetPage(page2).CopyTo(outputDocument);
                        outputDocument.AddPage(pageToSwap);
                    }
                    else if (page == page2)
                    {
                        IPdfPage pageToSwap = inputDocument.GetPage(page1).CopyTo(outputDocument);
                        outputDocument.AddPage(pageToSwap);
                    }
                    else
                    {
                        IPdfPage currentPage = inputDocument.GetPage(page).CopyTo(outputDocument);
                        outputDocument.AddPage(currentPage);
                    }
                }
            });
        }
    }
}
