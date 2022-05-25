namespace ICCReservasServer.DTOs
{
    public class CreateReservaDTO
    {
        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public DateTime DatetimeCreacion { get; set; }

        public DateTime DatetimeInicialReservacion { get; set; }

        public DateTime DatetimeFinalReservacion { get; set; }

        public DispositivosTypeAmount[]? DispositivosTypeAmount { get; set; }



        public string UserID { get; set; }

        public int InstalacionID { get; set; }



        public List<ReservaDispositivoDTO>? ReservaDispositivo { get; set; }

        public List<StatusReservaDTO>? StatusReserva { get; set; }
    }
}
