using Entities.Models;

namespace ICCReservasServer.DTOs
{
    public class ReservasDTO
    {
        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public DateTime DatetimeCreacion { get; set; }

        public DateTime DatetimeInicialReservacion { get; set; }

        public DateTime DatetimeFinalReservacion { get; set; }


        public string UserID { get; set; }

        public int InstalacionID { get; set; }


        public List<ReservaDispositivoDTO>? ReservaDispositivo { get; set; }

        public List<StatusReservaDTO>? StatusReserva { get; set; }

        //public List<HorarioReserva>? HorarioReserva { get; set; }
    }
}
