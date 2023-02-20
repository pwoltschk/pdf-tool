using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PdfTool.Processors.Adapter;

namespace PdfTool.Processors;

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
            using var pdfDocument = _pdfReader.Read(fullPath);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                string outputPdfPath = Path.Combine(outputDirectory, $"{filename}_{page}.pdf");

                using var outputDocument = _pdfWriter.Write(outputPdfPath);
                pdfDocument.CopyPagesTo(page, page, outputDocument);
            }
        });
    }
}