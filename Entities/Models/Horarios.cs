using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Horarios
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nivel { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string HoraInicio { get; set; }

        [Required]
        public string HoraFin { get; set; }

        //[Required]
        //public string TipoHora { get; set; }

        public List<HorarioReserva>? HorarioReserva { get; set; }
    }
}
