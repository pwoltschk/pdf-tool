using iText.Kernel.Pdf;

namespace PdfTool.Processors.Adapter
{

    public class PdfReaderAdapter : IPdfReader
    {
        private PdfReader _pdfReader;

        public IPdfDocument Read(string path)
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
