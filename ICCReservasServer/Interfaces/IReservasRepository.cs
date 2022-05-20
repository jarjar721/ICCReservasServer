using Entities.Models;

namespace ICCReservasServer.Interfaces
{
    public interface IReservasRepository
    {
        Task<IEnumerable<Reservas>> Index();

        Task<Reservas> Details(int? id);

        void Create(Reservas reserva);

        void Edit(Reservas reserva);

        void DeleteConfirmed(int id);

        bool ReservasExists(int id);
    }
}
