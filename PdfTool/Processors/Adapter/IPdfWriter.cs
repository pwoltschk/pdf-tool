﻿using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors.Adapter
{
    public interface IPdfWriter : IDisposable
    {
        IPdfDocument GetPdfDocument(string path);
    }
}
