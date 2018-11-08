namespace Grouchy.HttpApi.Server.Abstractions.Events
{
   public interface IHttpServerResponseEvent : IHttpServerEvent
   {
      int StatusCode { get; }
      
      long DurationMs { get; }
   }
}