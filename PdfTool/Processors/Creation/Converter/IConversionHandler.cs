namespace PdfTool.Processors.Creation.Converter
{
    internal interface IConversionHandler
    {
        public static CreationFileType CreationFileType { get; }
        public void Convert(string inputString);
    }
}
