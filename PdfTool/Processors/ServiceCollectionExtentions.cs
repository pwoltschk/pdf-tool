using Microsoft.Extensions.DependencyInjection;
using PdfTool.CLI.Commands;
using PdfTool.Processors.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.Processors
{
    public static class ServiceCollectionExtentions
    {
        public static void AddProcessors(this IServiceCollection sc)
        {
            sc.AddTransient<IDirectory, DirectoryAdapter>();
            sc.AddTransient<IPath, PathAdapter>();
            sc.AddTransient<IPdfReader, PdfReaderAdapter>();
            sc.AddTransient<IPdfWriter, PdfWriterAdapter>();
            sc.AddTransient<SplitProcessor>();
            sc.AddTransient<CompressProcessor>();
        }
    }
}
