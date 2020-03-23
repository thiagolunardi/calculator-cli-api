using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.App
{
    public class CalculatorCommandLine
    {
        private readonly IServiceCollection _services;
        private readonly RootCommand _rootCommand;

        public CalculatorCommandLine(IServiceCollection services)
            => (_services, _rootCommand) = (services, CreateRootCommand());

        public async Task<int> Invoke(params string[] args)
        {
            var serviceProvider = _services.BuildServiceProvider();

            var mainArgs = args.Length == 0
                ? new[] { "--help" }
                : args;

            var cli = new CommandLineBuilder(_rootCommand)
                .UseHelp()
                .UseTypoCorrections()
                .UseMiddleware(async (ctx, next) =>
                {
                    foreach (var service in _services)
                    {
                        ctx.BindingContext.AddService(
                            service.ServiceType,
                            s => serviceProvider.GetService(service.ServiceType));
                    }

                    await next(ctx);
                })
                .Build();

            return await cli
                .InvokeAsync(mainArgs);
        }

        private static RootCommand CreateRootCommand()
        {
            var root = new RootCommand();

            root.AddCommand(AditionCommand.Create());
            root.AddCommand(SubstractionCommand.Create());
            root.AddCommand(MultiplicationCommand.Create());
            root.AddCommand(DivisionCommand.Create());

            return root;
        }
    }
}