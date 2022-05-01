namespace ICCReservasServer.Middleware.Models
{
    public class FailedLoginException : Exception
    {
        public FailedLoginException(string message) : base(message)
        {
        }
    }
}
