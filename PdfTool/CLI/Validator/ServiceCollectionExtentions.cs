using Microsoft.Extensions.DependencyInjection;
using PdfTool.CLI.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI.Validator
{
    public static class ServiceCollectionExtentions
    {
        public static void AddValidators(this IServiceCollection sc)
        {
            sc.AddTransient<IExactlyOneDocumentValidator, ExactlyOneDocumentValidator>();
            sc.AddTransient<INoPageParametersAllowedValidator, NoPageParametersAllowedValidator>();
        }
    }
}