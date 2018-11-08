using Grouchy.HttpApi.Server.Abstractions.Events;

namespace Grouchy.HttpApi.Server.Abstractions.EventCallbacks
{
   public interface IHttpServerEventCallback
   {
      void Invoke(IHttpServerEvent @event);
   }
}