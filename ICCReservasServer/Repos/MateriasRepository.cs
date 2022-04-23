using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Repos
{
    public class MateriasRepository : IMateriasRepository
    {
        private readonly ApplicationDataContext _context;

        public MateriasRepository(ApplicationDataContext context)
        {
            this._context = context;
        }

        public async void Create(Materias materia)
        {
            await _context.Materias.AddAsync(materia);
        }

        public void DeleteConfirmed(int id)
        {
            var materia = _context.Materias.Find(id);
            _context.Materias.Remove(materia);
        }

        public async Task<Materias> Details(int? id)
        {
            return await _context.Materias.FirstOrDefaultAsync(m => m.ID == id);
        }

        public bool MateriasExists(int id)
        {
            return _context.Materias.Any(e => e.ID == id);
        }

        public void Edit(Materias materia)
        {
            _context.Materias.Update(materia);
        }

        public async Task<IEnumerable<Materias>> Index()
        {
            return await _context.Materias.ToListAsync();
        }
    }
}
