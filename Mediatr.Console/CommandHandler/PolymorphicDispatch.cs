﻿using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.ConsoleApp.CommandHandler
{
    class PolymorphicDispatch
    {
    }

    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {   // 1
            //await Logger.InfoAsync($"Handling {typeof(TRequest).Name}");
            var response = await next();
            //await Logger.InfoAsync($"Handled {typeof(TResponse).Name}");
            return response;
        }
    }
}
