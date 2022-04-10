using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class InstalacionesConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instalaciones",
                columns: new[] { "ID", "Capacidad", "Codigo", "Descripcion", "Edificio", "Nombre", "Piso", "Status", "Tipo" },
                values: new object[,]
                {
                    { 1, 0, "HS-S-1", "Deposito 1 en el sotano.", "HS", "Deposito 1", "S", 0, "Deposito" },
                    { 2, 15, "HS-S-2", "Salón de Ciencias de la Tierra", "HS", "Ciencias de la Tierra", "S", 1, "Aula" },
                    { 3, 15, "HS-S-3", "Salón de Dibujo Técnico", "HS", "Dibujo Técnico", "S", 1, "Aula" },
                    { 4, 0, "HS-S-4", "Deposito 2 en el sotano.", "HS", "Deposito 2", "S", 0, "Deposito" },
                    { 5, 20, "HS-S-5", "Laboratorio de Biología (Salón 2)", "HS", "Laboratorio de Biología (Salón 2)", "S", 1, "Laboratorio" },
                    { 6, 20, "HS-S-6", "Laboratorio de Física (Salón 2)", "HS", "Laboratorio de Física", "S", 1, "Laboratorio" },
                    { 7, 20, "HS-S-7", "Laboratorio de Química (Salón 2)", "HS", "Laboratorio de Química", "S", 1, "Laboratorio" },
                    { 8, 20, "HS-S-8", "Laboratorio de Biología (Salón 1)", "HS", "Laboratorio de Biología (Salón 1)", "S", 1, "Laboratorio" },
                    { 9, 20, "HS-1-1", "Salón 2 de Humanidades/Tutoría", "HS", "Humanidades/Tutoría Salón 2", "1", 1, "Aula" },
                    { 10, 25, "HS-1-2", "Salón 1 de Humanidades/Tutoría", "HS", "Humanidades/Tutoría Salón 1", "1", 1, "Aula" },
                    { 11, 20, "HS-1-3", "Sala de estudios", "HS", "Study Hall", "1", 1, "Aula" },
                    { 12, 25, "HS-1-4", "Salón de Ciencias Sociales", "HS", "Ciencias Sociales", "1", 1, "Aula" },
                    { 13, 25, "HS-1-5", "Salón 1 de Química", "HS", "Química Salon 1", "1", 1, "Aula" },
                    { 14, 25, "HS-1-6", "Salón de Catholic Leadership Change Makers", "HS", "Catholic Leadership Change Makers", "1", 1, "Aula" },
                    { 15, 3, "HS-1-7", "Oficina Directiva 1", "HS", "Oficina Directiva 1", "1", 1, "Oficina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instalaciones",
                keyColumn: "ID",
                keyValue: 15);
        }
    }
}
