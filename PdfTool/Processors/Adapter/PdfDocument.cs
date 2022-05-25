using System;

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

        public void CopyPagesTo(int pageFrom, int pageTo, IPdfDocument pdfDocument)
        {
            Instance.CopyPagesTo(pageFrom,pageTo,pdfDocument.Instance);
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
