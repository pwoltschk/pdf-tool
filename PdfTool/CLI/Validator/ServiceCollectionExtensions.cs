using Microsoft.Extensions.DependencyInjection;

namespace PdfTool.CLI.Validator
{
    public static class ServiceCollectionExtensions
    {
        public static void AddValidators(this IServiceCollection sc)
        {
            sc.AddTransient<IExactlyOneDocumentValidator, ExactlyOneDocumentValidator>();
            sc.AddTransient<INoPageParametersAllowedValidator, NoPageParametersAllowedValidator>();
            sc.AddTransient<IReferencePageValidator, ReferencePageValidator>();
        }
    }
}