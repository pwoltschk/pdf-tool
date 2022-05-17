using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{

    public class PdfReaderAdapter : IPdfReader
    {
        private PdfReader _pdfReader;

        public PdfDocument GetPdfDocument(string path)
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
