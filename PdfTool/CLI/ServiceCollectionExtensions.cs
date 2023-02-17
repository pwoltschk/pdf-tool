using Microsoft.Extensions.DependencyInjection;
using PdfTool.CLI.Commands;
using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommands(this IServiceCollection sc)
        {
            sc.AddValidators();

            sc.AddCommand<CompressCommand>();
            sc.AddCommand<HelpCommand>();
            sc.AddCommand<VersionCommand>();
            sc.AddCommand<SplitCommand>();
            sc.AddCommand<CreateCommand>();
            sc.AddCommand<RemoveCommand>();
            sc.AddCommand<ExtractCommand>();
            sc.AddCommand<ReplaceCommand>();
            sc.AddCommand<MergeCommand>();

            sc.AddTransient<IArgumentsFactory, ArgumentsFactory>();
            sc.AddTransient<IOptionsParser, OptionsParser>();

            sc.AddTransient<Func<Type, IProcessor>>(serviceProvider => t =>
            {

                if (t == typeof(CompressCommand))
                {
                    return serviceProvider.GetService<CompressProcessor>();
                }

                if (t == typeof(SplitCommand))
                {
                    return serviceProvider.GetService<SplitProcessor>();
                }

                if (t == typeof(CreateCommand))
                {
                    return serviceProvider.GetService<CreationProcessor>();
                }

                if (t == typeof(RemoveCommand))
                {
                    return serviceProvider.GetService<DeleteProcessor>();
                }

                if (t == typeof(ExtractCommand))
                {
                    return serviceProvider.GetService<ExtractProcessor>();
                }

                if (t == typeof(ReplaceCommand))
                {
                    return serviceProvider.GetService<ReplaceProcessor>();
                }

                if (t == typeof(MergeCommand))
                {
                    return serviceProvider.GetService<MergeProcessor>();
                }

                return null;
            });
        }

        private static void AddCommand<TCommand>(this IServiceCollection sc)
            where TCommand : class, ICommand
        {
            sc.AddTransient<TCommand>();
            sc.AddTransient<ICommandFactory<TCommand>, CommandFactory<TCommand>>();
        }
    }
}
