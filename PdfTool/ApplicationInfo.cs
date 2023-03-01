using System.Collections.Generic;

namespace PdfTool
{
    public class ApplicationInfo
    {
        public static string Section = nameof(ApplicationInfo);
        public string MainText { get; set; }
        public Dictionary<string, string> CommandDetails { get; set; }
    }
}
