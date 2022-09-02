using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PdfTool.Processors
{
    public class ProcessorArgs 
    {
        public ProcessorArgs()
        {
            ReferencePaths = new List<string>();    
        }

        public IList<string> ReferencePaths { get; }

        public int FromPage { get; }

        public int ToPage { get; }
    }
}
