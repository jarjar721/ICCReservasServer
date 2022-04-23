using Entities.Models;

namespace ICCReservasServer.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<ApplicationUser> Details(string? id);

        void Create(ApplicationUser applicationUser);

        IEnumerable<ApplicationUser> Index();

        void Edit(ApplicationUser applicationUser);

        void DeleteConfirmed(string id);

        bool ApplicationUserExists(string id);
    }
}
