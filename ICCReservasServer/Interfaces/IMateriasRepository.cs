using Entities.Models;

namespace ICCReservasServer.Interfaces
{
    public interface IMateriasRepository
    {
        Task<IEnumerable<Materias>> Index();

        Task<Materias> Details(int? id);

        void Create(Materias materia);

        void Edit(Materias materia);

        void DeleteConfirmed(int id);

        bool MateriasExists(int id);
    }
}
