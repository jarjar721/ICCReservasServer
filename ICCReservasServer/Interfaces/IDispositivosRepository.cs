using Entities.Models;
using ICCReservasServer.DTOs;

namespace ICCReservasServer.Interfaces
{
    public interface IDispositivosRepository
    {
        Task<IEnumerable<Dispositivos>> Index();

        Task<Dispositivos> Details(int? id);

        void Create(Dispositivos dispositivo);

        void Edit(Dispositivos dispositivo);

        void DeleteConfirmed(int id);

        bool DispositivosExists(int id);

        List<DispositivosTypeAmount> AvailableDispositivosByType(DateTime DatetimeInicialReservacion, DateTime DatetimeFinalReservacion);


    }
}
