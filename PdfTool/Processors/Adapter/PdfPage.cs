namespace PdfTool.Processors.Adapter
{
    internal class PdfPage : IPdfPage
    {
        public iText.Kernel.Pdf.PdfPage Instance { get; private set; }

        public PdfPage(iText.Kernel.Pdf.PdfPage page)
        {
            Instance = page;
        }

        public IPdfPage CopyTo(IPdfDocument document)
        {
            var internalPage = Instance.CopyTo(document.Instance);

            return new PdfPage(internalPage);
        }
    }
}
