using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.Models
{
    public class Status
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Descripcion { get; set; }

        public List<StatusReserva> StatusReserva { get; set; }
    }
}
