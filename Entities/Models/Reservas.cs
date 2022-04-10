using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Reservas
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime DatetimeCreacion { get; set; }
        [Required]
        public DateTime DatetimeReservacion { get; set; }

        public List<ReservaDispositivo> ReservaDispositivo { get; set; }
        public List<StatusReserva> StatusReserva { get; set; }

        public int InstalacionID { get; set; }
        public Instalaciones Instalacion { get; set; }

        public int ClaseID { get; set; }
        public Clases Clase { get; set; }
    }
}
