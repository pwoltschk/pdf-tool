namespace PdfTool.Processors.Adapter
{
    public interface IPath
    {
        string GetDirectoryName(string path);
        string GetFileNameWithoutExtension(string path);
        string Combine(string path1, string path2);
    }
}
