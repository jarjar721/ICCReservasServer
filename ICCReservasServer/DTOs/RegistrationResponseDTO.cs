using System.ComponentModel.DataAnnotations.Schema;

namespace ICCReservasServer.DTOs
{
    [NotMapped]
    public class RegistrationResponseDTO
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
