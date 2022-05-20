namespace ICCReservasServer.Interfaces
{
    public interface IUnitOfWork
    {
        IDispositivosRepository DispositivosRepository { get; }

        IHorariosRepository HorariosRepository { get; }

        IInstalacionesRepository InstalacionesRepository { get; }

        IMateriasRepository MateriasRepository { get; }

        IUsuariosRepository UsuariosRepository { get; }

        IAuthenticationRepository AuthenticationRepository { get; }

        IReservasRepository ReservasRepository { get; }

        IStatusReservaRepository StatusReservaRepository { get; }

        IReservaDispositivoRepository ReservaDispositivoRepository { get; }

        Task<bool> SaveAsync();
    }
}
