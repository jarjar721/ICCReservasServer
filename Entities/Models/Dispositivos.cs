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
        public string Descripcion { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Serial { get; set; }
        [Required]
        public int Status { get; set; }

        //public List<ReservaDispositivo> ReservaDispositivo { get; set; }
    }
}
