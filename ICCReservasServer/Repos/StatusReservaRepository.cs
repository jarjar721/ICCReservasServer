using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class StatusReservaRepository : IStatusReservaRepository
    {
        private readonly ApplicationDataContext _context;

        public StatusReservaRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(List<StatusReserva> statusReserva)
        {
            await _context.StatusReserva.AddRangeAsync(statusReserva);
        }

        public void DeleteConfirmed(int id)
        {
            var statusReserva = _context.StatusReserva.Find(id);
            _context.StatusReserva.Remove(statusReserva);
        }

        public async Task<IEnumerable<StatusReserva>> GetDispositivoIDs(int? reservaID)
        {
            return await _context.StatusReserva.Where(m => m.ReservaID == reservaID).ToListAsync();
        }

        public void Edit(List<StatusReserva> statusReserva)
        {
            _context.StatusReserva.UpdateRange(statusReserva);
        }

        public async Task<IEnumerable<StatusReserva>> Index()
        {
            return await _context.StatusReserva.ToListAsync();
        }

        public bool StatusReservaExists(int id)
        {
            return _context.StatusReserva.Any(e => e.ID == id);
        }
    }
}
