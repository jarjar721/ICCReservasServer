using Entities.Models;

namespace ICCReservasServer.Interfaces
{
    public interface IHorariosRepository
    {
        Task<IEnumerable<Horarios>> Index();

        Task<Horarios> Details(int? id);

        void Create(Horarios horario);

        void Edit(Horarios horario);

        void DeleteConfirmed(int id);

        bool HorariosExists(int id);
    }
}
