using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class DispositivosRepository : IDispositivosRepository
    {
        private readonly ApplicationDataContext _context;

        public DispositivosRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(Dispositivos dispositivo)
        {
            await _context.Dispositivos.AddAsync(dispositivo);
        }

        public void DeleteConfirmed(int id)
        {
            var dispositivo = _context.Dispositivos.Find(id);
            _context.Dispositivos.Remove(dispositivo);
        }

        public async Task<Dispositivos> Details(int? id)
        {
            return await _context.Dispositivos.FirstOrDefaultAsync(m => m.ID == id);
        }

        public void Edit(int id, Dispositivos dispositivo)
        {
            _context.Dispositivos.Update(dispositivo);
        }

        public async Task<IEnumerable<Dispositivos>> Index()
        {
            return await _context.Dispositivos.ToListAsync();
        }

        public bool DispositivosExists(int id)
        {
            return _context.Dispositivos.Any(e => e.ID == id);
        }
    }
}
