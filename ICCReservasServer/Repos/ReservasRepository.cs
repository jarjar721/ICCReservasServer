using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class ReservasRepository : IReservasRepository
    {
        private readonly ApplicationDataContext _context;

        public ReservasRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(Reservas reserva)
        {
            await _context.Reservas.AddAsync(reserva);
        }

        public void DeleteConfirmed(int id)
        {
            var reserva = _context.Reservas.Find(id);
            _context.Reservas.Remove(reserva);
        }

        public async Task<Reservas> Details(int? id)
        {
            return await _context.Reservas.FirstOrDefaultAsync(m => m.ID == id);
        }

        public void Edit(Reservas reserva)
        {
            _context.Reservas.Update(reserva);
        }

        public bool ReservasExists(int id)
        {
            return _context.Dispositivos.Any(e => e.ID == id);
        }

        public async Task<IEnumerable<Reservas>> Index()
        {
            return await _context.Reservas.ToListAsync();
        }
    }
}
