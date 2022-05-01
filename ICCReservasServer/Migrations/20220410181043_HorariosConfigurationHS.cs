using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class HorariosConfigurationHS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "ID", "HoraFin", "HoraInicio", "Nivel", "Numero" },
                values: new object[,]
                {
                    { 1, "08:15:00", "07:30:00", "HS", 1 },
                    { 2, "09:00:00", "08:15:00", "HS", 2 },
                    { 3, "10:30:00", "09:45:00", "HS", 3 },
                    { 4, "11:15:00", "10:30:00", "HS", 4 },
                    { 5, "12:00:00", "11:15:00", "HS", 5 },
                    { 6, "13:15:00", "12:30:00", "HS", 6 },
                    { 7, "14:00:00", "13:15:00", "HS", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}
