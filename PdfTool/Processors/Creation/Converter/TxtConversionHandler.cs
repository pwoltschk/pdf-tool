using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;

namespace PdfTool.Processors.Creation.Converter
{
    internal class TxtConversionHandler : IConversionHandler
    {
        public void Convert(string inputString)
        {
            string txtContent = File.ReadAllText(inputString);
            PdfWriter writer = new PdfWriter(inputString);
            PdfDocument pdf = new PdfDocument(writer);

            Document document = new Document(pdf);

            document.Add(new Paragraph(txtContent));

            document.Close();
        }
    }
}
