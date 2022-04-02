using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.Models
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
        public string Descripcion { get; set; }

        public List<Clases> Clases { get; set; }
    }
}
