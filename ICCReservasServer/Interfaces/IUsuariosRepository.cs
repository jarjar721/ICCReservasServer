using Entities.Models;
using ICCReservasServer.DTOs;
using Microsoft.AspNetCore.Identity;

namespace ICCReservasServer.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<ApplicationUser> Details(string? id);

        Task<IdentityResult> Create(ApplicationUser applicationUser);

        IEnumerable<ApplicationUser> Index();

        Task<IdentityResult> Edit(string id, ApplicationUserDTO applicationUserDTO);

        Task<IdentityResult> DeleteConfirmed(string id);

        bool ApplicationUserExists(string id);
    }
}
