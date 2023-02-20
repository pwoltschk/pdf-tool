using System;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfWriter : IDisposable
    {
        IPdfDocument Write(string path, bool compressionModeOn = false);
    }
}
