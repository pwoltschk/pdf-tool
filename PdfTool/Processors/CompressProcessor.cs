using iText.Kernel.Pdf;
using PdfTool.Processors.Adapter;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    public class CompressProcessor
    {
        private readonly IPdfReader _pdfReader;
        private readonly IPdfWriter _pdfWriter;

        public CompressProcessor(IPdfReader pdfReader, IPdfWriter pdfWriter)
        {
            _pdfReader = pdfReader;
            _pdfWriter = pdfWriter;
        }

        public void Compress(string inputPdfPath)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_compressed.pdf";

            using IPdfDocument pdfDocument = _pdfReader.GetPdfDocument(inputPdfPath);
            using IPdfDocument pdfDocOptimized = _pdfWriter.GetPdfDocument(outputPdfPath, true);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                IPdfPage pdfPage = pdfDocument.GetPage(page);

                pdfDocOptimized.AddPage(pdfDocument.GetPage(page).CopyTo(pdfDocOptimized));
            }
        }
    }
}
