﻿using PdfTool.Processors;
using PdfTool.Processors.Adapter;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

internal class SplitProcessor : IProcessor
{
    private readonly IDirectory _directory;
    private readonly IPdfReader _pdfReader;
    private readonly IPdfWriter _pdfWriter;

    public SplitProcessor(IDirectory directory, IPdfReader pdfReader, IPdfWriter pdfWriter)
    {
        _directory = directory;
        _pdfReader = pdfReader;
        _pdfWriter = pdfWriter;
    }

    public async Task ExecuteAsync(ProcessorArgs args)
    {
        await Split(args.ReferencePaths.Single());
    }

    public async Task Split(string fullPath)
    {
        var directory = Path.GetDirectoryName(fullPath);
        var filename = Path.GetFileNameWithoutExtension(fullPath);
        var outputDirectory = Path.Combine(directory, filename);

        _directory.CreateDirectory(outputDirectory);

        await Task.Run(() =>
        {
            using var pdfDocument = _pdfReader.GetPdfDocument(fullPath);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                string outputPdfPath = Path.Combine(outputDirectory, $"{filename}_{page}.pdf");

                using var outputDocument = _pdfWriter.GetPdfDocument(outputPdfPath);
                pdfDocument.CopyPagesTo(page, page, outputDocument);
            }
        });
    }
}
