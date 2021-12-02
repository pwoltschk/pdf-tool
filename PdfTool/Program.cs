namespace PdfTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new DeleteProcessor().Delete("C:\\Users\\pawel\\Documents\\cv1.pdf", "C:\\Users\\pawel\\Documents\\cv_without_page1.pdf", 1);
        }
    }
}