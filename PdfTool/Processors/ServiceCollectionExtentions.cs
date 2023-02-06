using Microsoft.Extensions.DependencyInjection;
using PdfTool.Processors.Adapter;

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
            sc.AddTransient<CreationProcessor>();
            sc.AddTransient<DeleteProcessor>();
            sc.AddTransient<ExtractProcessor>();
            sc.AddTransient<ReplaceProcessor>();
            sc.AddTransient<MergeProcessor>();
        }
    }
}
