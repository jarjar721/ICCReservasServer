using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class FixedDispositivosRealProyectores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Dispositivos",
                newName: "Uso");

            migrationBuilder.AddColumn<string>(
                name: "Observacion",
                table: "Dispositivos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Dispositivos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Observacion", "Ubicacion", "Uso" },
                values: new object[] { "TEST DEVICE", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Observacion", "Ubicacion", "Uso" },
                values: new object[] { "TEST DEVICE", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Observacion", "Ubicacion", "Uso" },
                values: new object[] { "TEST DEVICE", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Observacion", "Ubicacion", "Uso" },
                values: new object[] { "TEST DEVICE", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "SAMSUNG", "S3", "TEST DEVICE", "0K7B6F", "Tablet", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "SAMSUNG", "S2", "TEST DEVICE", "1K2J3H", "Tablet", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "HUAWEI", "TRX3", "TEST DEVICE", "4J8FC7", "Tablet", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Ubicacion", "Uso" },
                values: new object[] { "HUAWEI", "34RF", "TEST DEVICE", "2MN3B4", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "KINGSTON", "CVT4", "TEST DEVICE", "PLO094", "Cable", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "KINGSTON", "GTR3", "TEST DEVICE", "CYD837", "Cable", "TEST UBICACIÓN", "TEST USO" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "Epson", "PowerLite S18+", "Buenas condiciones. Moderno (HDMI USB)", "TVAK4904105", "Proyector", "Depósito", "Móvil" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "Epson", "PowerLite S12+", "Buenas condiciones. Lámpara con potencia 64 H", "PSPK2407501", "Proyector", "Depósito", "Móvil" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Marca", "Modelo", "Observacion", "Serial", "Tipo", "Ubicacion", "Uso" },
                values: new object[] { "Epson", "PowerLite S12+", "Buenas condiciones. Lámpara con potencia 344 H", "PSPK2412010", "Proyector", "Oficina José Rivas", "Móvil" });

            migrationBuilder.InsertData(
                table: "Dispositivos",
                columns: new[] { "ID", "Marca", "Modelo", "Observacion", "Serial", "Status", "Tipo", "Ubicacion", "Uso" },
                values: new object[,]
                {
                    { 14, "InFocus", "IN26+", "Regular condiciones. Lámpara con baja potencia 2850 H", "AVFC73900421", 1, "Proyector", "Sala Didáctica de Primaria (Lab. Computación)", "Fijo" },
                    { 15, "InFocus", "IN112A", "Regular condiciones. Lámpara con potencia 1051H", "BMYB44404905", 1, "Proyector", "Sala Didáctica de Bachillerato (Lab. Computación)", "Fijo" },
                    { 16, "InFocus", "DESCONOCIDO", "Regular condiciones. Lámpara con baja potencia 2850 H", "DESCONOCIDO", 1, "Proyector", "Oficina José Alemán", "Móvil" },
                    { 17, "Epson", "DESCONOCIDO", "Regular condiciones. Lámpara con potencia 899 H", "00062667LE", 1, "Proyector", "Sala Multimedia al lado Sala Didáctica de Primaria (Lab. Computación)", "Fijo" },
                    { 18, "InFocus", "DESCONOCIDO", "Regular condiciones. Lámpara con baja potencia 2553 H", "IN112A", 1, "Proyector", "Auditorio", "Fijo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "Observacion",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Dispositivos");

            migrationBuilder.RenameColumn(
                name: "Uso",
                table: "Dispositivos",
                newName: "Descripcion");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 1,
                column: "Descripcion",
                value: "TEST DEVICE");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 2,
                column: "Descripcion",
                value: "TEST DEVICE");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 3,
                column: "Descripcion",
                value: "TEST DEVICE");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 4,
                column: "Descripcion",
                value: "TEST DEVICE");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "EPSON", "VXA", "298CCV", "Proyector" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "EPSON", "A4E", "HNY4RT", "Proyector" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "HP", "WER2", "3F5H6J", "Proyector" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial" },
                values: new object[] { "TEST DEVICE", "SAMSUNG", "S3", "0K7B6F" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "SAMSUNG", "S2", "1K2J3H", "Tablet" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "HUAWEI", "TRX3", "4J8FC7", "Tablet" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "HUAWEI", "34RF", "2MN3B4", "Tablet" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "KINGSTON", "CVT4", "PLO094", "Cable" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Descripcion", "Marca", "Modelo", "Serial", "Tipo" },
                values: new object[] { "TEST DEVICE", "KINGSTON", "GTR3", "CYD837", "Cable" });
        }
    }
}
