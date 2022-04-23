using Entities.Data;
using Entities.Models;
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

        public async void Create(ApplicationUser applicationUser)
        {
            await _userManager.CreateAsync(applicationUser);
        }

        public async void DeleteConfirmed(string id)
        {
            ApplicationUser applicationUser = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(applicationUser);
        }

        public async Task<ApplicationUser> Details(string? id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async void Edit(ApplicationUser applicationUser)
        {
            await _userManager.UpdateAsync(applicationUser);
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
