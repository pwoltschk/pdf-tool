using System;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfDocument : IDisposable
    {
        public iText.Kernel.Pdf.PdfDocument Instance { get; }

        void CopyPagesTo(int pageFrom, int pageTo, IPdfDocument pdfDocument);

        int GetNumberOfPages();

        IPdfPage GetPage(int pageNumber);

        public IPdfPage AddPage(IPdfPage page);

        void Close();
    }
}
