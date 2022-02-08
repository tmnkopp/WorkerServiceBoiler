using System;
using System.Threading.Tasks;
using MSB.Messages;
using Rebus.Handlers;

namespace MSB.Services.Payment
{
    public class NewOrderHandler : IHandleMessages<RequestMessage>
    {
        public Task Handle(RequestMessage message)
        {
            Console.WriteLine($"PayloadId {message.PayloadId}.");
            return Task.CompletedTask;
        }
    }
}
