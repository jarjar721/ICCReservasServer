using System.ComponentModel.DataAnnotations;

namespace ICCReservasServer.Models
{
    public class Instalaciones
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        public string Edificio { get; set; }
        [Required]
        public string Piso { get; set; }
        [Required]
        public int Status { get; set; }

        public List<Reservas> Reservas { get; set; }
    }
}
