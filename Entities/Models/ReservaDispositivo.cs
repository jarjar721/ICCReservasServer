using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ReservaDispositivo
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime DatetimeInicialReservacion { get; set; }

        [Required]
        public DateTime DatetimeFinalReservacion { get; set; }


        public int DispositivoID { get; set; }
        public Dispositivos? Dispositivo { get; set; }

        public int ReservaID { get; set; }
        public Reservas? Reserva { get; set; }
    }
}
