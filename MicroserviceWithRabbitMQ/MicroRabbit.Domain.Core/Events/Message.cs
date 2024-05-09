using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; } = string.Empty;
        protected Message() 
        {
            MessageType = GetType().Name;
        }
    }
}
