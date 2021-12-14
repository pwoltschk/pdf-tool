namespace PdfTool.Services
{
    internal interface IPageRemoveService
    {
        void RemovePages(string inputPdfPath, string outputPdfPath, params int[] pages);
    }
}
