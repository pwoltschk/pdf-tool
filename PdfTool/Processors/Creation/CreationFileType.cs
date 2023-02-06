namespace PdfTool.Processors.Creation
{
    internal class CreationFileType
    {
        public string[] Value { get; private set; }

        public CreationFileType(params string[] value)
        {
            Value = value;
        }

        public static CreationFileType Txt = new("txt");
        public static CreationFileType Word = new("doc", "docx");
        public static CreationFileType Image = new("jpeg", "jpg", "png");
    }
}
