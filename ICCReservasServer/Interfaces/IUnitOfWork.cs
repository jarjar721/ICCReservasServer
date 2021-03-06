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

        Task<bool> SaveAsync();
    }
}
