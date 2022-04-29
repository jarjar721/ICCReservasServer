namespace ICCReservasServer.Middleware.Models
{
    public class RegisteredEmailException : Exception
    {
        public RegisteredEmailException(string message) : base(message)
        {
        }
    }
}
