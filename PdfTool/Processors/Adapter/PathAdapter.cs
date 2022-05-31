using System.IO;

namespace PdfTool.Processors.Adapter
{
    internal class PathAdapter : IPath
    {
        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public string Combine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }
    }

}
