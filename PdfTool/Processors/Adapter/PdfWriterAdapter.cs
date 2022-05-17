using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{
    public class PdfWriterAdapter : IPdfWriter
    {
        private PdfWriter _pdfWriter;

        public PdfDocument GetPdfDocument(string path)
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
