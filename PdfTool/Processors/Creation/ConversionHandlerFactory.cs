using PdfTool.Processors.Creation.Converter;
using System;
using System.IO;
using System.Linq;

namespace PdfTool.Processors.Creation
{
    internal class ConversionHandlerFactory : IConversionHandlerFactory
    {
        public IConversionHandler Create(string inputPath)
        {
            string fileType = Path.GetExtension(inputPath).TrimStart('.');

            if (CreationFileType.Word.Value.Contains(fileType))
                return new WordConversionHandler();
            if (CreationFileType.Txt.Value.Contains(fileType))
                return new TxtConversionHandler();
            else
                throw new NotSupportedException();
        }
    }
}
