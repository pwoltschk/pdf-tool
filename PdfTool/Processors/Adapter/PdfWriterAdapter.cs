using iText.Kernel.Pdf;

namespace PdfTool.Processors.Adapter
{
    public class PdfWriterAdapter : IPdfWriter
    {
        private PdfWriter _pdfWriter;

        public IPdfDocument Write(string path, bool compressionModeOn = false)
        {
            if (compressionModeOn)
            {
                var writerProperties = new WriterProperties();
                writerProperties.SetFullCompressionMode(true);
                writerProperties.SetCompressionLevel(CompressionConstants.BEST_COMPRESSION);
                _pdfWriter = new PdfWriter(path, writerProperties);
                _pdfWriter.SetSmartMode(true);
            }
            else
            {
                _pdfWriter = new PdfWriter(path);
            }

            return new PdfDocument(_pdfWriter);
        }

        public void Dispose()
        {
            _pdfWriter?.Close();
        }
    }
}
