using Microsoft.Extensions.DependencyInjection;

namespace PdfTool.CLI
{
    public static class ServiceCollectionExtentions
    {
        public static void AddCommands(this IServiceCollection sc)
        {
            sc.AddCommand<CompressCommand>();
            sc.AddCommand<HelpCommand>();
            sc.AddCommand<VersionCommand>();
        }


        private static void AddCommand<TCommand>(this IServiceCollection sc)
            where TCommand : class, ICommand
        {
            sc.AddTransient<TCommand>();
            sc.AddTransient<ICommandFactory<TCommand>, CommandFactory<TCommand>>();
        }
    }
}
