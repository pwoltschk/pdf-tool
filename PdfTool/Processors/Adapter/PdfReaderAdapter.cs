using iText.Kernel.Pdf;
using PdfDocument = PdfTool.Processors.Adapter.PdfDocument;

namespace PdfTool.Processors.Adapter
{

    public class PdfReaderAdapter : IPdfReader
    {
        private PdfReader _pdfReader;

        public IPdfDocument GetPdfDocument(string path)
        {
            _pdfReader = new PdfReader(path);
            return new PdfDocument(_pdfReader);
        }

        public void Dispose()
        {
            _pdfReader?.Close();
        }
    }
}
