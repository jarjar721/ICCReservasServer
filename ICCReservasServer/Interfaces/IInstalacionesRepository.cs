using Entities.Models;

namespace ICCReservasServer.Interfaces
{
    public interface IInstalacionesRepository
    {
        Task<IEnumerable<Instalaciones>> Index();

        Task<Instalaciones> Details(int? id);

        void Create(Instalaciones instalacion);

        void Edit(Instalaciones instalacion);

        void DeleteConfirmed(int id);

        bool InstalacionesExists(int id);
    }
}
