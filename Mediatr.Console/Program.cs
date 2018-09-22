using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;

namespace Mediatr.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IServiceCollection services = new ServiceCollection();
            
            var provider = services
                .AddLogging()
                .BuildServiceProvider();

            //serviceProvider.AddScoped(typeof(IPipelineBehavior<,>), typeof(Timer<,>));
            //serviceProvider.AddScoped(typeof(IPipelineBehavior<,>), typeof(Logging<,>));
            //serviceProvider.AddScoped(typeof(IPipelineBehavior<,>), typeof(Validator<,>));
            services.AddMediatR(typeof(Program).GetTypeInfo().Assembly);

            provider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = provider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");


            logger.LogDebug("All done!");

            foreach (var service in services)
            {
                Console.WriteLine(service.ServiceType + " - " + service.ImplementationType);
            }

            Console.ReadKey();
        }
    }
}
