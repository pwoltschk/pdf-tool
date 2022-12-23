using System;
namespace PdfTool.CLI
{
    internal class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}
