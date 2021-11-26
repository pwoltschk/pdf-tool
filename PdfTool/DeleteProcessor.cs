using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class DeleteProcessor
    {
        public void Delete(string inputPdfPath, string outputPdfPath, int pageToDelete)
        {
            using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(inputPdfPath), new PdfWriter(outputPdfPath)))
            {
                pdfDocument.GetPage(pageToDelete).GetPdfObject().Remove();
            }
        }
    }
}

