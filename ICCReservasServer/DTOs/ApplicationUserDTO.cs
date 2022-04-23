using System.ComponentModel.DataAnnotations.Schema;

namespace ICCReservasServer.DTOs
{
    [NotMapped]
    public class ApplicationUserDTO
    {
        public string ID { get; set; }

        public string Names { get; set; }

        public string LastNames { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

    }
}
