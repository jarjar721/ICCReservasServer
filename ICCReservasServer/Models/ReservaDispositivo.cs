using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.Models
{
    public class ReservaDispositivo
    {
        [Required]
        [Key]
        public int ID { get; set; }

        public int DispositivoID { get; set; }
        public Dispositivos Dispositivo { get; set; }

        public int ReservaID { get; set; }
        public Reservas Reserva { get; set; }
    }
}
