using System;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;

namespace PdfTool.Processors.Adapter
{
    public class PdfDocument : IPdfDocument
    {
        public iText.Kernel.Pdf.PdfDocument Instance { get; private set; }


        public PdfDocument(iText.Kernel.Pdf.PdfReader reader)
        {
            Instance = new iText.Kernel.Pdf.PdfDocument(reader);
        }

        public PdfDocument(iText.Kernel.Pdf.PdfWriter writer)
        {
            Instance = new iText.Kernel.Pdf.PdfDocument(writer);
        }

        public PdfDocument(iText.Kernel.Pdf.PdfReader reader, iText.Kernel.Pdf.PdfWriter writer)
        {
            Instance = new iText.Kernel.Pdf.PdfDocument(reader, writer);
        }

        public int GetNumberOfPages()
        {
            return Instance.GetNumberOfPages();
        }

        public void AddNewPage(IPdfPage page)
        {
            var pdfPage = page.Instance;
            PdfFormXObject pageCopy = pdfPage.CopyAsFormXObject(Instance);
            Rectangle rectangle = pdfPage.GetPageSize();
            PageSize pageSize = new(rectangle);
            Instance.AddNewPage(pageSize);
            new PdfCanvas(Instance.GetLastPage()).AddXObjectAt(pageCopy, 0, 0);
        }

        public void CopyPagesTo(int pageFrom, int pageTo, IPdfDocument pdfDocument)
        {
            Instance.CopyPagesTo(pageFrom, pageTo, pdfDocument.Instance);
        }

        public IPdfPage GetPage(int pageNumber)
        {
            var internalPage = Instance.GetPage(pageNumber);

            return new PdfPage(internalPage);
        }

        public IPdfPage AddPage(IPdfPage page)
        {
            var internalPage = Instance.AddPage(page.Instance);

            return new PdfPage(internalPage);
        }

        public void Close()
        {
            Instance.Close();
        }

        void IDisposable.Dispose()
        {
            Close();
        }
    }
}
