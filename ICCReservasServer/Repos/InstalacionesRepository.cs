using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class InstalacionesRepository : IInstalacionesRepository
    {
        private readonly ApplicationDataContext _context;

        public InstalacionesRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(Instalaciones instalacion)
        {
            await _context.Instalaciones.AddAsync(instalacion);
        }

        public void DeleteConfirmed(int id)
        {
            var instalacion = _context.Instalaciones.Find(id);
            _context.Instalaciones.Remove(instalacion);
        }

        public async Task<Instalaciones> Details(int? id)
        {
            return await _context.Instalaciones.FirstOrDefaultAsync(m => m.ID == id);
        }

        public void Edit(Instalaciones instalacion)
        {
            _context.Instalaciones.Update(instalacion);
        }

        public async Task<IEnumerable<Instalaciones>> Index()
        {
            return await _context.Instalaciones.ToListAsync();
        }

        public bool InstalacionesExists(int id)
        {
            return _context.Instalaciones.Any(e => e.ID == id);
        }
    }
}
