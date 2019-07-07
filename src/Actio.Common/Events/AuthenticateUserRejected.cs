namespace Actio.Common.Events
{
    public class AuthenticateUserRejected : IRejected
    {
        public string Email { get; }
        public string Message { get; }
        public string ErrorCode { get; }
        protected AuthenticateUserRejected() { }
        public AuthenticateUserRejected(string email, string message, string errorCode)
        {
            Email = email;
            Message = message;
            ErrorCode = errorCode;
        }
    }
}
