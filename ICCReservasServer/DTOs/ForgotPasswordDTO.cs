using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.DTOs
{
    public class ForgotPasswordDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string ClientURI { get; set; }
    }
}
