using Microsoft.Extensions.DependencyInjection;
using PdfTool.Processors.Adapter;
using PdfTool.Processors.Creation;
using PdfTool.Services;

namespace PdfTool.Processors
{
    public static class ServiceCollectionExtensions
    {
        public static void AddProcessors(this IServiceCollection sc)
        {
            sc.AddTransient<IConversionHandlerFactory, ConversionHandlerFactory>();
            sc.AddTransient<IPageRemoveService, PageRemoveService>();
            sc.AddTransient<IDirectory, DirectoryAdapter>();
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
