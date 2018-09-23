using Mediatr.ConsoleApp.Command;
using Mediatr.ConsoleApp.CommandHandler;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Reflection;

namespace Mediatr.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IServiceCollection services = new ServiceCollection();

            services.AddMediatR(typeof(Program).GetTypeInfo().Assembly);


            // Registers generic behaviors
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));


            // Pre-processors
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));


            // Post-processors
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>));

            // Registers command validator






            var provider = services
                .AddLogging()
                .BuildServiceProvider();

            provider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = provider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            logger.LogDebug("All done!");


            var mediator = provider.GetService<IMediator>();
            var response = mediator.Send(new Ping()).Result;
            Console.WriteLine(response); // "Pong"

            //mediator.Publish(new PingN());

            Console.ReadKey();
        }
    }
}
