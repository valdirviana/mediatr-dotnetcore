using Mediatr.ConsoleApp.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.ConsoleApp.CommandHandler
{
    public class PingN2 : INotificationHandler<PingN>
    {
        public Task Handle(PingN notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Pong 2");
            return Task.CompletedTask;
        }
    }
}