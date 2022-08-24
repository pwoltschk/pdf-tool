using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PdfTool.Processors
{
    public class ProcessorArgs 
    {
        public IEnumerable<string> ReferencePaths { get; }

        public int FromPage { get; }

        public int ToPage { get; }
    }
}
