using Grouchy.Abstractions.Events;

namespace Grouchy.HttpApi.Server.Abstractions.Events
{
   public interface IHttpServerEvent : IEvent
   {
      string Uri { get; }

      string Method { get; }
   }
}