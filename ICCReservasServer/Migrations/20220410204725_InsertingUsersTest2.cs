using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class InsertingUsersTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ae47d34-75d1-4f75-b070-dc4acd2fe668", 0, "39c3034d-0350-4d64-8bb8-3f1faf4c23a9", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", null, null, null, null, false, "143b58c9-660b-44e8-9486-b89c00fc47f9", false, "nadorno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ae47d34-75d1-4f75-b070-dc4acd2fe668");
        }
    }
}
