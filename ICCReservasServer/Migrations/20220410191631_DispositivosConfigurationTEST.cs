using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class DispositivosConfigurationTEST : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dispositivos",
                columns: new[] { "ID", "Descripcion", "Marca", "Modelo", "Serial", "Status", "Tipo" },
                values: new object[,]
                {
                    { 1, "TEST DEVICE", "DELL", "X1", "345VEG", 1, "Laptop" },
                    { 2, "TEST DEVICE", "ACER", "T3", "NFG456", 1, "Laptop" },
                    { 3, "TEST DEVICE", "ASUS", "D4", "BRI456", 1, "Laptop" },
                    { 4, "TEST DEVICE", "HP", "S6", "NWO203", 1, "Laptop" },
                    { 5, "TEST DEVICE", "EPSON", "VXA", "298CCV", 1, "Proyector" },
                    { 6, "TEST DEVICE", "EPSON", "A4E", "HNY4RT", 1, "Proyector" },
                    { 7, "TEST DEVICE", "HP", "WER2", "3F5H6J", 1, "Proyector" },
                    { 8, "TEST DEVICE", "SAMSUNG", "S3", "0K7B6F", 1, "Tablet" },
                    { 9, "TEST DEVICE", "SAMSUNG", "S2", "1K2J3H", 1, "Tablet" },
                    { 10, "TEST DEVICE", "HUAWEI", "TRX3", "4J8FC7", 1, "Tablet" },
                    { 11, "TEST DEVICE", "HUAWEI", "34RF", "2MN3B4", 1, "Tablet" },
                    { 12, "TEST DEVICE", "KINGSTON", "CVT4", "PLO094", 1, "Cable" },
                    { 13, "TEST DEVICE", "KINGSTON", "GTR3", "CYD837", 1, "Cable" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 13);
        }
    }
}
