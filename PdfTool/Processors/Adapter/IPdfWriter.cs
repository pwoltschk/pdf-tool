using System;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfWriter : IDisposable
    {
        IPdfDocument GetPdfDocument(string path);
    }
}
