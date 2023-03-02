using Microsoft.Extensions.DependencyInjection;
using PdfTool.CLI.Commands;
using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;
using System.Collections.Generic;

namespace PdfTool.CLI
{
    public static class ServiceCollectionExtensions
    {
        private static Dictionary<Type, Type> TypeBoundRegistrations = new Dictionary<Type, Type>();
        public static void AddCommands(this IServiceCollection sc)
        {
            sc.AddValidators();

            sc.AddCommandBoundToType<CompressCommand, CompressProcessor>();
            sc.AddCommandBoundToType<HelpCommand, IProcessor>();
            sc.AddCommandBoundToType<VersionCommand, IProcessor>();
            sc.AddCommandBoundToType<SplitCommand, SplitProcessor>();
            sc.AddCommandBoundToType<CreateCommand, CreationProcessor>();
            sc.AddCommandBoundToType<RemoveCommand, DeleteProcessor>();
            sc.AddCommandBoundToType<ExtractCommand, ExtractProcessor>();
            sc.AddCommandBoundToType<ReplaceCommand, ReplaceProcessor>();
            sc.AddCommandBoundToType<MergeCommand, MergeProcessor>();

            sc.AddTransient<IArgumentsFactory, ArgumentsFactory>();
            sc.AddTransient<IOptionsParser, OptionsParser>();

            sc.AddTransient<Func<Type, IProcessor>>(serviceProvider => t =>
            {
                if (TypeBoundRegistrations.TryGetValue(t, out var processorType))
                {
                    return (IProcessor)serviceProvider.GetService(processorType);
                }

                return null;
            });
        }

        private static void AddCommandBoundToType<TCommand,TProcessor>(this IServiceCollection sc)
            where TCommand : class, ICommand
        {
            TypeBoundRegistrations.Add(typeof(TCommand),typeof(TProcessor));
            sc.AddTransient<TCommand>();
            sc.AddTransient<ICommandFactory<TCommand>, CommandFactory<TCommand>>();
        }
    }
}
