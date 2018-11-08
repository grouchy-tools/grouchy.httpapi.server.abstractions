namespace Grouchy.HttpApi.Server.Abstractions.Tagging
{
   public interface IInboundRequestIdAccessor
   {
      string InboundRequestId { get; }
   }
}