using Mediatr.ConsoleApp.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.ConsoleApp.CommandHandler
{
    public class OneWayHandlerWithBaseClass : AsyncRequestHandler<OneWay>
    {
        protected override Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
            // Twiddle thumbs
        }
    }
}
