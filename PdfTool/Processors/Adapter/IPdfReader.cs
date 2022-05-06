using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{
    internal interface IPdfReader : IDisposable
    {
        PdfDocument GetPdfDocument(string path);
    }
}
