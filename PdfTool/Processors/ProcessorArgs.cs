using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PdfTool.Processors
{
    public class ProcessorArgs
    {
        public IEnumerable<string> referencePaths { get; }

        public IEnumerable<string> referencePages { get; }
    }
}
