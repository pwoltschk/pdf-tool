using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal class TxtConversionHandler : IConversionHandler
    {
        public async Task ConvertAsync(string inputString)
        {
            await Task.Run(() =>
            {
                string txtContent = File.ReadAllText(inputString);
                PdfWriter writer = new(inputString);
                PdfDocument pdf = new(writer);

                Document document = new(pdf);

                document.Add(new Paragraph(txtContent));

                document.Close();
            });
        }
    }
}
