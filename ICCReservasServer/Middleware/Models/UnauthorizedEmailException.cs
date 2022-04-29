namespace ICCReservasServer.Middleware.Models
{
    public class UnauthorizedEmailException : Exception
    {
        public UnauthorizedEmailException(string message) : base(message)
        {
        }
    }
}
