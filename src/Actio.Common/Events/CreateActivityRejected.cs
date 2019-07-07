using System;

namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejected
    {
        public Guid Id { get; }
        public string Message { get; }
        public string ErrorCode { get; }
        protected CreateActivityRejected() { }
        public CreateActivityRejected(Guid id, string message, string errorCode)
        {
            Id = id;
            Message = message;
            ErrorCode = errorCode;
        }
    }
}
