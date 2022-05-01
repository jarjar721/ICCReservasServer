namespace ICCReservasServer.Middleware.Models
{
    public class EmailNotFoundException : Exception
    {
        public EmailNotFoundException(string message) : base(message)
        {
        }
    }
}
