using Entities.Data;
using Entities.Models;
using ICCReservasServer.DTOs;
using ICCReservasServer.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ICCReservasServer.Repos
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        //private readonly SignInManager<ApplicationUser> _signInManager;

        public UsuariosRepository(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IdentityResult> Create(ApplicationUser applicationUser)
        {
            return await _userManager.CreateAsync(applicationUser);
        }

        public async Task<IdentityResult> DeleteConfirmed(string id)
        {
            ApplicationUser applicationUser = await _userManager.FindByIdAsync(id);
            return await _userManager.DeleteAsync(applicationUser);
        }

        public async Task<ApplicationUser> Details(string? id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<IdentityResult> Edit(string id, ApplicationUserDTO applicationUserDTO)
        {
            var usuario = await _userManager.FindByIdAsync(id);

            usuario.Email = applicationUserDTO.Email;
            usuario.UserName = applicationUserDTO.UserName;
            usuario.Names = applicationUserDTO.Names;
            usuario.LastNames = applicationUserDTO.LastNames;
            usuario.Status = applicationUserDTO.Status;

            return await _userManager.UpdateAsync(usuario);

        }

        public IEnumerable<ApplicationUser> Index()
        {
            return _userManager.Users.ToList();
        }

        public bool ApplicationUserExists(string id)
        {
            return _userManager.Users.Any(u => u.Id == id); 
        }
    }
}
