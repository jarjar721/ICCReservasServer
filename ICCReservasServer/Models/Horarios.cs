using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.Models
{
    public class Horarios
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Duracion { get; set; }
        [Required]
        public string Nivel { get; set; }

        public List<Clases> Clases { get; set; }
    }
}
