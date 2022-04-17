using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Dispositivos
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Observacion { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Serial { get; set; }

        [Required]
        public string Uso { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        public int Status { get; set; }

        public List<ReservaDispositivo>? ReservaDispositivo { get; set; }
    }
}
