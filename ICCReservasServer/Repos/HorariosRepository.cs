using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class HorariosRepository : IHorariosRepository
    {
        private readonly ApplicationDataContext _context;

        public HorariosRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(Horarios horario)
        {
            await _context.Horarios.AddAsync(horario);
        }

        public void DeleteConfirmed(int id)
        {
            var horario = _context.Horarios.Find(id);
            _context.Horarios.Remove(horario);
        }

        public async Task<Horarios> Details(int? id)
        {
            return await _context.Horarios.FirstOrDefaultAsync(m => m.ID == id);
        }

        public bool HorariosExists(int id)
        {
            return _context.Horarios.Any(e => e.ID == id);
        }

        public void Edit(Horarios horario)
        {
            _context.Horarios.Update(horario);
        }

        public async Task<IEnumerable<Horarios>> Index()
        {
            return await _context.Horarios.ToListAsync();
        }
    }
}
