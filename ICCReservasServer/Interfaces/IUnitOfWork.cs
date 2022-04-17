namespace ICCReservasServer.Interfaces
{
    public interface IUnitOfWork
    {
        IDispositivosRepository DispositivosRepository { get; }

        Task<bool> SaveAsync();
    }
}
