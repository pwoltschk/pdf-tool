using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal class ImageConversionHandler : IConversionHandler
    {
        public void Convert(string inputString)
        {
            PdfWriter writer = new PdfWriter(inputString);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            ImageData imageData = ImageDataFactory.Create(inputString);
            Image image = new Image(imageData);

            document.Add(image);
            document.Close();
        }
    }
}
