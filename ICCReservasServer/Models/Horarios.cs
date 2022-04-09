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
        public string HoraInicio { get; set; }

        [Required]
        public string HoraFin { get; set; }

        [Required]
        public string Nivel { get; set; }

        //public List<Clases> Clases { get; set; }
    }
}
