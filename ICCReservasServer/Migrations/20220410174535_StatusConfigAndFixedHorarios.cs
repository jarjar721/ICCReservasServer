using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class StatusConfigAndFixedHorarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoHora",
                table: "Horarios");

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<int>(type: "integer", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "ID", "Codigo", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { 1, 1, "El requerimiento ha sido creado y espera ser procesado.", "Pendiente" },
                    { 2, 2, "El requerimiento ha sido tomado y se encuentra en proceso de ser gestionado.", "En proceso" },
                    { 3, 3, "El requerimiento ha sido procesado y completado.", "Completado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.AddColumn<string>(
                name: "TipoHora",
                table: "Horarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
