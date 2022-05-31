using System.IO;

namespace PdfTool.Processors.Adapter
{
    internal class DirectoryAdapter : IDirectory
    {
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
