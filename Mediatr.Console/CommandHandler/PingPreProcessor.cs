using Mediatr.ConsoleApp.Command;
using MediatR.Pipeline;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.ConsoleApp.CommandHandler
{
    public class PingPreProcessor<TRequest> : IRequestPreProcessor<TRequest> where TRequest : Ping
    {
        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            // 2
            //request.Message = request.Message + "Pong 2";
            
            return Task.FromResult("Pong 2");
        }
    }
}
