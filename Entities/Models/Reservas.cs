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

     
        public string UserID { get; set; }
        public ApplicationUser? User { get; set; }

        public int InstalacionID { get; set; }
        public Instalaciones? Instalacion { get; set; }


        public List<ReservaDispositivo>? ReservaDispositivo { get; set; }
        public List<StatusReserva>? StatusReserva { get; set; }
        public List<HorarioReserva>? HorarioReserva { get; set; }

    }
}
