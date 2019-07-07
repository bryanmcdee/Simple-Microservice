namespace Actio.Common.Events
{
    public interface IRejected : IEvent
    {
        string Message { get; }
        string ErrorCode { get; }
    }
}
