using Entities.Models;

namespace ICCReservasServer.Repos
{
    public interface IDispositivosRepository
    {
        Task<IEnumerable<Dispositivos>> Index();

        Task<Dispositivos> Details(int? id);

        void Create(Dispositivos dispositivo);

        void Edit(int id, Dispositivos dispositivo);

        void DeleteConfirmed(int id);

        bool DispositivosExists(int id);

        Task<bool> SaveAsync();
    }
}
