using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal interface IConversionHandler
    {
        public static CreationFileType CreationFileType { get; }
        public void Convert(string inputString);
    }
}
