using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class MateriasConfigurationHS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "ID", "Codigo", "Descripcion", "Grado", "Nivel", "Nombre", "Status" },
                values: new object[,]
                {
                    { 1, "HS-9-1", "Descripción de Química", "9", "HS", "Química", 1 },
                    { 2, "HS-9-2", "Descripción de Geografía de Venezuela", "9", "HS", "Geografía de Venezuela", 1 },
                    { 3, "HS-9-3", "Descripción de Oratoria", "9", "HS", "Oratoria", 1 },
                    { 4, "HS-9-4", "Descripción de Informática", "9", "HS", "Informática", 1 },
                    { 5, "HS-9-5", "Descripción de Inglés", "9", "HS", "Inglés", 1 },
                    { 6, "HS-9-6", "Descripción de Biología", "9", "HS", "Biología", 1 },
                    { 7, "HS-9-7", "Descripción de Formación Católica", "9", "HS", "Formación Católica", 1 },
                    { 8, "HS-9-8", "Descripción de Change Maker", "9", "HS", "Change Maker", 1 },
                    { 9, "HS-9-9", "Descripción de Tutoría", "9", "HS", "Tutoría", 1 },
                    { 10, "HS-9-10", "Descripción de Matemática", "9", "HS", "Matemática", 1 },
                    { 11, "HS-9-11", "Descripción de Física", "9", "HS", "Física", 1 },
                    { 12, "HS-9-12", "Descripción de Castellano", "9", "HS", "Castellano", 1 },
                    { 13, "HS-9-13", "Descripción de Educación Física", "9", "HS", "Educación Física", 1 },
                    { 14, "HS-9-14", "Descripción de Electiva", "9", "HS", "Electiva", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "ID",
                keyValue: 14);
        }
    }
}
