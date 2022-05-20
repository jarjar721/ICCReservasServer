using Entities.Models;

namespace ICCReservasServer.Interfaces
{
    public interface IStatusReservaRepository
    {
        Task<IEnumerable<StatusReserva>> Index();

        Task<IEnumerable<StatusReserva>> GetDispositivoIDs(int? reservaID);

        void Create(List<StatusReserva> statusReserva);

        void Edit(List<StatusReserva> statusReserva);

        void DeleteConfirmed(int id);

        bool StatusReservaExists(int id);
    }
}
