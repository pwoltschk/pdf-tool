using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal class ImageConversionHandler : IConversionHandler
    {
        public async Task ConvertAsync(string inputString)
        {
            await Task.Run(() => 
            {
                PdfWriter writer = new(inputString);
                PdfDocument pdf = new(writer);
                Document document = new(pdf);

                ImageData imageData = ImageDataFactory.Create(inputString);
                Image image = new(imageData);

                document.Add(image);
                document.Close();
            });
        }
    }
}
