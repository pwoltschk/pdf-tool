using iText.Kernel.Pdf;

namespace PdfTool.Processors.Adapter
{
    public class PdfWriterAdapter : IPdfWriter
    {
        private PdfWriter _pdfWriter;

        public IPdfDocument GetPdfDocument(string path)
        {
            _pdfWriter = new PdfWriter(path);
            return new PdfDocument(_pdfWriter);
        }

        public void Dispose()
        {
            _pdfWriter?.Close();
        }
    }
}
