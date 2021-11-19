namespace PdfTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MergeProcessor().Merge("C:\\Users\\pawel\\Documents\\cv1.pdf", "C:\\Users\\pawel\\Documents\\cv2.pdf", "C:\\Users\\pawel\\Documents\\cv2.pdf");
        }
    }
}