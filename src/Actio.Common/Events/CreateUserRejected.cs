namespace Actio.Common.Events
{
    public class CreateUserRejected : IRejected
    {
        public string Email { get; }
        public string Message { get; }
        public string ErrorCode { get; }
        protected CreateUserRejected() { }
        public CreateUserRejected(string email, string message, string errorCode)
        {
            Email = email;
            Message = message;
            ErrorCode = errorCode;
        }
    }
}
