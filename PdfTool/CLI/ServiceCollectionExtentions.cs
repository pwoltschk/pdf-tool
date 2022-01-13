using Microsoft.Extensions.DependencyInjection;
using PdfTool.CLI.Commands;
using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI
{
    public static class ServiceCollectionExtentions
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

            sc.AddTransient<IArgumentsFactory, ArgumentsFactory>();
            sc.AddTransient<IOptionsParser, OptionsParser>();

            sc.AddTransient<Func<Type, IProcessor>>(serviceProvider => t =>
            {

                if (t == typeof(CompressCommand))
                {
                    return serviceProvider.GetService<CompressProcessor>();
                }
                else if (t == typeof(SplitCommand))
                {
                    return serviceProvider.GetService<SplitProcessor>();
                }
                else if (t == typeof(CreateCommand))
                {
                    return serviceProvider.GetService<CreationProcessor>();
                }
                else if (t == typeof(RemoveCommand))
                {
                    return serviceProvider.GetService<DeleteProcessor>();
                }
                else
                {
                    return null;
                }      
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
