using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class newDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Names = table.Column<string>(type: "text", nullable: false),
                    LastNames = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dispositivos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: false),
                    Serial = table.Column<string>(type: "text", nullable: false),
                    Uso = table.Column<string>(type: "text", nullable: false),
                    Ubicacion = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastUpdatedByID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositivos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nivel = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    HoraInicio = table.Column<string>(type: "text", nullable: false),
                    HoraFin = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instalaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Capacidad = table.Column<int>(type: "integer", nullable: false),
                    Edificio = table.Column<string>(type: "text", nullable: false),
                    Piso = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instalaciones", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Grado = table.Column<string>(type: "text", nullable: false),
                    Nivel = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    DatetimeCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DatetimeInicialReservacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DatetimeFinalReservacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserID = table.Column<string>(type: "text", nullable: false),
                    InstalacionID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reservas_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Instalaciones_InstalacionID",
                        column: x => x.InstalacionID,
                        principalTable: "Instalaciones",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorarioReserva",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HorarioID = table.Column<int>(type: "integer", nullable: false),
                    ReservaID = table.Column<int>(type: "integer", nullable: false),
                    MateriasID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioReserva", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HorarioReserva_Horarios_HorarioID",
                        column: x => x.HorarioID,
                        principalTable: "Horarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioReserva_Materias_MateriasID",
                        column: x => x.MateriasID,
                        principalTable: "Materias",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HorarioReserva_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservaDispositivo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatetimeInicialReservacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DatetimeFinalReservacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DispositivoID = table.Column<int>(type: "integer", nullable: false),
                    ReservaID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaDispositivo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReservaDispositivo_Dispositivos_DispositivoID",
                        column: x => x.DispositivoID,
                        principalTable: "Dispositivos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaDispositivo_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatusReserva",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaStatus = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReservaID = table.Column<int>(type: "integer", nullable: false),
                    StatusID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusReserva", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StatusReserva_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatusReserva_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "007a9104-3e62-472a-860d-2d81064642d9", 0, "14cf0c18-5517-4a75-9b72-236ea9fcbd9f", "maherrera@cumbrescaracas.edu.ve", false, "Herrera Bello", false, null, "María Alejandra", "MAHERRERA@CUMBRESCARACAS.EDU.VE", "MAHERRERA", null, null, false, "e1d3bcfa-3af3-4712-8d45-71f651658b99", false, "maherrera" },
                    { "00b519ca-2da9-48c0-8326-33c907d517e2", 0, "045df0ae-8727-4727-9bba-cb78837bb075", "gvelandia@cumbrescaracas.edu.ve", false, "Velandia", false, null, "Gabriel", "GVELANDIA@CUMBRESCARACAS.EDU.VE", "GVELANDIA", null, null, false, "e6643c6a-bf47-4e0a-8ac4-c9a54d25bd9a", false, "gvelandia" },
                    { "0145d75e-4bc9-4c26-aeaa-139414c9b7ea", 0, "86179727-43ed-4dcd-8a2e-861d32a29ef6", "ninosuanno@cumbrescaracas.edu.ve", false, "Suanno", false, null, "Joaquin", "NINOSUANNO@CUMBRESCARACAS.EDU.VE", "NINOSUANNO", null, null, false, "53588933-4467-449b-85ac-67313f566cf3", false, "ninosuanno" },
                    { "02647c30-606c-4e8a-8678-79a9a37b7717", 0, "6bc48026-8652-4a9b-a29d-5cfbd28f9104", "mdiaz@cumbrescaracas.edu.ve", false, "Diaz", false, null, "Maria Fernanda", "MDIAZ@CUMBRESCARACAS.EDU.VE", "MDIAZ", null, null, false, "331668d6-647b-407a-baf3-d3cb11920012", false, "mdiaz" },
                    { "02a8147c-b7de-4394-b893-e1637c148b66", 0, "0cdc6b3a-f8ad-4a9f-ad1e-9623df8762c8", "jgil@cumbrescaracas.edu.ve", false, "Gil", false, null, "Jesús Enrique", "JGIL@CUMBRESCARACAS.EDU.VE", "JGIL", null, null, false, "00503735-86fa-425e-b3f1-3c3b3d562935", false, "jgil" },
                    { "03321240-b795-4e01-8fd3-6460cd9e66bc", 0, "20568396-75cc-4435-94ea-1037510b1f65", "larellano@legionaries.org", false, "Arellano", false, null, "Leonardo", "LARELLANO", "LARELLANO@LEGIONARIES.ORG", null, null, false, "fd042e9d-3b76-4791-8071-d225665cd83d", false, "larellano" },
                    { "0665c0c2-efec-4bfb-b522-12ecbab71b9d", 0, "50e75dc5-79f7-46e4-b4cd-70b83a1708a8", "mramos@cumbrescaracas.edu.ve", false, "Ramos", false, null, "María", "MRAMOS@CUMBRESCARACAS.EDU.VE", "MRAMOS", null, null, false, "89e97ef9-0dfa-444d-ad69-acc100c5e850", false, "mramos" },
                    { "07597e88-568c-4e86-9f7c-fb7363e2aa83", 0, "3b483a00-ca91-47a3-888d-bb5b737a3644", "mvelasquez@cumbrescaracas.edu.ve", false, "Velásquez", false, null, "Perla Marina", "MVELASQUEZ@CUMBRESCARACAS.EDU.VE", "MVELASQUEZ", null, null, false, "e1ddb867-fa67-4e61-98d7-997481d03027", false, "mvelasquez" },
                    { "082c647a-27d5-43e7-b056-efc9abbe15ae", 0, "85036e87-41ea-4d80-91de-44e98ed51719", "melavalladares@gmail.com", false, "Valladares", false, null, "Melanie", "MELAVALLADARES@GMAIL.COM", "MELAVALLADARES", null, null, false, "356d3f93-c9ac-4bc8-ab18-cd1e2b0dcb67", false, "melavalladares" },
                    { "09742296-0830-41c3-937a-6aedb29d255f", 0, "2b6b4aac-97f8-4a08-9a6a-2d73c1840498", "azambrano@cumbrescaracas.edu.ve", false, "Zambrano", false, null, "Alexis", "AZAMBRANO@CUMBRESCARACAS.EDU.VE", "AZAMBRANO", null, null, false, "d2744dc4-3bcc-4c92-902c-40f3de36a4f5", false, "azambrano" },
                    { "0a7fe52c-fd72-47f8-acd0-2dc57e05f0a2", 0, "f7e8a331-976d-4a70-8a25-22b19a58da06", "cquintana@cumbrescaracas.edu.ve", false, "Quintana", false, null, "Carla", "CQUINTANA@CUMBRESCARACAS.EDU.VE", "CQUINTANA", null, null, false, "5639a2c8-9b18-47d8-9882-2355ee30dae8", false, "cquintana" },
                    { "0abb2bbd-fa6f-46b9-958f-cdc28d0063fc", 0, "a2de190f-0aa9-4b02-83d0-801131abba4c", "rgallo@cumbrescaracas.edu.ve", false, "Gallo", false, null, "Raffaela", "RGALLO@CUMBRESCARACAS.EDU.VE", "RGALLO", null, null, false, "cb902650-d631-4bde-aed8-70ff92763b03", false, "rgallo" },
                    { "0c234a54-68c0-4456-8916-402d1499c486", 0, "068412fe-fad2-4faa-993b-a512335cee48", "joserivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Jose", "JOSERIVAS@CUMBRESCARACAS.EDU.VE", "JOSERIVAS", null, null, false, "983d0b32-a5d6-4482-b738-75052c25fbdb", false, "joserivas" },
                    { "0f1ca1c5-9927-48e7-9a1f-063e573e84ac", 0, "2de172c8-db99-482c-a4bc-5ab104f67bcb", "acorton@cumbrescaracas.edu.ve", false, "Corton", false, null, "Andrea", "ACORTON@CUMBRESCARACAS.EDU.VE", "ACORTON", null, null, false, "027058c8-c45f-49a7-b1b7-eb3d66cff55f", false, "acorton" },
                    { "0f9e01b4-1436-4f32-813e-967491b33c6f", 0, "55c6553c-5a6a-4347-b52e-1a2a9b73e049", "ccano@cumbrescaracas.edu.ve", false, "Cano", false, null, "Cristina", "CCANO@CUMBRESCARACAS.EDU.VE", "CCANO", null, null, false, "bc9c0800-d996-4314-a332-80f7105746e0", false, "ccano" },
                    { "111bb45c-b7cc-43aa-94d9-732b4ea9e22c", 0, "02be8edf-0ab0-4b05-aecb-6138ae907018", "rofernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Rosmary", "ROFERNANDEZ@CUMBRESCARACAS.EDU.VE", "ROFERNANDEZ", null, null, false, "c154c05c-071b-49c6-9dc1-9a81adf80e4c", false, "rofernandez" },
                    { "114207cd-1739-49c3-adfe-39e5563bc73c", 0, "e870e20c-fde1-4fb2-ad62-eeebb074f436", "gcardas@cumbrescaracas.edu.ve", false, "Cardas", false, null, "Gwen", "GCARDAS@CUMBRESCARACAS.EDU.VE", "GCARDAS", null, null, false, "679e38ac-9a8e-49f1-b126-62d02ff7f278", false, "gcardas" },
                    { "1375152e-160c-428b-990b-2e5c23b53335", 0, "f1a4914d-5849-47d0-b95c-5421c29f4205", "msous@cumbrescaracas.edu.ve", false, "Sous", false, null, "Morela", "MSOUS@CUMBRESCARACAS.EDU.VE", "MSOUS", null, null, false, "472a667d-ae39-49e8-8586-fe42eedd2519", false, "msous" },
                    { "13a582aa-00fc-4c11-a839-d27512eaff9b", 0, "d33c9e00-2b50-4b72-9bd4-316502cb9f54", "sfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Solimar", "SFUENMAYOR@CUMBRESCARACAS.EDU.VE", "SFUENMAYOR", null, null, false, "1448b040-4825-41b9-afe7-fda1cfc50996", false, "sfuenmayor" },
                    { "14ddf29a-bbdb-4bcf-8b98-97f2162916a2", 0, "d6afd0cd-9433-422e-a9cb-f24cada22c1d", "mdjekki@cumbrescaracas.edu.ve", false, "Djekki", false, null, "Marianela", "MDJEKKI@CUMBRESCARACAS.EDU.VE", "MDJEKKI", null, null, false, "55561c6d-9836-464c-ad13-0f7c0e087821", false, "mdjekki" },
                    { "1bfec03d-3c3c-454c-aba7-d97781224c05", 0, "13a83419-8984-4c8d-ab46-7ff20204f0d2", "ccampos@cumbrescaracas.edu.ve", false, "Campos", false, null, "Carelia", "CCAMPOS@CUMBRESCARACAS.EDU.VE", "CCAMPOS", null, null, false, "1aa5df18-b5f7-4e2b-af8f-d86245d667eb", false, "ccampos" },
                    { "1c5eb507-e9d8-4522-be59-7c72b0c6db82", 0, "4ad99d23-4f9d-422b-a9cd-e0972df4c0e3", "rvgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Rossana", "RVGONZALEZ@CUMBRESCARACAS.EDU.VE", "RVGONZALEZ", null, null, false, "ff61125a-fa7f-46e7-af36-bac8663906c5", false, "rvgonzalez" },
                    { "2189bd04-51f6-4142-8e4d-46a23a8d4ca6", 0, "627231c5-c7cc-4c4f-941b-1140c13d3b4d", "btrias@cumbrescaracas.edu.ve", false, "Trias", false, null, "Beatriz", "BTRIAS@CUMBRESCARACAS.EDU.VE", "BTRIAS", null, null, false, "ddf125e1-b408-490a-80a5-32d3999a17fd", false, "btrias" },
                    { "222ea6af-9912-4b61-a720-11b54b0d2910", 0, "cb9c653b-9dfd-43b4-9b84-3536a57bfce5", "jmgutierrez@cumbrescracas.edu.ve", false, "Gutierrez", false, null, "José Manuel", "JMGUTIERREZ@CUMBRESCRACAS.EDU.VE", "JMGUTIERREZ", null, null, false, "f5a88b6e-926c-467c-a9e2-bc3582ca00ea", false, "jmgutierrez" },
                    { "24a3318c-5465-46fa-841e-c1de6ddc6287", 0, "44669f9d-61c8-412c-9ef1-13c087c0b3e4", "mariselayjorge@hotmail.com", false, "Rocha", false, null, "Marisela", "MARISELAYJORGE@HOTMAIL.COM", "MARISELAYJORGE", null, null, false, "8c241134-cca1-4598-956e-6c9996d2a8b6", false, "mariselayjorge" },
                    { "266f87e4-b456-49f6-a598-eec4d7925557", 0, "e9c3b008-47a9-4bca-8396-460c6760b803", "ldelgado@cumbrescaracas.edu.ve", false, "Delgado", false, null, "Leiza", "LDELGADO@CUMBRESCARACAS.EDU.VE", "LDELGADO", null, null, false, "b8c2d2cb-3f22-46d3-bb70-e53fae01b759", false, "ldelgado" },
                    { "2869145d-2c97-4f88-933b-7de10caed0ae", 0, "6ecee71e-beb3-4d59-b5b7-ab136fbfc8eb", "lrodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Luis Antonio", "LRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "LRODRIGUEZ", null, null, false, "09a81971-5c28-4b81-94b1-37ecdb3b0069", false, "lrodriguez" },
                    { "29936f60-7c5c-4035-82c4-fddbf0de1457", 0, "bc635523-6d28-4c09-b5ff-d9c29e8e9524", "igabaldon@cumbrescaracas.edu.ve", false, "De Gabaldon", false, null, "Isabel", "IGABALDON@CUMBRESCARACAS.EDU.VE", "IGABALDON", null, null, false, "befc07e0-626d-48f9-aa1b-26a6455bb34f", false, "igabaldon" },
                    { "2b864372-0ad0-4981-8959-ffcc6710e3af", 0, "bb617440-d95e-43bf-add8-4b5d776fd303", "mrivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Mariana", "MRIVAS@CUMBRESCARACAS.EDU.VE", "MRIVAS", null, null, false, "a6aa8f88-c2d4-451b-a874-20971b5f350e", false, "mrivas" },
                    { "30c2cbaf-ef63-4de9-a4be-9da7211bc25b", 0, "7e0c7cf5-eb6a-4a86-bc15-b772dc7df76b", "grando@cumbrescaracas.edu.ve", false, "Rando", false, null, "Gabriela", "GRANDO@CUMBRESCARACAS.EDU.VE", "GRANDO", null, null, false, "db041321-2c16-47a6-a951-8a84afb03209", false, "grando" },
                    { "3110adb2-8ada-413b-887c-996d903a2858", 0, "a7eb82e0-a55b-4178-912f-ab8c50dca083", "ablanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Andrés", "ABLANCO@CUMBRESCARACAS.EDU.VE", "ABLANCO", null, null, false, "14bb03b4-e694-42c8-92a5-e3b1d3cfd28a", false, "ablanco" },
                    { "324ba668-725e-46c9-8074-27205f1d60e6", 0, "23bf9bb7-7f6d-4343-af74-f0b2dd4f8d86", "aarmas@cumbrescaracas.edu.ve", false, "Armas De Hanna", false, null, "Anabell", "AARMAS@CUMBRESCARACAS.EDU.VE", "AARMAS", null, null, false, "c85b0ed3-c9c5-4a5e-8ef1-cb1b3ed3f91c", false, "aarmas" },
                    { "3263697f-290c-4934-9baa-fc0580021347", 0, "d68afff4-8f6e-479c-a6a6-354c04d39b3f", "lcasique@cumbrescaracas.edu.ve", false, "Casique", false, null, "Liliana", "LCASIQUE@CUMBRESCARACAS.EDU.VE", "LCASIQUE", null, null, false, "631c66d8-b395-4c84-8a32-a6bbec647dcc", false, "lcasique" },
                    { "376851ce-f811-46bb-b6aa-c373dce9d880", 0, "54ccef60-7c43-46f4-b9d4-abd63140aa65", "iluca@cumbrescaracas.edu.ve", false, "Luca", false, null, "Ivette", "ILUCA@CUMBRESCARACAS.EDU.VE", "ILUCA", null, null, false, "083e4943-61cf-4446-90b7-7e247872c44d", false, "iluca" },
                    { "37da35b7-6793-4494-ba47-f5f4c4971821", 0, "3eb94132-b6a2-4e8b-93f2-1b6303e3aaca", "amarzucco@cumbrescaracas.edu.ve", false, "Marzucco", false, null, "Alberto", "AMARZUCCO@CUMBRESCARACAS.EDU.VE", "AMARZUCCO", null, null, false, "66917997-eae0-457f-ae4c-21d4667ad29f", false, "amarzucco" },
                    { "37da7d13-1f0a-4b2e-8519-e27230356d62", 0, "2b5ee420-1b83-4185-b3d1-39b35f39811e", "ymoreira@cumbrescaracas.edu.ve", false, "Moreira", false, null, "Yenny", "YMOREIRA@CUMBRESCARACAS.EDU.VE", "YMOREIRA", null, null, false, "71cb0117-7e3d-4be6-be92-09cdce42ea34", false, "ymoreira" },
                    { "3a305fe3-acec-4d96-8169-629e2019f71e", 0, "0e0dc4c6-6e4b-4907-a1c4-737791c868ee", "ahenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Andrés", "AHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "AHENRIQUEZ", null, null, false, "62c047e2-f031-4aa8-86bd-681c5d8d4fdd", false, "ahenriquez" },
                    { "3b3a88c7-eaa9-4c84-9d26-d9f2000e20fc", 0, "e62b502b-4675-48a0-ba27-e10e008dfcc6", "gaguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Greysa", "GAGUILAR@CUMBRESCARACAS.EDU.VE", "GAGUILAR", null, null, false, "e72e50f4-7299-41bc-b86c-61c5716bcf4b", false, "gaguilar" },
                    { "3baab1da-b9c0-437f-804b-db9c5d29c3d6", 0, "2d2e6a5b-1ee9-455b-bb31-38b19f07afbe", "agalviz@cumbrescaracas.edu.ve", false, "Galviz", false, null, "Adrian", "AGALVIZ@CUMBRESCARACAS.EDU.VE", "AGALVIZ", null, null, false, "29f5076d-9a96-440f-9a77-fd8919c5d3e0", false, "agalviz" },
                    { "3e17d95f-e5dc-4b0f-8792-578fdf1094aa", 0, "72b28d44-c6b7-420d-a129-fe862320460f", "btogni@cumbrescaracas.edu.ve", false, "Togni", false, null, "Bruno", "BTOGNI@CUMBRESCARACAS.EDU.VE", "BTOGNI", null, null, false, "70dafee1-e888-4a08-bf8a-7340030694e8", false, "btogni" },
                    { "3f9f128d-b342-4c93-8a1f-474d86977971", 0, "2fb67bcb-3531-46bf-ab9c-bd59b081ed26", "mrocha@cumbrescaracas.edu.ve", false, "Vizcarrondo", false, null, "Marisela", "MROCHA@CUMBRESCARACAS.EDU.VE", "MROCHA", null, null, false, "c72228a3-4a2f-4d60-9dbc-3b0fc14c5f21", false, "mrocha" },
                    { "401c9f61-a8d5-4bf9-b421-ebb3961bce4d", 0, "ca36c008-29ff-4956-a9b1-e57ffd59ca06", "mperezr@cumbrescaracas.edu.ve", false, "Pérez", false, null, "Mayela", "MPEREZR@CUMBRESCARACAS.EDU.VE", "MPEREZR", null, null, false, "94e796fd-88f4-413a-ae24-a55277ad4e5d", false, "mperezr" },
                    { "4078857a-1c7e-4f0b-8421-e6200bb0d851", 0, "bbcfee97-b120-4d76-a09f-bd4ab2e483e1", "jduran@cumbrescaracas.edu.ve", false, "Duran", false, null, "Jeniffer", "JDURAN@CUMBRESCARACAS.EDU.VE", "JDURAN", null, null, false, "78f1ecc5-2262-4dba-afaa-c2e8d26776fe", false, "jduran" },
                    { "413553f1-9654-44c7-a431-a3e4028088fc", 0, "1d0ff7d3-e172-4df6-8676-4a10068339b2", "zrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Zamanta", "ZRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ZRODRIGUEZ", null, null, false, "3edeb7aa-5ec5-4a9b-a060-a32cfff3d3f3", false, "zrodriguez" },
                    { "41f2506c-916e-4383-b1ac-aa111356bf94", 0, "0b73f4c6-d9ce-4aa1-8c7e-d7f797bcbec7", "dgiuliani@cumbrescaracas.edu.ve", false, "Giuliani", false, null, "Donatina", "DGIULIANI@CUMBRESCARACAS.EDU.VE", "DGIULIANI", null, null, false, "1297c3b3-a287-4b14-b372-715c3af96f2a", false, "dgiuliani" },
                    { "43448a3a-8641-4420-a287-921f3bcef3ac", 0, "abc35db6-601a-440f-ac36-7c3f18f8dd85", "irangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Ignacio", "IRANGEL@CUMBRESCARACAS.EDU.VE", "IRANGEL", null, null, false, "b3056e06-fa5a-4074-80cc-ae49ab44f775", false, "irangel" },
                    { "434c434c-4342-43d4-a318-895fbc9cb077", 0, "c3f694bc-c89a-422c-ad36-43e97dd80746", "cdearmas@cumbrescaracas.edu.ve", false, "De Armas", false, null, "Cristina", "CDEARMAS@CUMBRESCARACAS.EDU.VE", "CDEARMAS", null, null, false, "57d67d36-2ac8-4d2d-bfde-d2e1e981b6c2", false, "cdearmas" },
                    { "46303737-ab73-43d5-bfce-35ad11d2c57e", 0, "a0e3932f-812e-4e79-b0e7-707ec33203d6", "earmas@cumbrescaracas.edu.ve", false, "Armas", false, null, "Edilbeck", "EARMAS", "EARMAS@CUMBRESCARACAS.EDU.VE", null, null, false, "da4d02bf-92e6-4834-bd79-91042f5efb67", false, "earmas" },
                    { "4b6866ef-53f3-4b7c-adbc-cf1d2deb6e1b", 0, "98d105a3-2e0b-4c50-a49d-5433bd19cb5a", "bperez@cumbrescaracas.edu.ve", false, "Perez", false, null, "Beatriz", "BPEREZ@CUMBRESCARACAS.EDU.VE", "BPEREZ", null, null, false, "557c78e5-d7a0-47a8-a5eb-37cabf9c1629", false, "bperez" },
                    { "4ba05419-cde4-46a3-8db3-1a40d4ecac54", 0, "9a0bf51b-f9bf-4fb6-b494-9b17868dac2e", "gcarvajal@cumbrescaracas.edu.ve", false, "Carvajal", false, null, "Gabriela", "GCARVAJAL@CUMBRESCARACAS.EDU.VE", "GCARVAJAL", null, null, false, "be18a5d4-bae6-4035-9d84-6b4705a8628e", false, "gcarvajal" },
                    { "4ba77339-b523-4526-9bf2-d595366d7689", 0, "0c927e84-acbc-44a0-ad75-5ff2116b5ec3", "rsirit@cumbrescaracas.edu.ve", false, "Sirit", false, null, "Ramon", "RSIRIT@CUMBRESCARACAS.EDU.VE", "RSIRIT", null, null, false, "3cd72ec1-08b8-465d-8f66-d75bcc1b50ca", false, "rsirit" },
                    { "4beb865d-5771-4a20-87bb-7bb86c564609", 0, "1f379290-966b-4ce7-ad45-3684daddf153", "mmata@arcol.org", false, "Mata De Mora", false, null, "María Carolina", "MMATA@ARCOL.ORG", "MMATA", null, null, false, "ba79a4cc-f048-4721-8594-f1d29db7f0ad", false, "mmata" },
                    { "4ec8d785-ba4c-49d6-9e9a-c5cf93f495cb", 0, "1a66398e-eb26-4ca1-85f8-3114e814fef8", "gadiaz@cumbrescaracas.edu.ve", false, "Díaz", false, null, "Guadalupe", "GADIAZ@CUMBRESCARACAS.EDU.VE", "GADIAZ", null, null, false, "61406fe1-bc71-4ffa-9dea-ba5b0e114668", false, "gadiaz" },
                    { "50811d39-604e-4556-a417-9e7c781de198", 0, "0804cbb9-5181-4968-8bf1-cb2bc941e609", "rpan@cumbrescaracas.edu.ve", false, "Dávila", false, null, "Rebeca", "RPAN@CUMBRESCARACAS.EDU.VE", "RPAN", null, null, false, "29720746-93d9-4bef-995a-5c89dc55c99d", false, "rpan" },
                    { "56a1c5f4-ecaa-43f7-b9cd-ae51a5d59df7", 0, "14df3bdb-3008-4882-bae3-46927efc026a", "mrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "María Corina", "MRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MRODRIGUEZ", null, null, false, "149a158d-400a-4684-93b3-4604ddfeaf24", false, "mrodriguez" },
                    { "5d07b3df-dd67-4913-90cf-1e5caca9eeeb", 0, "956df8c6-b69f-4a4e-b3f4-51208c235528", "mitriago@cumbrescaracas.edu.ve", false, "Itriago", false, null, "Marianna", "MITRIAGO@CUMBRESCARACAS.EDU.VE", "MITRIAGO", null, null, false, "3ec07c85-bcfd-446e-a9f7-ee73926f6cb8", false, "mitriago" },
                    { "5d35d8f1-abd6-464c-8d72-784cb00255b6", 0, "c770c172-5bcc-4f20-9aa9-89ce6780ea01", "jthimotheo@cumbrescaracas.edu.ve", false, "Thimotheo", false, null, "José Carlos", "JTHIMOTHEO@CUMBRESCARACAS.EDU.VE", "JTHIMOTHEO", null, null, false, "03f731f4-0efb-48dd-bd61-0e3dea462994", false, "jthimotheo" },
                    { "5dd0d0ca-f7e2-48f0-b5db-0921a076e76f", 0, "38eb87b8-ed9e-4cf4-9489-096ad02bb2b5", "pdaumy@losarcos.edu.ve", false, "Daumy", false, null, "Patricia", "PDAUMY@LOSARCOS.EDU.VE", "PDAUMY", null, null, false, "b0508a5a-c07d-4fdf-bf0f-75004b36c194", false, "pdaumy" },
                    { "5ee5e97e-af9e-4411-885d-41968e7fdd63", 0, "3360da9d-b734-42cf-94dc-5a57ad7b876b", "jgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Jesús", "JGARCIA@CUMBRESCARACAS.EDU.VE", "JGARCIA", null, null, false, "57cd751a-64f1-4631-aaf0-5f6b04623258", false, "jgarcia" },
                    { "617134da-7855-4050-8bf2-fe42a9fd15d9", 0, "b737d609-4657-47e1-9200-196cb5a011d0", "marismendi@cumbrescaracas.edu.ve", false, "Arismendi", false, null, "Martina", "MARISMENDI", "MARISMENDI@CUMBRESCARACAS.EDU.VE", null, null, false, "172a125b-9cff-414a-bab8-80f9ee62d230", false, "marismendi" },
                    { "656e9a40-5a33-4ad0-bb90-e687e8c5d4d6", 0, "71ec4684-1678-4d8a-88e8-44a3331aa25d", "ltavares@cumbrescaracas.edu.ve", false, "Tavares Goncalves", false, null, "Lisette", "LTAVARES@CUMBRESCARACAS.EDU.VE", "LTAVARES", null, null, false, "85b27456-f2e7-4afb-980e-b9771e7f44ef", false, "ltavares" },
                    { "658e9692-9dcc-4fc5-8519-e9074f515111", 0, "880cbd53-d5b2-4e3a-bbfe-cf8d2f5cb53a", "lurueta@cumbrescaracas.edu.ve", false, "Urueta", false, null, "Leonidas", "LURUETA@CUMBRESCARACAS.EDU.VE", "LURUETA", null, null, false, "1eaee50f-0514-480c-9d84-95482bc221f2", false, "lurueta" },
                    { "682ace87-d288-41b1-b638-0f9b31220e09", 0, "f7724ca4-9615-47ed-85e5-5fa78777ad58", "malcala@cumbrescaracas.edu.ve", false, "Alcala", false, null, "Melissa", "MALCALA@CUMBRESCARACAS.EDU.VE", "MALCALA", null, null, false, "e1f16a41-95b5-4a5b-874f-f95c4cb99d4a", false, "malcala" },
                    { "6a178dd6-9bb1-4bb7-a9bb-5e086c11a8b4", 0, "dc7b5e98-8525-4ab1-96d9-ad6886a783bc", "dperrucci@cumbrescaracas.edu.ve", false, "Perrucci Meló", false, null, "Daniela Alejandra", "DPERRUCCI@CUMBRESCARACAS.EDU.VE", "DPERRUCCI", null, null, false, "ca2bb5b8-8c3f-4e61-ab35-c5bbe507c603", false, "dperrucci" },
                    { "6a3696b1-c4e8-4afa-87b7-8867faada25d", 0, "27007030-5b13-43bd-b8d0-286b4a730f65", "mpenaranda@cumbrescaracas.edu.ve", false, "Peñaranda", false, null, "María Antonieta", "MPENARANDA@CUMBRESCARACAS.EDU.VE", "MPENARANDA", null, null, false, "ea9217d5-a4cf-4a7f-a9bd-fa7545ed824e", false, "mpenaranda" },
                    { "6c432447-01f0-4410-afaf-b13e10a2690f", 0, "5afff574-1511-49c2-b710-84f162d5a681", "pfernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Paula", "PFERNANDEZ@CUMBRESCARACAS.EDU.VE", "PFERNANDEZ", null, null, false, "ba948c39-2835-43ed-a73b-42f0b7385d89", false, "pfernandez" },
                    { "6ca06a40-a6b3-4a65-871e-8252c10738a8", 0, "f94c7818-4d0e-433b-8cbb-7b1fe149e407", "ilugo@cumbrescaracas.edu.ve", false, "Lugo Caravallo", false, null, "Ismael José", "ILUGO@CUMBRESCARACAS.EDU.VE", "ILUGO", null, null, false, "2ef0e2c9-d8b3-4c43-9ce3-68e0e1fd6788", false, "ilugo" },
                    { "723ef9ad-eafd-45d9-b002-e122120f923a", 0, "d5d4c1e7-7837-4ab2-8389-47a576928d2b", "cgomez@cumbrescaracas.edu.ve", false, "Gomez", false, null, "Carlos", "CGOMEZ@CUMBRESCARACAS.EDU.VE", "CGOMEZ", null, null, false, "55a4dce9-fd6d-4798-adca-b74f417a6865", false, "cgomez" },
                    { "72b3e4b6-75e5-4940-8012-2f5b2fe2129a", 0, "115a595c-d805-4430-a389-1bf770637bb8", "mcalzadilla@cumbrescaracas.edu.ve", false, "Calzadilla", false, null, "María Alejandra", "MCALZADILLA@CUMBRESCARACAS.EDU.VE", "MCALZADILLA", null, null, false, "163f7bed-e862-47a8-a0f5-15a27bd31036", false, "mcalzadilla" },
                    { "7534e7d1-66b6-4c56-ac3c-d17f05dffc8f", 0, "5ceeec53-1c7f-4823-aea9-7f21b53589f4", "dmata@cumbrescaracas.edu.ve", false, "Mata", false, null, "David", "DMATA@CUMBRESCARACAS.EDU.VE", "DMATA", null, null, false, "61a0fe87-29f7-4d1e-9d53-9eb032b7cccb", false, "dmata" },
                    { "7546f55e-4c1b-42e3-a051-5cc56711e852", 0, "297971ac-519d-4f03-a1c4-b491aa84716c", "imaurovich@cumbrescaracas.edu.ve", false, "Maurovich", false, null, "Isabel", "IMAUROVICH@CUMBRESCARACAS.EDU.VE", "IMAUROVICH", null, null, false, "15ba6783-cda8-47ee-a536-cd19ab3720e5", false, "imaurovich" },
                    { "75539053-3b8b-4c5a-a605-cc1ac4b5ea4c", 0, "dac246a4-61b7-41bd-9235-a12434da4c63", "kbrun@cumbrescaracas.edu.ve", false, "Brun", false, null, "Karina", "KBRUN@CUMBRESCARACAS.EDU.VE", "KBRUN", null, null, false, "fdea33e9-9557-42d7-ae04-5c2f73fc4101", false, "kbrun" },
                    { "75ae24ff-e4c8-4f2b-9d7f-13513a5b1d25", 0, "14e0098a-9636-42b6-9d09-c3ec79406152", "ysantaella@cumbrescaracas.edu.ve", false, "Santaella", false, null, "Yajaira", "YSANTAELLA@CUMBRESCARACAS.EDU.VE", "YSANTAELLA", null, null, false, "00edafbb-ade0-4af0-a99e-3a10ac28ff2b", false, "ysantaella" },
                    { "7a3fb832-e555-499f-b507-caaed0386591", 0, "b08d776b-da20-496e-a039-8c046c65fb06", "isabeldevillasmil@hotmail.com", false, "Bolinaga", false, null, "Isabel", "ISABELDEVILLASMIL@HOTMAIL.COM", "ISABELDEVILLASMIL", null, null, false, "22115aa0-66aa-4fd4-8a4c-efae6e6cb83d", false, "isabeldevillasmil" },
                    { "7b28da49-034b-4560-b099-cee65ae533eb", 0, "67a69ec6-5409-42fb-8067-be1d9f320084", "ebellorin@cumbrescaracas.edu.ve", false, "Bellorín", false, null, "Ezeangelly", "EBELLORIN@CUMBRESCARACAS.EDU.VE", "EBELLORIN", null, null, false, "9208fd57-b4cb-4126-a504-f0ffd156f40a", false, "ebellorin" },
                    { "7c484f84-9153-41cd-809c-0d84f2e442d4", 0, "fb9ab47d-e822-4f7f-87f1-b633adce59f9", "mgallardo@cumbrescaracas.edu.ve", false, "Benavides", false, null, "Luana", "MGALLARDO@CUMBRESCARACAS.EDU.VE", "MGALLARDO", null, null, false, "3e09bc3a-afc7-4eac-8095-4606e322f9bb", false, "mgallardo" },
                    { "7f0b8a4b-86da-4ef3-84a4-d91f14013373", 0, "408620ae-bf51-4646-bced-92ce919ecd1b", "gaortega@cumbrescaracas.edu.ve", false, "Ortega", false, null, "Gabriela", "GAORTEGA@CUMBRESCARACAS.EDU.VE", "GAORTEGA", null, null, false, "cfa88c1e-1f4a-499a-8b64-27c97b637753", false, "gaortega" },
                    { "7f6770cd-6792-4638-8c5c-4adec4e14e9a", 0, "b249d8ab-f26a-410c-855e-23313c1dddf7", "mestevez@cumbrescaracas.edu.ve", false, "Estévez", false, null, "María Graciela", "MESTEVEZ@CUMBRESCARACAS.EDU.VE", "MESTEVEZ", null, null, false, "62d4b445-56c9-47c5-9f35-7cad4ab957f2", false, "mestevez" },
                    { "7f6f34b3-89a4-41fa-a60d-f68e604023a5", 0, "a43cf782-2c2b-4049-a479-53aa3279a3c8", "tayling_steffany@hotmail.com", false, "Galindo", false, null, "Tayling", "TAYLING_STEFFANY@HOTMAIL.COM", "TAYLING_STEFFANY", null, null, false, "029b552d-832c-4f2e-a047-f6b15d3085ac", false, "tayling_steffany" },
                    { "7fa2cc44-3fcd-429b-8a5e-ae4fa172ef6f", 0, "1a34ade3-c828-49f2-8e2e-f730efef5db4", "jguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "Jessica", "JGUILLEN@CUMBRESCARACAS.EDU.VE", "JGUILLEN", null, null, false, "31f1c795-bc3e-4880-8a8d-6ae0cc9c8658", false, "jguillen" },
                    { "82bd29b0-0aac-433e-88f3-394ec86cfb72", 0, "0cf1e301-536c-4ea5-ad95-0a6019acefb0", "caguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Claudia", "CAGUILAR@CUMBRESCARACAS.EDU.VE", "CAGUILAR", null, null, false, "b1d87969-fcc7-49e4-99b9-1f1f15ea78e9", false, "caguilar" },
                    { "83e271ff-3cc1-4c2e-960e-d2563757f47c", 0, "08c4b19d-96a4-428f-9f6f-32242ddeefcd", "ecalvo@cumbrescaracas.edu.ve", false, "Calvo", false, null, "Esther", "ECALVO@CUMBRESCARACAS.EDU.VE", "ECALVO", null, null, false, "b11ed460-c35d-4631-b6e9-d109127b2d2e", false, "ecalvo" },
                    { "842456ed-a044-43cb-87b1-46af3edf74d9", 0, "15767dae-10ec-474a-a806-c060d2b90dc2", "carlosurdaneta@cumbrescaracas.edu.ve", false, "Urdaneta", false, null, "Carlos", "CARLOSURDANETA@CUMBRESCARACAS.EDU.VE", "CARLOSURDANETA", null, null, false, "30f0f9e9-b33f-4140-b509-0e59f26151b6", false, "carlosurdaneta" },
                    { "84a7bc54-c727-4a3b-9bc7-48ecac40ca1e", 0, "c1d89e0f-2eab-423b-b9fd-cd6933846a3e", "mrangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Marco Aurelio", "MRANGEL@CUMBRESCARACAS.EDU.VE", "MRANGEL", null, null, false, "28df2ba3-73c0-4de2-b257-4902aa04424a", false, "mrangel" },
                    { "8629e889-e1db-44f5-a080-bc1bd2b6aa59", 0, "313099af-516c-4b48-a990-eabfeffca2f7", "rsanchez@cumbrescaracas.edu.ve", false, "Sánchez", false, null, "Rosario", "RSANCHEZ@CUMBRESCARACAS.EDU.VE", "RSANCHEZ", null, null, false, "f421a310-40f6-436d-b39d-0427b651e097", false, "rsanchez" },
                    { "87df367a-f70b-4273-834d-3048f9601b2a", 0, "b2b1ec36-307f-4cc2-ad23-7986ec9d8087", "arojas@arcol.org", false, "Rojas", false, null, "Andy", "AROJAS@ARCOL.ORG", "AROJAS", null, null, false, "2923b34e-8360-45d4-867c-c4e56ab7177e", false, "arojas" },
                    { "8898b7af-251b-483a-9450-c14122869ee7", 0, "fdf376a2-7ab3-438d-be1e-86dcab059aab", "rdosreis@cumbrescaracas.edu.ve", false, "Dos Reis", false, null, "Rosa", "RDOSREIS@CUMBRESCARACAS.EDU.VE", "RDOSREIS", null, null, false, "8257f30a-36eb-4198-ab12-31d118047490", false, "rdosreis" },
                    { "8988dc8e-2ca3-4095-a116-0fe7d372f868", 0, "3a7d321c-6f64-4436-aea9-516d65b7930c", "rangeli@cumbrescaracas.edu.ve", false, "Rene", false, null, "Angeli", "RANGELI@CUMBRESCARACAS.EDU.VE", "RANGELI", null, null, false, "c979ce8d-3019-4526-abdb-9045250a4185", false, "rangeli" },
                    { "8aca38dd-ce64-4e31-993d-03d3f95b9d53", 0, "6b9c4a25-0967-4f70-8e5c-2f0997da471f", "vvinck@cumbrescaracas.edu.ve", false, "Vinck", false, null, "Vanessa", "VVINCK@CUMBRESCARACAS.EDU.VE", "VVINCK", null, null, false, "b4ec6d7f-44f1-4de7-b4d1-7d3128fe37c7", false, "vvinck" },
                    { "8bf3fb46-f3d9-4e72-b878-0df435cb5276", 0, "3ce2132b-72f8-4ce3-91a5-031c8bb7f109", "mfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Marianella", "MFUENMAYOR@CUMBRESCARACAS.EDU.VE", "MFUENMAYOR", null, null, false, "aa1ce17c-5628-43a4-a799-f9a960454962", false, "mfuenmayor" },
                    { "8ca8cf13-d210-4e47-be88-c27d17587df0", 0, "6ebfaa74-bb4c-4faa-9a15-940cf9b31822", "myanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Miguel Angel", "MYANEZ@CUMBRESCARACAS.EDU.VE", "MYANEZ", null, null, false, "2249c9e6-3ff2-48ec-88be-40c9459fc201", false, "myanez" },
                    { "8e14fe0d-2da9-4a9d-ada2-9693162a2746", 0, "c379d981-52f0-4396-a0af-2f166ca2babe", "javila@cumbrescaracas.edu.ve", false, "Avila", false, null, "Jhonny", "JAVILA@CUMBRESCARACAS.EDU.VE", "JAVILA", null, null, false, "7f85a1ff-4845-49d5-b1fc-24b68c40e657", false, "javila" },
                    { "8fd50914-b4aa-4cbb-ab37-c27e420368a4", 0, "f06349b4-c8bd-42f4-bed3-cba0170fd5cb", "kmoreno@cumbrescaracas.edu.ve", false, "Moreno", false, null, "Katherine", "KMORENO@CUMBRESCARACAS.EDU.VE", "KMORENO", null, null, false, "5a945a65-429b-490a-87b1-bf759e83ef7e", false, "kmoreno" },
                    { "92352ca4-ec51-4699-83cb-c3bc32414727", 0, "cd0d05c3-2dad-45b5-a145-341610a94259", "gsalas@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriel", "GSALAS@CUMBRESCARACAS.EDU.VE", "GSALAS", null, null, false, "40bf556d-f22a-4c90-91e3-4d488596d222", false, "gsalas" },
                    { "94fec75e-c6d2-46e9-ade8-4a514fa0ef8d", 0, "082fd1ba-bd06-4b99-b777-1877c939ff06", "leninbetancourt@yahoo.es", false, "Betancourt", false, null, "Lenin", "LENINBETANCOURT@YAHOO.ES", "LENINBETANCOURT", null, null, false, "05f6307b-e93c-4c0e-92b0-d20c15c18533", false, "leninbetancourt" },
                    { "964d6dcb-1ffe-42d9-b8e6-192b79dc25ff", 0, "e47742ea-7998-497a-a7ea-b4609fbdea9a", "mparra@cumbrescaracas.edu.ve", false, "Parra", false, null, "María Virginia", "MPARRA@CUMBRESCARACAS.EDU.VE", "MPARRA", null, null, false, "c517cb3e-da1b-4672-9cee-8f7213892a24", false, "mparra" },
                    { "98878a2f-fdb5-4e3f-9a01-ec12f5cd0ffa", 0, "2b4c7aa3-d8f6-4a80-b0b4-0b71a2353472", "jtoro@cumbrescaracas.edu.ve", false, "Toro", false, null, "Jorge", "JTORO@CUMBRESCARACAS.EDU.VE", "JTORO", null, null, false, "1930faf3-27f3-4bfc-b2f9-0d16d681821a", false, "jtoro" },
                    { "9c57ff9f-d004-4718-a2f0-89e3bd6d6c2d", 0, "b5b9d2b9-d78f-441e-a744-c507c8dd1f47", "sharrisson@cumbrescaracas.edu.ve", false, "Harrisson", false, null, "Selene", "SHARRISSON@CUMBRESCARACAS.EDU.VE", "SHARRISSON", null, null, false, "dd15f0bf-bece-4c45-a75a-4caabd48ffbf", false, "sharrisson" },
                    { "9e641172-42a9-46f1-bc1d-34b20af0ca1c", 0, "c3ed0461-5ab7-449e-9d54-0b624e1510ec", "maurodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Mauricio", "MAURODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MAURODRIGUEZ", null, null, false, "75197f21-5277-4f92-a6f5-cd29f0be4b4e", false, "maurodriguez" },
                    { "9f1532ab-b499-4871-9f31-b77bb1d2496c", 0, "9e7d08b0-7e4b-4ae9-b150-2d0292140e58", "drodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Daniella", "DRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "DRODRIGUEZ", null, null, false, "77c5bb3d-a649-477c-a354-deae342261e5", false, "drodriguez" },
                    { "a0e1cf59-ce3b-4b44-a5c7-4cff476ad891", 0, "32a32850-69af-4526-a05b-e5ff5e78b4f3", "mtrujillo@cumbrescaracas.edu.ve", false, "Trujillo", false, null, "María Elena", "MTRUJILLO@CUMBRESCARACAS.EDU.VE", "MTRUJILLO", null, null, false, "f74a7cf2-2f1e-4c0c-9681-eb46f8c3c85c", false, "mtrujillo" },
                    { "a0e2d637-e470-4a66-9334-dba6cc32230c", 0, "4acf1d37-9797-4ba6-a3a0-296ab910b145", "mtortosa@cumbrescaracas.edu.ve", false, "Tortosa", false, null, "Maria Gabriela", "MTORTOSA@CUMBRESCARACAS.EDU.VE", "MTORTOSA", null, null, false, "c7a18998-9917-4880-a237-0365babc93f5", false, "mtortosa" },
                    { "a53aaa82-615e-4a8d-8b57-93603c7c7df4", 0, "1d632d7a-0dea-4330-806b-e38b7db2b8b3", "dmoreau@cumbrescaracas.edu.ve", false, "Moreau", false, null, "Desiree", "DMOREAU@CUMBRESCARACAS.EDU.VE", "DMOREAU", null, null, false, "31126604-b602-467b-b7f7-225439e3d9ac", false, "dmoreau" },
                    { "a89ad547-8112-47bf-9a04-51f26e08a2bf", 0, "2637599f-78d1-4dbb-89ae-c762c1191d9f", "mmichelena@cumbrescaracas.edu.ve", false, "Michelena", false, null, "Mariana", "MMICHELENA@CUMBRESCARACAS.EDU.VE", "MMICHELENA", null, null, false, "1842c677-fb1d-43b4-a75d-bedd083ee5cb", false, "mmichelena" },
                    { "a9e1d5f9-1051-4cae-8699-19e151464e10", 0, "898383e5-61c4-49e3-9e22-a83ffc03c78c", "dbrando@cumbrescaracas.edu.ve", false, "Brando", false, null, "Daniel", "DBRANDO@CUMBRESCARACAS.EDU.VE", "DBRANDO", null, null, false, "413ed668-2763-4f51-8d82-41bd1d9d267c", false, "dbrando" },
                    { "acf014b1-fcc0-49a0-8fe8-fae0308c08d8", 0, "40a9c0d5-8f6a-471c-b7db-d47230e6bfb1", "avalderrama@cumbrescaracas.edu.ve", false, "Valderrama", false, null, "Andrea", "AVALDERRAMA@CUMBRESCARACAS.EDU.VE", "AVALDERRAMA", null, null, false, "850b80bd-893f-488c-8b01-958930d1e757", false, "avalderrama" },
                    { "aeb75f83-bd27-4cb6-95a8-fbb56bd50cd2", 0, "05bcbf7c-6ad5-4875-bf55-f8bb9dcfbe39", "jorodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "José Andrés", "JORODRIGUEZ@CUMBRESCARACAS.EDU.VE", "JORODRIGUEZ", null, null, false, "69320cad-1e47-4447-b9ed-085664508bd0", false, "jorodriguez" },
                    { "aee95dc9-0dc8-4e2c-94de-fb132576499e", 0, "f5c005ce-a71c-4c5b-a2f4-e941e089df05", "gbellorin@cumbrescaracas.edu.ve", false, "Bellorin", false, null, "Gilberto", "GBELLORIN@CUMBRESCARACAS.EDU.VE", "GBELLORIN", null, null, false, "04b1f4fb-a467-464e-bdc0-deb15c36fe0b", false, "gbellorin" },
                    { "afbb4203-f9f9-4e73-a874-58065a896955", 0, "9a55184d-6478-4d8c-bed3-10a44b2118ab", "syanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Simón", "SYANEZ@CUMBRESCARACAS.EDU.VE", "SYANEZ", null, null, false, "0f3ebbed-be10-4d21-acbd-95fed1b3e2fa", false, "syanez" },
                    { "afd89a2e-01aa-44b3-8447-f26512cd384f", 0, "493f36b1-a91e-4e76-b385-0435e8ddf262", "jmontilla@cumbrescaracas.edu.ve", false, "Montilla", false, null, "Juan Izquierdo", "JMONTILLA@CUMBRESCARACAS.EDU.VE", "JMONTILLA", null, null, false, "90736bc2-5541-4aa1-bb7e-2220fb7ed2b5", false, "jmontilla" },
                    { "b1c70722-cbee-482a-bd19-24871e1ef680", 0, "6bcd8683-ac2f-4140-97f3-c40a36b09300", "drondon@cumbrescaracas.edu.ve", false, "Rondon", false, null, "Dayana", "DRONDON@CUMBRESCARACAS.EDU.VE", "DRONDON", null, null, false, "6f5b4f97-61dd-49f1-bee9-340392ffc980", false, "drondon" },
                    { "b58854fa-4af6-41bf-ae16-e89154944028", 0, "59af5716-e47f-4199-b33c-330bd1238b73", "abedetti@cumbrescaracas.edu.ve", false, "Bedetti", false, null, "Alfredo", "ABEDETTI@CUMBRESCARACAS.EDU.VE", "ABEDETTI", null, null, false, "2ea25de5-b8a2-4261-97d1-d10a36dd9903", false, "abedetti" },
                    { "b6e1f189-7fa9-40b5-af1e-26f0245d2aa7", 0, "3a34e57a-02e5-46cc-b74a-975bd4730ff7", "cpadron@cumbrescaracas.edu.ve", false, "Chumbi", false, null, "Luis", "CPADRON@CUMBRESCARACAS.EDU.VE", "CPADRON", null, null, false, "49729a77-887b-491f-964f-c1eac24d5e8a", false, "cpadron" },
                    { "b7464cde-fc5b-46c7-9008-56cda7009b6e", 0, "5eb7f699-d836-4e7c-93d2-d4efbd8bdc76", "mmarquez@cumbrescaracas.edu.ve", false, "Márquez", false, null, "María Esperanza", "MMARQUEZ@CUMBRESCARACAS.EDU.VE", "MMARQUEZ", null, null, false, "9441083c-a0c0-41e1-9187-298dd87b1918", false, "mmarquez" },
                    { "b7b5dd3d-5858-431f-bb17-630982c56021", 0, "c2674035-1377-4ebf-9b1d-0bd7c8140766", "loumarangulo@gmail.com", false, "Angulo", false, null, "Verónica", "LOUMARANGULO@GMAIL.COM", "LOUMARANGULO", null, null, false, "72ebe8c0-1e9f-475d-b3c9-1d091f5c0fc5", false, "loumarangulo" },
                    { "b8286896-eb80-49bb-899a-891b2ab5be45", 0, "c1df9668-58ad-462c-96c2-d785c2dcf358", "clopez@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriela", "CLOPEZ@CUMBRESCARACAS.EDU.VE", "CLOPEZ", null, null, false, "654543ea-e400-4171-964c-22ef43a73e25", false, "clopez" },
                    { "b8f6b86f-f933-4330-834b-aa39d6c022a6", 0, "c937b722-7e4d-4d36-add6-751b26947229", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", "NADORNO@CUMBRESCARACAS.EDU.VE", "NADORNO", null, null, false, "c1fc48d9-f6f0-4361-babe-fe77ff80220a", false, "nadorno" },
                    { "bd27b004-2828-482d-956e-bd7bde8915e9", 0, "be316a46-4d13-4450-b4cf-fb37ea625886", "arodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Ana", "ARODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ARODRIGUEZ", null, null, false, "182ecc47-0171-4d20-9901-49ad774e0872", false, "arodriguez" },
                    { "bda37895-1654-4aa2-b3c6-a2b0f4e257a5", 0, "66b157a1-2311-4ce0-821d-af81cef88d95", "yoropeza@cumbrescaracas.edu.ve", false, "Oropeza", false, null, "Yndhira", "YOROPEZA@CUMBRESCARACAS.EDU.VE", "YOROPEZA", null, null, false, "5d14c5d7-6377-4c25-82e4-56be066ba4d6", false, "yoropeza" },
                    { "bdce0fad-94b8-4c41-bbea-b76f8c59bac4", 0, "c06fb4ec-58c0-4141-80db-64c7a794929e", "cnoguera@cumbrescaracas.edu.ve", false, "Noguera", false, null, "Carlos", "CNOGUERA@CUMBRESCARACAS.EDU.VE", "CNOGUERA", null, null, false, "7bee268e-9eea-4348-b3b0-123a347acd35", false, "cnoguera" },
                    { "bee9afdb-f112-4688-b567-89df1360df2f", 0, "86071243-3ac3-43ce-bb91-e98e4bef335d", "cadiaz@arcol.org", false, "Díaz", false, null, "Carolina", "CADIAZ@ARCOL.ORG", "CADIAZ", null, null, false, "c1c7c671-7968-4489-b2c2-c2115cc633c9", false, "cadiaz" },
                    { "befd6da0-5ec5-4be7-bc0e-8c14fa6b6360", 0, "bf1ed3b0-8061-4fa8-ae69-20ef26e2f4e2", "mariomanrique@cumbrescaracas.edu.ve", false, "Manrique", false, null, "Mario", "MARIOMANRIQUE@CUMBRESCARACAS.EDU.VE", "MARIOMANRIQUE", null, null, false, "cb2ad9d6-936a-4634-8455-87925ca575a7", false, "mariomanrique" },
                    { "bfaff99f-8c68-4071-9522-ec41d474326b", 0, "08f23b41-870e-4afd-a97e-414ee7b3cba3", "apinero@cumbrescaracas.edu.ve", false, "Piñero", false, null, "Adriana", "APINERO@CUMBRESCARACAS.EDU.VE", "APINERO", null, null, false, "824cc961-e80d-46aa-9bad-82f413fcfea5", false, "apinero" },
                    { "c05f7444-1a0c-4bec-884f-858aa4aef5f9", 0, "11620abd-5915-455a-8018-972c75a462a6", "kmarcano@cumbrescaracas.edu.ve", false, "Marcano", false, null, "Karina", "KMARCANO@CUMBRESCARACAS.EDU.VE", "KMARCANO", null, null, false, "126808ea-5020-4a2e-9077-2e74e1c3f8e2", false, "kmarcano" },
                    { "c11e1046-54ed-4190-82e6-97a4737edfe1", 0, "0aa09872-b4f1-4340-9e42-9807aca8b471", "ayepes@cumbrescaracas.edu.ve", false, "Machado", false, null, "Ana Teresa", "AYEPES@CUMBRESCARACAS.EDU.VE", "AYEPES", null, null, false, "8452abda-4992-4539-aea8-9a9c48674b20", false, "ayepes" },
                    { "c14b7c75-7484-4378-bb82-070ac4611c58", 0, "6c59caed-4a14-4c9c-8f66-39e2cba31599", "mcardona@cumbrescaracas.edu.ve", false, "Cardona", false, null, "Marisela", "MCARDONA@CUMBRESCARACAS.EDU.VE", "MCARDONA", null, null, false, "fcd72213-8ef4-4076-8638-0e9468d9c221", false, "mcardona" },
                    { "c4a227b5-be0e-4613-94ce-1ba644faecd2", 0, "177d07f6-047f-497d-8f24-1552b2fc48af", "mvillasmil@cumbrescaracas.edu.ve", false, "Villasmil", false, null, "María Gabriela", "MVILLASMIL@CUMBRESCARACAS.EDU.VE", "MVILLASMIL", null, null, false, "7aa5bad2-6aed-4b13-a73e-86f16de4dc12", false, "mvillasmil" },
                    { "c4d519c1-3e49-4e13-8fb4-c6ec30035864", 0, "8c2e323e-3b68-4e4b-9c35-caf23fa86ba3", "alovera@cumbrescarcas.edu.ve", false, "Lovera", false, null, "Adriana", "ALOVERA@CUMBRESCARCAS.EDU.VE", "ALOVERA", null, null, false, "0051d22a-b138-48e8-a4ca-eaeaca050f86", false, "alovera" },
                    { "c790c994-594d-4553-b416-6f1a3d0be31e", 0, "fa8167d1-52d2-4843-85ec-3256b972d707", "ibolivar@cumbrescaracas.edu.ve", false, "Bolívar", false, null, "Ivette", "IBOLIVAR@CUMBRESCARACAS.EDU.VE", "IBOLIVAR", null, null, false, "8a0e7e88-3896-4a4e-a2f6-7320de10c580", false, "ibolivar" },
                    { "c91cbec8-3d74-4f7c-9d79-f28d23b11654", 0, "77b1d33e-41db-4c56-8cbe-c1fe6c5a521e", "adipentima@cumbrescaracas.edu.ve", false, "Vona", false, null, "América", "ADIPENTIMA@CUMBRESCARACAS.EDU.VE", "ADIPENTIMA", null, null, false, "b92162c3-078f-4acb-880f-e572014ba17b", false, "adipentima" },
                    { "cb4cd43a-0320-4467-81b9-61cd1bcd5be2", 0, "2e5a078b-fe95-4664-a804-51d6af6feda3", "mnakhal@cumbrescaracas.edu.ve", false, "Nakhal Akel", false, null, "María Alejandra", "MNAKHAL@CUMBRESCARACAS.EDU.VE", "MNAKHAL", null, null, false, "f391b651-f3ce-412d-8dc2-7332acd7197b", false, "mnakhal" },
                    { "cbbc82c6-c9f6-486c-94fb-ff976fa48388", 0, "153bef5d-9ac2-4ea0-be8a-dc2f8e940e90", "mguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "María Fernanda", "MGUILLEN@CUMBRESCARACAS.EDU.VE", "MGUILLEN", null, null, false, "70933cab-db57-405f-8125-3cfca77d3cb8", false, "mguillen" },
                    { "cd4e1c11-1efb-46b0-8e6d-0562bd49c4ae", 0, "9c3fe46c-da17-4e00-9ff5-d286721526f5", "pparis@cumbrescaracas.edu.ve", false, "Paris", false, null, "Pedro", "PPARIS@CUMBRESCARACAS.EDU.VE", "PPARIS", null, null, false, "f1d05787-5dff-478f-8880-b92d0c603b85", false, "pparis" },
                    { "ce1ffafb-b584-4585-a9ed-4b602796c7ff", 0, "311d483b-6d7e-40ae-9efc-96b02403451b", "nmagdaleno@cumbrescaracas.edu.ve", false, "Magdaleno", false, null, "Nancy", "NMAGDALENO@CUMBRESCARACAS.EDU.VE", "NMAGDALENO", null, null, false, "f52d73b3-a593-4529-95cf-f116d4988f90", false, "nmagdaleno" },
                    { "cea81e80-a5ca-4cc2-914e-846654d58fbb", 0, "3a87a202-09d2-40dc-acbf-6429cd9ce208", "mrecchiuti@cumbrescaracas.edu.ve", false, "Recchiuti", false, null, "Mauricio", "MRECCHIUTI@CUMBRESCARACAS.EDU.VE", "MRECCHIUTI", null, null, false, "489e605f-4324-441c-8b64-ddd7f222b2ca", false, "mrecchiuti" },
                    { "d13b885f-dd1b-4478-b7f5-60b5be3b07d2", 0, "1b9fd7cd-1704-492c-ac25-9653af73888d", "yarrayago@cumbrescaracas.edu.ve", false, "Arrayago", false, null, "Yldith", "YARRAYAGO@CUMBRESCARACAS.EDU.VE", "YARRAYAGO", null, null, false, "7c4b0ac2-9728-4fa7-917e-82308c2c00cd", false, "yarrayago" },
                    { "d1ba4efe-b78c-48c1-b3c7-acbe684179dd", 0, "36ef9a6a-a93b-4209-b68b-76bdc421fd06", "mcastro@cumbrescaracas.edu.ve", false, "Castro", false, null, "Mariela", "MCASTRO@CUMBRESCARACAS.EDU.VE", "MCASTRO", null, null, false, "fd0f41e4-8181-485c-aeee-647aba701a39", false, "mcastro" },
                    { "d35a8b49-cbb1-4cd2-96e6-f0254827a0da", 0, "fb88063b-ddbf-41f9-82ee-c93a8465a9e0", "jcaraballo@cumbrescaracas.edu.ve", false, "Caraballo", false, null, "José", "JCARABALLO@CUMBRESCARACAS.EDU.VE", "JCARABALLO", null, null, false, "4917d7f9-8b12-4023-ab43-228e9989e22a", false, "jcaraballo" },
                    { "d41e377b-00e9-4e77-827e-85e84a6973d4", 0, "98e1d082-403b-4a30-a61d-81d982213462", "yardila@cumbrescaracas.edu.ve", false, "Ardila", false, null, "Yuleima", "YARDILA@CUMBRESCARACAS.EDU.VE", "YARDILA", null, null, false, "c11ccb86-9a2f-47ec-bbba-cfc59d8a3655", false, "yardila" },
                    { "d66abaee-cee9-458a-ac8b-e5c04b77537b", 0, "98c6be03-3145-4ee8-93eb-0be20d9a4018", "csuarez@cumbrescaracas.edu.ve", false, "Suárez", false, null, "César", "CSUAREZ@CUMBRESCARACAS.EDU.VE", "CSUAREZ", null, null, false, "a61e4e5c-2848-412c-91ea-19558dc40f42", false, "csuarez" },
                    { "d6755504-7bbf-4fb7-94f6-46331538e12e", 0, "a2ca1049-0290-4c27-83c0-8df8fbfc6888", "gandara@cumbrescaracas.edu.ve", false, "Andara", false, null, "German", "GANDARA@CUMBRESCARACAS.EDU.VE", "GANDARA", null, null, false, "b638dde7-f894-4bc7-8143-8ae36a2dc668", false, "gandara" },
                    { "d6907158-088d-4e5e-9f64-65d933aa9417", 0, "4e8ef93d-d7ed-484d-b04c-057975725c76", "arguerra@cumbrescaracas.edu.ve", false, "Guerra", false, null, "Arminda", "ARGUERRA@CUMBRESCARACAS.EDU.VE", "ARGUERRA", null, null, false, "df6246e6-a7d2-4ac1-9d2f-e457eab70d2d", false, "arguerra" },
                    { "d767c6c4-f175-4c24-a7ea-2168dd9e2954", 0, "f2498b18-4265-4800-b532-d8b6133da3f7", "cchacon@cumbrescaracas.edu.ve", false, "Chacón", false, null, "Claudia", "CCHACON@CUMBRESCARACAS.EDU.VE", "CCHACON", null, null, false, "59a6dc6c-6c9a-4b9a-b37d-12295570ea0a", false, "cchacon" },
                    { "d905fadd-7017-486a-bb9e-371d3a3eb936", 0, "ee390fed-37d6-40a0-aed9-665d6c7c7f34", "rescobar@arcol.org", false, "Escobar", false, null, "Ricky", "RESCOBAR@ARCOL.ORG", "RESCOBAR", null, null, false, "e6e9b36d-9864-437d-8e73-6979db90d1e4", false, "rescobar" },
                    { "da6f4eae-2e6f-48be-9653-8f9b43e8bef5", 0, "38e7a9d2-fe40-47fe-b292-aa491420975e", "legutierrez@cumbrescaracas.edu.ve", false, "Gutiérrez", false, null, "Leonardo", "LEGUTIERREZ@CUMBRESCARACAS.EDU.VE", "LEGUTIERREZ", null, null, false, "5443409e-5c98-46c1-bb7d-a259afab32ce", false, "legutierrez" },
                    { "da8fca05-e870-40d2-990a-0cf36f702dfb", 0, "973273ec-045c-4384-aff5-15df7ca8f56c", "rpunceles@cumbrescaracas.edu.ve", false, "Punceles", false, null, "Rafael", "RPUNCELES@CUMBRESCARACAS.EDU.VE", "RPUNCELES", null, null, false, "11f004c0-948b-44ef-8610-90d5f7ef5e85", false, "rpunceles" },
                    { "dad83dfa-42a0-454d-9897-5273567b1afa", 0, "5b1d6b2d-4d85-4c6a-9232-861ac570bcb0", "aortuno@cumbrescaracas.edu.ve", false, "Ortuño", false, null, "Andreulys", "AORTUNO@CUMBRESCARACAS.EDU.VE", "AORTUNO", null, null, false, "c03ce7b1-2283-4862-83b7-02f40a20e6fc", false, "aortuno" },
                    { "dc247dd0-6cd2-4789-af5e-e0f1461325ed", 0, "f2e87e54-d1c9-47da-a8c6-2d25087c00e8", "amgarcia@legionaries.org", false, "García", false, null, "Alvaro", "AMGARCIA@LEGIONARIES.ORG", "AMGARCIA", null, null, false, "60bfac32-7914-44a5-afa4-fd0aa8d70289", false, "amgarcia" },
                    { "dd39f1f6-acaa-4ad5-bb6a-c80f236b482a", 0, "2ccc6cba-563a-4482-959c-4d209925da90", "jaleman@cumbrescaracas.edu.ve", false, "Alemán", false, null, "José Antonio", "JALEMAN@CUMBRESCARACAS.EDU.VE", "JALEMAN", null, null, false, "e5293f49-a6e8-4029-a64d-f0b94606683e", false, "jaleman" },
                    { "dde2f29e-05cf-4e19-88ca-b32fb8db9b43", 0, "b0aa65d9-c854-49aa-9d60-4a2a2c6ae7b3", "grodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Guida", "GRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "GRODRIGUEZ", null, null, false, "870294e1-5772-4b57-ad8f-bfd02fabcb47", false, "grodriguez" },
                    { "e0e2debc-2812-4f8e-a9cf-6559790648d2", 0, "53fc2284-6072-4976-9735-8ba8ecd63ad9", "mgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Mariana", "MGONZALEZ@CUMBRESCARACAS.EDU.VE", "MGONZALEZ", null, null, false, "416b9759-9aa7-4055-bdb0-65dc2e63824f", false, "mgonzalez" },
                    { "e32776a0-0a1c-44cf-ad19-cc0f52c0aa51", 0, "6236e277-5720-4b81-afaf-985ecbee52cd", "imejias@cumbrescaracas.edu.ve", false, "Mejias", false, null, "Iliana", "IMEJIAS@CUMBRESCARACAS.EDU.VE", "IMEJIAS", null, null, false, "1f70bc1b-42a5-4763-9d22-705decab962d", false, "imejias" },
                    { "e3b4b91f-295e-4f74-af70-a38055e2a2c0", 0, "09aef946-3582-46ce-8ca1-11879791e2f5", "tgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Teresita", "TGARCIA@CUMBRESCARACAS.EDU.VE", "TGARCIA", null, null, false, "54667960-42da-4c40-8387-cb2dbd104572", false, "tgarcia" },
                    { "e4399e3a-772c-474f-b465-a59198905ce6", 0, "e5757f95-5e5c-4060-9616-54c2735a847e", "chenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Carlos", "CHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "CHENRIQUEZ", null, null, false, "71a6b4ce-ec08-4bb3-a77c-cd6f7d4b4d70", false, "chenriquez" },
                    { "e5131635-fa26-41dc-8c4b-78ccde532c9a", 0, "79e9cdf1-df37-4c7f-a0ab-df5544a7950a", "blosada@cumbrescaracas.edu.ve", false, "Losada", false, null, "Beatriz", "BLOSADA@CUMBRESCARACAS.EDU.VE", "BLOSADA", null, null, false, "da76f20a-9695-404f-8849-a160274ec7f0", false, "blosada" },
                    { "e5fb6e76-f0f2-48d9-abe7-e6711639ad67", 0, "088033e7-af41-434c-9c0e-d22a33b5bf8f", "avivas@cumbrescaracas.edu.ve", false, "Vivas", false, null, "Alejandra", "AVIVAS@CUMBRESCARACAS.EDU.VE", "AVIVAS", null, null, false, "2656c9be-5bb0-4215-8df1-de0f67689c97", false, "avivas" },
                    { "eb36ea6c-93d9-4776-af56-a784d5e55e1a", 0, "21b8e34b-32b9-4dac-a768-9c5d769098d5", "dlucero@cumbrescaracas.edu.ve", false, "Lucero", false, null, "Deyvi", "DLUCERO@CUMBRESCARACAS.EDU.VE", "DLUCERO", null, null, false, "e0a92d6e-153f-4de4-a3c4-f39b31438848", false, "dlucero" },
                    { "eb98e6c6-1bf4-44c1-98cb-fc42309dab30", 0, "299901c5-3077-4321-98b7-c962f2eb9093", "mcapuz@cumbrescaracas.edu.ve", false, "Capuz", false, null, "Marycel", "MCAPUZ@CUMBRESCARACAS.EDU.VE", "MCAPUZ", null, null, false, "ced3b572-f11a-4c4a-bcc8-11e103ba0ad1", false, "mcapuz" },
                    { "ebd1ac18-ed3a-4f9b-b462-34e3aaf0d265", 0, "474d87d6-7b5c-46ee-b43d-77eaf74337ea", "dnava@cumbrescaracas.edu.ve", false, "Nava", false, null, "Dayhan", "DNAVA@CUMBRESCARACAS.EDU.VE", "DNAVA", null, null, false, "4bc464ae-5bab-4e75-b187-7f2710fd78d9", false, "dnava" },
                    { "ec3081d3-5d97-440f-9cc4-3ce887d8783a", 0, "dc0d89d3-0f3c-4a5a-8202-ea10ba19a3d8", "iavendano@cumbrescaracas.edu.ve", false, "Avendaño", false, null, "Ivana", "IAVENDANO@CUMBRESCARACAS.EDU.VE", "IAVENDANO", null, null, false, "1c99beb4-fa50-4db8-a41e-99dfe873413b", false, "iavendano" },
                    { "ee2c3208-f242-41ce-8d6d-48cf5fc42dc5", 0, "8c5c62ba-d5ba-43ba-b3e5-c2996996d841", "afeola@cumbrescaracas.edu.ve", false, "Feola Carrasquel", false, null, "Alfonso Eloy", "AFEOLA@CUMBRESCARACAS.EDU.VE", "AFEOLA", null, null, false, "e689a8b7-1578-4852-b075-90b770b50d60", false, "afeola" },
                    { "f3014d97-dae5-4276-95aa-b0a9036c8200", 0, "c40995ae-b740-4215-8a09-cf453768fb45", "jmarti@legionaries.org", false, "Martí", false, null, "Julio César", "JMARTI@LEGIONARIES.ORG", "JMARTI", null, null, false, "8642c5dd-eadf-4c2d-b422-2500c94a64ab", false, "jmarti" },
                    { "f5a76d91-f23d-4875-bf1c-bb3f2c83aacf", 0, "ed8de17e-3f61-41bc-aa21-68eac965ea17", "mhernandez@cumbrescaracas.edu.ve", false, "Hernandez", false, null, "Monica", "MHERNANDEZ@CUMBRESCARACAS.EDU.VE", "MHERNANDEZ", null, null, false, "a9e48a7a-528c-4a7d-88fd-09615721f4d5", false, "mhernandez" },
                    { "f7c91fc4-4027-457c-80c8-b98c8c65cd4f", 0, "d4735607-2ef9-4066-aa9e-f992d72f39a9", "lmesa@cumbrescaracas.edu.ve", false, "Mesa", false, null, "Luisa", "LMESA@CUMBRESCARACAS.EDU.VE", "LMESA", null, null, false, "1ab656de-e90e-4e4c-8f4c-09b9c847f3c3", false, "lmesa" },
                    { "f7deca39-3cd2-49cd-ace0-d9d54f16cc87", 0, "37944620-a008-43bc-8cd0-2bd3847b1a42", "dsossa@legionaries.org", false, "Sossa", false, null, "Daniel", "DSOSSA@LEGIONARIES.ORG", "DSOSSA", null, null, false, "12fa1fff-f2bc-41c0-9287-08340b3e336e", false, "dsossa" },
                    { "f8c15b81-ba30-4438-831f-0982558a5bc6", 0, "239aa34c-200a-4d37-b2fe-c319c5c5f5b9", "lperezcastilla@legionaries.org", false, "Perez Castilla", false, null, "Leonardo", "LPEREZCASTILLA@LEGIONARIES.ORG", "LPEREZCASTILLA", null, null, false, "1d6a05ff-8561-48de-8f01-a420e955d110", false, "lperezcastilla" },
                    { "f9379f3d-16a2-4482-acd5-7e5311fa437f", 0, "4da27fed-2afe-4186-a622-6e23be1b387b", "cchirinos@cumbrescaracas.edu.ve", false, "Chirinos", false, null, "Christian", "CCHIRINOS@CUMBRESCARACAS.EDU.VE", "CCHIRINOS", null, null, false, "d0b9652f-d607-48f8-afb9-75e4079858ae", false, "cchirinos" },
                    { "fa40c0bb-b62a-4c56-bc1d-89ed42f6fe0c", 0, "2e6507c4-11d7-4997-8e89-d107a0fdff05", "jumarmol@cumbrescaracas.edu.ve", false, "Mármol", false, null, "Juliana", "JUMARMOL@CUMBRESCARACAS.EDU.VE", "JUMARMOL", null, null, false, "10bf445e-d7f0-460c-9e38-6fbc6a16b09a", false, "jumarmol" },
                    { "fb76b393-c402-4cfd-bdfd-7a3601152682", 0, "318cb980-80f9-4cda-b753-8332a1ada2e9", "wteran@cumbrescaracas.edu.ve", false, "Terán", false, null, "Wilmer", "WTERAN@CUMBRESCARACAS.EDU.VE", "WTERAN", null, null, false, "09c121e7-2005-4a39-9bb0-363fe293ce9f", false, "wteran" },
                    { "fd944563-1796-400c-8c0d-648a9badc78f", 0, "5c2eba3f-8130-4081-9971-e18bbcc13d71", "lduquem@cumbrescaracas.edu.ve", false, "Duque", false, null, "Lilibeth", "LDUQUEM@CUMBRESCARACAS.EDU.VE", "LDUQUEM", null, null, false, "76f235ff-23e3-4b54-ae24-d666cb4c1bb1", false, "lduquem" },
                    { "fef18384-8b15-44eb-80fa-e53a6cd5b04b", 0, "d1eb6109-c9f8-44ae-8461-4aab643e573c", "jblanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Jorge", "JBLANCO@CUMBRESCARACAS.EDU.VE", "JBLANCO", null, null, false, "a9c12333-1495-43d8-8bdd-12598920a7aa", false, "jblanco" },
                    { "ffa5a3d7-2030-4b45-bbab-0b931737c3cb", 0, "eede695c-3b6c-4db8-9092-c969185465c6", "dmarval@cumbrescaracas.edu.ve", false, "Marval", false, null, "Diego", "DMARVAL@CUMBRESCARACAS.EDU.VE", "DMARVAL", null, null, false, "e4cad68e-ea7b-4961-9187-37ee1e975c9b", false, "dmarval" },
                    { "fff912e9-a51d-4824-89a5-137a3655a9fa", 0, "494f1096-c350-4171-b472-c154addb2a0d", "julieta.elena.rivas@gmail.com", false, "Rivas", false, null, "Julieta", "JULIETA.ELENA.RIVAS@GMAIL.COM", "JULIETA.ELENA.RIVAS", null, null, false, "3ba7188b-eb7e-44c1-8703-eac16458534e", false, "julieta.elena.rivas" }
                });

            migrationBuilder.InsertData(
                table: "Dispositivos",
                columns: new[] { "ID", "LastUpdatedByID", "LastUpdatedOn", "Marca", "Modelo", "Observacion", "Serial", "Status", "Tipo", "Ubicacion", "Uso" },
                values: new object[,]
                {
                    { 1, null, null, "DELL", "X1", "TEST DEVICE", "345VEG", 1, "Laptop", "TEST UBICACIÓN", "TEST USO" },
                    { 2, null, null, "ACER", "T3", "TEST DEVICE", "NFG456", 1, "Laptop", "TEST UBICACIÓN", "TEST USO" },
                    { 3, null, null, "ASUS", "D4", "TEST DEVICE", "BRI456", 1, "Laptop", "TEST UBICACIÓN", "TEST USO" },
                    { 4, null, null, "HP", "S6", "TEST DEVICE", "NWO203", 1, "Laptop", "TEST UBICACIÓN", "TEST USO" },
                    { 5, null, null, "SAMSUNG", "S3", "TEST DEVICE", "0K7B6F", 1, "Tablet", "TEST UBICACIÓN", "TEST USO" },
                    { 6, null, null, "SAMSUNG", "S2", "TEST DEVICE", "1K2J3H", 1, "Tablet", "TEST UBICACIÓN", "TEST USO" },
                    { 7, null, null, "HUAWEI", "TRX3", "TEST DEVICE", "4J8FC7", 1, "Tablet", "TEST UBICACIÓN", "TEST USO" },
                    { 8, null, null, "HUAWEI", "34RF", "TEST DEVICE", "2MN3B4", 1, "Tablet", "TEST UBICACIÓN", "TEST USO" },
                    { 9, null, null, "KINGSTON", "CVT4", "TEST DEVICE", "PLO094", 1, "Cable", "TEST UBICACIÓN", "TEST USO" },
                    { 10, null, null, "KINGSTON", "GTR3", "TEST DEVICE", "CYD837", 1, "Cable", "TEST UBICACIÓN", "TEST USO" },
                    { 11, null, null, "Epson", "PowerLite S18+", "Buenas condiciones. Moderno (HDMI USB)", "TVAK4904105", 1, "Proyector", "Depósito", "Móvil" },
                    { 12, null, null, "Epson", "PowerLite S12+", "Buenas condiciones. Lámpara con potencia 64 H", "PSPK2407501", 1, "Proyector", "Depósito", "Móvil" },
                    { 13, null, null, "Epson", "PowerLite S12+", "Buenas condiciones. Lámpara con potencia 344 H", "PSPK2412010", 1, "Proyector", "Oficina José Rivas", "Móvil" },
                    { 14, null, null, "InFocus", "IN26+", "Regular condiciones. Lámpara con baja potencia 2850 H", "AVFC73900421", 1, "Proyector", "Sala Didáctica de Primaria (Lab. Computación)", "Fijo" },
                    { 15, null, null, "InFocus", "IN112A", "Regular condiciones. Lámpara con potencia 1051H", "BMYB44404905", 1, "Proyector", "Sala Didáctica de Bachillerato (Lab. Computación)", "Fijo" },
                    { 16, null, null, "InFocus", "DESCONOCIDO", "Regular condiciones. Lámpara con baja potencia 2850 H", "DESCONOCIDO", 1, "Proyector", "Oficina José Alemán", "Móvil" },
                    { 17, null, null, "Epson", "DESCONOCIDO", "Regular condiciones. Lámpara con potencia 899 H", "00062667LE", 1, "Proyector", "Sala Multimedia al lado Sala Didáctica de Primaria (Lab. Computación)", "Fijo" },
                    { 18, null, null, "InFocus", "DESCONOCIDO", "Regular condiciones. Lámpara con baja potencia 2553 H", "IN112A", 1, "Proyector", "Auditorio", "Fijo" }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "ID", "HoraFin", "HoraInicio", "Nivel", "Nombre" },
                values: new object[,]
                {
                    { 1, "08:15:00", "07:30:00", "HS", "Primera Hora" },
                    { 2, "09:00:00", "08:15:00", "HS", "Segunda Hora" },
                    { 3, "10:30:00", "09:45:00", "HS", "Tercera Hora" },
                    { 4, "11:15:00", "10:30:00", "HS", "Cuarta Hora" },
                    { 5, "12:00:00", "11:15:00", "HS", "Quinta Hora" },
                    { 6, "13:15:00", "12:30:00", "HS", "Sexta Hora" },
                    { 7, "14:00:00", "13:15:00", "HS", "Séptima Hora" },
                    { 8, "09:00:00", "08:15:00", "MS", "Primera Hora" },
                    { 9, "09:45:00", "09:00:00", "MS", "Segunda Hora" },
                    { 10, "11:15:00", "10:30:00", "MS", "Tercera Hora" },
                    { 11, "12:00:00", "11:15:00", "MS", "Cuarta Hora" },
                    { 12, "12:55:00", "12:10:00", "MS", "Quinta Hora" },
                    { 13, "13:40:00", "12:55:00", "MS", "Sexta Hora" },
                    { 14, "09:40:00", "08:50:00", "UE", "Primera Hora" },
                    { 15, "10:30:00", "09:40:00", "UE", "Segunda Hora" },
                    { 16, "12:00:00", "11:15:00", "UE", "Tercera Hora" },
                    { 17, "12:45:00", "12:00:00", "UE", "Cuarta Hora" },
                    { 18, "13:50:00", "13:05:00", "UE", "Quinta Hora" },
                    { 19, "14:35:00", "13:50:00", "UE", "Sexta Hora" },
                    { 20, "09:40:00", "08:50:00", "LE", "Primera Hora" },
                    { 21, "10:30:00", "09:40:00", "LE", "Segunda Hora" },
                    { 22, "11:15:00", "10:30:00", "LE", "Tercera Hora" },
                    { 23, "12:45:00", "12:00:00", "LE", "Cuarta Hora" },
                    { 24, "13:30:00", "12:45:00", "LE", "Quinta Hora" },
                    { 25, "14:35:00", "13:50:00", "LE", "Sexta Hora" }
                });

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

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "ID", "Codigo", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { 1, 1, "El requerimiento ha sido creado y espera ser procesado.", "Pendiente" },
                    { 2, 2, "El requerimiento ha sido tomado y se encuentra en proceso de ser gestionado.", "En proceso" },
                    { 3, 3, "El requerimiento ha sido procesado y completado.", "Completado" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HorarioReserva_HorarioID",
                table: "HorarioReserva",
                column: "HorarioID");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioReserva_MateriasID",
                table: "HorarioReserva",
                column: "MateriasID");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioReserva_ReservaID",
                table: "HorarioReserva",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaDispositivo_DispositivoID",
                table: "ReservaDispositivo",
                column: "DispositivoID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaDispositivo_ReservaID",
                table: "ReservaDispositivo",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_InstalacionID",
                table: "Reservas",
                column: "InstalacionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UserID",
                table: "Reservas",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_StatusReserva_ReservaID",
                table: "StatusReserva",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_StatusReserva_StatusID",
                table: "StatusReserva",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HorarioReserva");

            migrationBuilder.DropTable(
                name: "ReservaDispositivo");

            migrationBuilder.DropTable(
                name: "StatusReserva");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Dispositivos");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Instalaciones");
        }
    }
}
