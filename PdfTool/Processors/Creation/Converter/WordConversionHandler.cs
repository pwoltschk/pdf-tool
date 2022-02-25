using Microsoft.Office.Interop.Word;
using System.IO;

using Word = Microsoft.Office.Interop.Word;

namespace PdfTool.Processors.Creation.Converter
{
    internal class WordConversionHandler : IConversionHandler
    {
        public void Convert(string inputString)
        {
            string pdfPath = Path.ChangeExtension(inputString, ".pdf");

            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;
            Document wordDoc = null;

            try
            {
                wordDoc = wordApp.Documents.Open(pdfPath);
                wordDoc.SaveAs2(pdfPath, WdSaveFormat.wdFormatPDF);
            }
            finally
            {
                if (wordApp != null)
                {
                    wordApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
            }
        }
    }
}
