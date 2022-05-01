using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Clases
    {
        [Required]
        [Key]
        public int ID { get; set; }

        public int HorarioID { get; set; }
        public Horarios? Horario { get; set; }

        public int MateriaID { get; set; }
        public Materias? Materia { get; set; }
        public List<Reservas>? Reservas { get; set; }

        public string UserID { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
