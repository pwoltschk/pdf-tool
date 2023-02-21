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
            var fileType = Path.GetExtension(inputPath).TrimStart('.');

            if (CreationFileType.Word.Value.Contains(fileType))
                return new WordConversionHandler();
            if (CreationFileType.Txt.Value.Contains(fileType))
                return new TxtConversionHandler();
            if (CreationFileType.Image.Value.Contains(fileType))
                return new ImageConversionHandler();
            throw new NotSupportedException();
        }
    }
}
