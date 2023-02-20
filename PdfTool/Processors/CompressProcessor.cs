﻿using PdfTool.Processors.Adapter;
using System.Linq;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    public class CompressProcessor : IProcessor
    {
        private readonly IPdfReader _pdfReader;
        private readonly IPdfWriter _pdfWriter;

        public CompressProcessor(IPdfReader pdfReader, IPdfWriter pdfWriter)
        {
            _pdfReader = pdfReader;
            _pdfWriter = pdfWriter;
        }

        public async Task ExecuteAsync(ProcessorArgs args)
        {
            await Compress(args.ReferencePaths.Single());
        }
        public async Task Compress(string inputPdfPath)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_compressed.pdf";
            await Task.Run(() =>
            {
                using IPdfDocument pdfDocument = _pdfReader.Read(inputPdfPath);
                using IPdfDocument pdfDocOptimized = _pdfWriter.Write(outputPdfPath, true);
                for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    IPdfPage pdfPage = pdfDocument.GetPage(page);

                    pdfDocOptimized.AddPage(pdfDocument.GetPage(page).CopyTo(pdfDocOptimized));
                }
            });
        }
    }
}
