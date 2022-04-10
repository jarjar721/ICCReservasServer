using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class AddedRealHorarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "ID", "HoraFin", "HoraInicio", "Nivel", "Numero" },
                values: new object[,]
                {
                    { 8, "09:00:00", "08:15:00", "MS", 1 },
                    { 9, "09:45:00", "09:00:00", "MS", 2 },
                    { 10, "11:15:00", "10:30:00", "MS", 3 },
                    { 11, "12:00:00", "11:15:00", "MS", 4 },
                    { 12, "12:55:00", "12:10:00", "MS", 5 },
                    { 13, "13:40:00", "12:55:00", "MS", 6 },
                    { 14, "09:40:00", "08:50:00", "UE", 1 },
                    { 15, "10:30:00", "09:40:00", "UE", 2 },
                    { 16, "12:00:00", "11:15:00", "UE", 3 },
                    { 17, "12:45:00", "12:00:00", "UE", 4 },
                    { 18, "13:50:00", "13:05:00", "UE", 5 },
                    { 19, "14:35:00", "13:50:00", "UE", 6 },
                    { 20, "09:40:00", "08:50:00", "LE", 1 },
                    { 21, "10:30:00", "09:40:00", "LE", 2 },
                    { 22, "11:15:00", "10:30:00", "LE", 3 },
                    { 23, "12:45:00", "12:00:00", "LE", 4 },
                    { 24, "13:30:00", "12:45:00", "LE", 5 },
                    { 25, "14:35:00", "13:50:00", "LE", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "ID",
                keyValue: 25);
        }
    }
}
