using Entities.Data;
using ICCReservasServer.Interfaces;
using ICCReservasServer.Repos;

namespace ICCReservasServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDataContext _context;

        public UnitOfWork(ApplicationDataContext context)
        {
            this._context = context;
        }

        public IDispositivosRepository DispositivosRepository => new DispositivosRepository(_context);

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
