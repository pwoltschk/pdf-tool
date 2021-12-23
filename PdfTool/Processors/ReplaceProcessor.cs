
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class ReplaceProcessor
    {
        public void Replace(string inputPdfPath, int page1, int page2)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_replacedPage{page1}with{page2}.pdf";
        }
    }
}
