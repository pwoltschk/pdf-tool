using PdfTool.Processors.Adapter;
using System.IO;
using System.Linq;

namespace PdfTool.Processors
{
    internal class MergeProcessor
    {
        private readonly IPdfReader _pdfReader;
        private readonly IPdfWriter _pdfWriter;

        public MergeProcessor(IPdfReader pdfReader, IPdfWriter pdfWriter)
        {
            _pdfReader = pdfReader;
            _pdfWriter = pdfWriter;
        }

        public void Merge(params string[] pdf)
        {
            var outputPdfPath = Path.GetFullPath(pdf.First());

            using IPdfDocument mergedPdfDocument = _pdfWriter.GetPdfDocument($"{outputPdfPath}_merged.pdf");
            foreach (string pdfFile in pdf)
            {
                using IPdfDocument pdfDocument = _pdfReader.GetPdfDocument(pdfFile);
                int pageCount = pdfDocument.GetNumberOfPages();
                for (int page = 1; page <= pageCount; page++)
                {
                    IPdfPage pdfPage = pdfDocument.GetPage(page);
                    mergedPdfDocument.AddPage(pdfPage.CopyTo(mergedPdfDocument));
                }
            }
        }
    }
}
