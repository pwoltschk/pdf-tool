namespace PdfTool.Services
{
    public interface IPageRemoveService
    {
        void RemovePages(string inputPdfPath, string outputPdfPath, params int[] pages);
    }
}
