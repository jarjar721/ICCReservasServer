using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.Models
{
    public class StatusReserva
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime FechaStatus { get; set; }

        public int ReservaID { get; set; }
        public Reservas Reserva { get; set; }

        public int StatusID { get; set; }
        public Status Status { get; set; }
    }
}
