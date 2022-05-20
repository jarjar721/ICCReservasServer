namespace ICCReservasServer.DTOs
{
    public class StatusReservaDTO
    {
        public int ID { get; set; }

        public DateTime FechaStatus { get; set; }

        public int ReservaID { get; set; }

        public int StatusID { get; set; }
    }
}
