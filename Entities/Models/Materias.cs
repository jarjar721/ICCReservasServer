using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Materias
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Grado { get; set; }

        [Required]
        public string Nivel { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int Status { get; set; }

        public List<HorarioReserva>? Clases { get; set; }
    }
}
