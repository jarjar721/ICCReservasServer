using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class ReservaDispositivoRepository : IReservaDispositivoRepository
    {
        private readonly ApplicationDataContext _context;

        public ReservaDispositivoRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(List<ReservaDispositivo> reservaDispositivo)
        {
            await _context.ReservaDispositivo.AddRangeAsync(reservaDispositivo);
        }

        public void DeleteConfirmed(int id)
        {
            var reservaDispositivo = _context.ReservaDispositivo.Find(id);
            _context.ReservaDispositivo.Remove(reservaDispositivo);
        }

        public async Task<IEnumerable<ReservaDispositivo>> GetDispositivoIDs(int? reservaID)
        {
            return await _context.ReservaDispositivo.Where(m => m.ReservaID == reservaID).ToListAsync();
        }

        public void Edit(List<ReservaDispositivo> reservaDispositivo)
        {
            _context.ReservaDispositivo.UpdateRange(reservaDispositivo);
        }

        public async Task<IEnumerable<ReservaDispositivo>> Index()
        {
            return await _context.ReservaDispositivo.ToListAsync();
        }

        public bool ReservaDispositivoExists(int id)
        {
            return _context.ReservaDispositivo.Any(e => e.ID == id);
        }
    }
}
