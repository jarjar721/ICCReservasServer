using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICCReservasServer.DTOs
{
    [NotMapped]
    public class AddUserDTO
    {
        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; }

        public string? SecondLastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
