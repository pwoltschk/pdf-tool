﻿namespace PdfTool.Processors.Creation
{
    internal class CreationFileType
    {
        public string[] Value { get; private set; }

        public CreationFileType(params string[] value)
        {
            Value = value;
        }

        public static CreationFileType Txt = new CreationFileType("txt");
        public static CreationFileType Word = new CreationFileType("doc", "docx");
        public static CreationFileType Image = new CreationFileType("jpeg", "jpg", "png");
    }
}
