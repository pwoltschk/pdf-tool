using System;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfReader : IDisposable
    {
        IPdfDocument GetPdfDocument(string path);
    }
}
