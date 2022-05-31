namespace PdfTool.Processors.Adapter
{
    public interface IPdfPage
    {
        public iText.Kernel.Pdf.PdfPage Instance { get; }
        IPdfPage CopyTo(IPdfDocument document);
    }
}
