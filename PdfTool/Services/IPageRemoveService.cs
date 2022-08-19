using System.Threading.Tasks;

namespace PdfTool.Services
{
    public interface IPageRemoveService
    {
        Task RemovePages(string inputPdfPath, string outputPdfPath, params int[] pages);
    }
}
