using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{
    internal interface IPath
    {
        string GetDirectoryName(string path);
        string GetFileNameWithoutExtension(string path);
        string Combine(string path1, string path2);
    }
}
