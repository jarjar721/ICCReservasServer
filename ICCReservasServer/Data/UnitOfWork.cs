using Entities.Data;
using Entities.Models;
using ICCReservasServer.DTOs;
using ICCReservasServer.Interfaces;
using ICCReservasServer.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace ICCReservasServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationSettings _appSettings;

        public UnitOfWork(ApplicationDataContext context, UserManager<ApplicationUser> userManager, IOptions<ApplicationSettings> appSettings)
        {
            _context = context;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }

        public IDispositivosRepository DispositivosRepository => new DispositivosRepository(_context);

        public IHorariosRepository HorariosRepository => new HorariosRepository(_context);

        public IInstalacionesRepository InstalacionesRepository => new InstalacionesRepository(_context);

        public IMateriasRepository MateriasRepository => new MateriasRepository(_context);

        public IUsuariosRepository UsuariosRepository => new UsuariosRepository(_userManager);

        public IAuthenticationRepository AuthenticationRepository => new AuthenticationRepository(_userManager, _appSettings);

        public IReservasRepository ReservasRepository => new ReservasRepository(_context);

        public IStatusReservaRepository StatusReservaRepository => new StatusReservaRepository(_context);

        public IReservaDispositivoRepository ReservaDispositivoRepository => new ReservaDispositivoRepository(_context);

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
