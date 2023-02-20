using System;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfReader : IDisposable
    {
        IPdfDocument Read(string path);
    }
}
