using Entities.Data;
using Entities.Models;
using ICCReservasServer.DTOs;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

        public void Edit(Dispositivos dispositivo)
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

        
        public List<DispositivosTypeAmount> AvailableDispositivosByType(DateTime DatetimeInicialReservacion, DateTime DatetimeFinalReservacion)
        {
            var dispositivosReservados = _context.ReservaDispositivo
                .Where(rd => rd.DatetimeInicialReservacion >= DatetimeInicialReservacion && rd.DatetimeFinalReservacion <= DatetimeFinalReservacion)
                .Select(rd => rd.DispositivoID)
                .ToList();

            var allDispositivos = _context.Dispositivos
                .Where(t => t.Status == 1 && !dispositivosReservados.Contains(t.ID))
                .GroupBy(t => t.Tipo)
                .Select(dispGroup => new { Tipo = dispGroup.Key, Count = dispGroup.Count() })
                .ToList();

            List<DispositivosTypeAmount> availableDispositivos = new List<DispositivosTypeAmount> { };
            foreach (var dispositivo in allDispositivos)
            {
                availableDispositivos.Add(new DispositivosTypeAmount { Tipo = dispositivo.Tipo, Count = dispositivo.Count });
            }

            return availableDispositivos;
        }

    }
}
