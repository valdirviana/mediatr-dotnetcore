using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatr.ConsoleApp.Command
{
    public class Ping : IRequest<string>
    {
    }
}
