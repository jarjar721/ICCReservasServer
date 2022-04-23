using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using ICCReservasServer.Repos;
using Microsoft.AspNetCore.Identity;

namespace ICCReservasServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDataContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDataContext context, UserManager<ApplicationUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }

        public IDispositivosRepository DispositivosRepository => new DispositivosRepository(_context);

        public IHorariosRepository HorariosRepository => new HorariosRepository(_context);

        public IInstalacionesRepository InstalacionesRepository => new InstalacionesRepository(_context);

        public IMateriasRepository MateriasRepository => new MateriasRepository(_context);

        public IUsuariosRepository UsuariosRepository => new UsuariosRepository(_userManager);

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
