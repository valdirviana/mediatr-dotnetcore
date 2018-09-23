using Mediatr.ConsoleApp.Command;
using MediatR.Pipeline;
using System.Threading.Tasks;

namespace Mediatr.ConsoleApp.CommandHandler
{
    public class PingPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, string> where TRequest : Ping
    {
        public Task Process(TRequest request, string response)
        {
            // 4
            //response = response + "4" + request.Message;
            
            return Task.FromResult("Pong 4");
        }
    }
}
