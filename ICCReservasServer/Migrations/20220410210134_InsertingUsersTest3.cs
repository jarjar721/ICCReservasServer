using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class InsertingUsersTest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ae47d34-75d1-4f75-b070-dc4acd2fe668");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a288e6a4-2f61-4dbf-ad97-d6d21b564002", 0, "fd3d87cb-4915-4867-9308-1a21d86706cb", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", "NADORNO@CUMBRESCARACAS.EDU.VE", "NADORNO", null, null, false, "47a76f0c-86cb-431e-a396-60f124c064d2", false, "nadorno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a288e6a4-2f61-4dbf-ad97-d6d21b564002");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ae47d34-75d1-4f75-b070-dc4acd2fe668", 0, "39c3034d-0350-4d64-8bb8-3f1faf4c23a9", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", null, null, null, null, false, "143b58c9-660b-44e8-9486-b89c00fc47f9", false, "nadorno" });
        }
    }
}
