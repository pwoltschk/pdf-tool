using PdfTool.Processors.Adapter;
using System.Threading.Tasks;

internal class SplitProcessor
{
    private readonly IPath _path;
    private readonly IDirectory _directory;
    private readonly IPdfReader _pdfReader;
    private readonly IPdfWriter _pdfWriter;

    public SplitProcessor(IPath path, IDirectory directory, IPdfReader pdfReader, IPdfWriter pdfWriter)
    {
        _path = path;
        _directory = directory;
        _pdfReader = pdfReader;
        _pdfWriter = pdfWriter;
    }

    public async Task Split(string fullPath)
    {
        var directory = _path.GetDirectoryName(fullPath);
        var filename = _path.GetFileNameWithoutExtension(fullPath);
        var outputDirectory = _path.Combine(directory, filename);

        _directory.CreateDirectory(outputDirectory);

        await Task.Run(() =>
        {
            using var pdfDocument = _pdfReader.GetPdfDocument(fullPath);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                string outputPdfPath = _path.Combine(outputDirectory, $"{filename}_{page}.pdf");

                using var outputDocument = _pdfWriter.GetPdfDocument(outputPdfPath);
                pdfDocument.CopyPagesTo(page, page, outputDocument);
            }
        });
    }
}
