namespace PdfTool.Processors.Creation
{
    internal class CreationFileType
    {
        public string[] Value { get; private set; }

        public CreationFileType(params string[] value)
        {
            Value = value;
        }

        public static CreationFileType Txt = new CreationFileType("txt");
        public static CreationFileType Word = new CreationFileType("doc","docx");
        public static CreationFileType Excel = new CreationFileType("xls","xlsx");
        public static CreationFileType PowerPoint = new CreationFileType("ppt","pptx");
        public static CreationFileType Jpeg = new CreationFileType("jpeg");
        public static CreationFileType Png = new CreationFileType("png");
        public static CreationFileType Tiff = new CreationFileType("tiff");
        public static CreationFileType Rtf = new CreationFileType("rtf");
    }
}
