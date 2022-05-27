using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{
    internal class PdfPage : IPdfPage
    {
        private readonly iText.Kernel.Pdf.PdfPage _page;

        public PdfPage(iText.Kernel.Pdf.PdfPage page)
        {
            _page = page;
        }

        public IPdfPage CopyTo(IPdfDocument document)
        {
            var internalPage = _page.CopyTo(document.Instance);

            return new PdfPage(internalPage);
        }
    }
}
