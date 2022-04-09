using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class FixedHorarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracion",
                table: "Horarios");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "HoraFin",
                table: "Horarios",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "HoraInicio",
                table: "Horarios",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraFin",
                table: "Horarios");

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "Horarios");

            migrationBuilder.AddColumn<string>(
                name: "Duracion",
                table: "Horarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
