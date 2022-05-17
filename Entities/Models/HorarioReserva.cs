using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class HorarioReserva
    {
        [Required]
        [Key]
        public int ID { get; set; }

        public int HorarioID { get; set; }
        public Horarios? Horario { get; set; }

        public int ReservaID { get; set; }
        public Reservas? Reserva { get; set; }

    }
}
