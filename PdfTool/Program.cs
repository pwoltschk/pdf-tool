using System;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var processor = new SplitProcessor().SplitAsync("C:\\Users\\wopa\\Documents\\starvpn.pdf");



        }
    }
}
