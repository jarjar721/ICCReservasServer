using Entities.Models;
using ICCReservasServer.DTOs;

namespace ICCReservasServer.Interfaces
{
    public interface IReservaDispositivoRepository
    {
        Task<IEnumerable<ReservaDispositivo>> Index();

        Task<IEnumerable<ReservaDispositivo>> GetDispositivoIDs(int? reservaID);

        void Create(List<ReservaDispositivo> reservaDispositivo);

        void Edit(List<ReservaDispositivo> reservaDispositivo);

        void DeleteConfirmed(int id);

        bool ReservaDispositivoExists(int id);

    }
}
