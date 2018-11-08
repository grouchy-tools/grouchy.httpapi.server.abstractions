using System;

namespace Grouchy.HttpApi.Server.Abstractions.Events
{
   public interface IHttpServerExceptionEvent : IHttpServerEvent
   {
      Exception Exception { get; }
      
      long DurationMs { get; }
   }
}