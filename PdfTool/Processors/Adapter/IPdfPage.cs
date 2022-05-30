using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfPage
    {
        public iText.Kernel.Pdf.PdfPage Instance { get; }
        IPdfPage CopyTo(IPdfDocument document);
    }
}
