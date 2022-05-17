using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class isolateMateria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_AspNetUsers_UserID",
                table: "Clases");

            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Materias_MateriaID",
                table: "Clases");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clases_ClaseID",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ClaseID",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Clases_UserID",
                table: "Clases");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04c5318c-d89d-4d43-9e09-7bbb3479a727");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05c03e19-15da-4a89-ac1b-8e25aa8c9883");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07ccd2b2-9728-4408-b720-d59594c39b74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163bcc38-8582-42ae-ab6c-4f41d0100295");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1760af59-3ad8-4ada-9432-54f1bfa31e43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "179e99fe-efe1-4760-ab1e-c4fa9a94b3ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18532745-82d6-479b-a2cf-dd280af13368");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1aa6e31c-262f-422f-9921-75bad7e65f34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d91b3d6-7103-43c3-88d4-36376ab18b6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dea203c-72eb-4481-a5d7-44e5539a41b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fd5f3a8-6aee-41ed-a6a5-ef7059eba083");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21101e42-2173-4e17-8cdc-db7c182d6869");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217a8633-e6f0-4a82-8647-9c827e4cbe7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2327bbf4-e75f-4dfa-9b31-8df1b8d19ea3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "246a7a65-59ea-446c-9b05-065cb52aa04e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26360a8e-7f2b-4608-9760-c0b3d787ed62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27ab85a4-9af2-40b1-991e-df1d76743e4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27deaee3-d337-44e9-9049-9a0368cb17fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a4658b4-e508-4659-95c4-d976a91cf418");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bc96170-dcbb-4c5d-b540-1ec3c7724919");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2be1d632-7cf2-44a3-88b9-df5a0927c106");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bef021a-a909-4ed8-a139-bee1a1350681");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e713b64-427a-4380-81aa-52b319361506");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f450fa8-41e9-47fa-81fb-d14f0d0d7510");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "324bcf23-95f9-4adb-8dba-f6251294fff1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e62e5f-fb16-46a6-9308-81ed2b8d737e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34f99f7b-7cf4-4b08-9d2a-9bf12ca897b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35939959-a846-4907-a2ab-48259733417a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "364b3174-19ed-45ec-b91d-4a8a7c466d3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36dbc44a-841f-43ce-9a8a-fedc1418b960");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3749cdbb-74ae-4192-a68b-f55c2d597d1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "385c5c34-7139-41e9-8f82-1d1bce0eb492");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389607e9-f3bf-461c-9736-8032cff6b9ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39793b16-f1c1-4100-955f-2ece0fe47b3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39d0c8aa-2163-428c-81da-35eae9448b45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aa53ec5-95f6-4f70-8279-9120cb3ff88f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c72b541-8e00-4723-bbea-23f8a3b8ec26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f503236-ba3e-4cb0-a2d6-38aa0f07c1e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40a63081-cf80-4ac7-9e81-79505f0155e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4117f488-8fab-4163-b629-ee8022b56c53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4147d1eb-7156-4645-8b95-7c6f68e2562d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420bfac8-4e7d-4003-9ccc-857d0007008d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43b2f79b-030f-48f7-bbd9-6d258d549e32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "442419cd-4a67-43df-b0fa-8352a6225f1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451d6155-e120-4ede-8912-780be14484ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45db9c4f-7e3d-4d8b-ba28-10ea92af55d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "463c50b8-1113-462d-aeb3-2a7130227ac6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46af9dd0-0c1c-43e2-8515-e987c2722a74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47459420-b320-490f-a761-912415b28488");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4762b663-c213-4e43-bcc8-efb9945b70e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4845db00-23c9-4001-8b82-8365c9311126");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c85c081-7803-4e81-997f-bba5a04b3b19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cb0c7fe-b741-4d90-8f3e-d98155764d7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50c5b28f-da00-4ad2-8fd2-5e24991859cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52e0837d-35a6-4eae-bc49-99bcd6512e6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54cb73fc-1537-46a1-a5d3-becb6cb55127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586a34c8-fd44-41f5-84d2-eb2589f863e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58ee8d1e-c91c-4989-bc17-2b1b9f2fe932");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59d06da2-2728-414d-952f-aab56ee669c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d4b57e8-4a9d-4fe2-82e3-e2cb576aa010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "614be560-8758-47e7-bd86-71ab073497ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62be3207-8bd4-4149-93ab-9976758d1652");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63716184-f298-469c-b916-a60592f8cff0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66bbfded-6aff-4878-9a89-0c8133edb427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "670ea2b3-1aba-433e-94b4-04cabc614927");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67a3cf44-7646-465e-be39-dd8b624784b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "682db033-e1b9-4f56-b4f1-5accf32a8002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69baf96d-a188-408b-bf35-14614ed898a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a949eea-b6a0-47c2-b126-6325b0210807");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7019ee69-bbbe-4fc6-95c3-49f63d0ecbd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70378d7b-2a8a-410b-b7f5-dd11d91350f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7268c40f-cf3f-44e8-b529-64b6a52440b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "733c4c86-4851-4edd-835c-6d4e9d46392c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73c65f20-79f9-4bad-8cf9-ee2d46fe304b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76e52545-e878-473f-9490-3b35b7fc962b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77ac976b-cf9f-43f0-88ac-0fd49861b4e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "784f9311-cdd8-4e7c-b930-2d8e2e00ae23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a24a647-9db6-4aa3-9c30-4b7ada91f688");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cdff295-70d8-461d-b912-5e3f795610e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dc7e18f-e8b4-4fb5-b9be-708aa627e261");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8068203e-a0f8-4b38-9633-998720689676");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82221a1e-b2be-49a8-9b21-25c935b5ef4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "828a4df0-f828-406e-9206-59dd3914083b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85ef9a7c-b986-4983-9315-30f501c55ea6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871dc97a-1a1d-439a-8899-2fa7e8136534");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "872ad393-38d2-4836-8637-90ab56a37b2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87cbb38e-7752-491b-9af4-c888ca0cd2d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8845e856-0ffc-432f-b707-a7708fd4993e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89cc38df-b54e-42df-b660-dcdc14aa01a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a29622e-285f-4107-8f55-d4bf0adbb07d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a32c559-19fb-4c21-b06b-36ec0c742df5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a58d771-9a1c-4889-a236-3b4ac760f08c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d011773-a1f1-4b45-a432-0d0f5964ed68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dcd00c6-7bdb-4d24-a94d-726b14e54574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8de46a92-cf21-4a7b-a3d1-ae6a6e77b6b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e463f9b-282d-4a59-b52c-2edfcd016fc0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fde220b-6520-430d-994b-d484bb35d387");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91fdcb09-bda8-487d-aef3-30e495c381cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91fea212-48a0-4182-8e6c-c918ae4fa2fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "922578b0-d830-422a-890b-cbdf67915bda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9343e566-9b56-4a28-9323-f2abbb009bfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93de6bc1-2446-417e-988a-016cfd7af441");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9424e5a8-db50-4325-9427-ff5d424b7390");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "969c06d6-0975-4a89-a6e6-d9217057205d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980b450f-f60d-481a-a197-2a59098b8466");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99516b95-8c75-4a07-8ea7-579020ee3701");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bfbe12e-8059-417f-9b1b-9c5bc4c592e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c42b9b3-e35b-4514-a556-abc2a643f62a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c6b4873-5aff-4ba1-8802-e58255dd9a13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef3df34-0213-4dcc-89f5-ed52a3db08a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a00247c7-c27f-4ec7-a75b-bd10c7be0020");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0f70227-a4fe-4f4f-b81d-84bb7dd70ab2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4a7a38e-7725-4e46-a189-e56ea04c037c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6ed5e54-961a-4637-bcc2-4ce2868f215b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a791c6b9-0115-4886-8db6-0da19fd8e61f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a988654b-9ccc-4f5c-97c0-c7673a14ebe9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab9c5e4e-f44d-4c8b-8eda-141efd6ccb5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac472523-142b-4f52-9fc0-53ad6b81b7b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac76909f-1a01-49b1-b1c8-b35e33a82a86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae2447e8-e9c9-428c-a297-f82756316c9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae9f559d-ea4a-458a-8202-9fd5a363eda8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0415e34-ea3e-4046-835a-fb5cabdad530");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b08d201b-1e5c-40b6-82e9-6a9f948d4df9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7012a96-4c97-45ef-9994-325c91a43793");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc30e212-6b45-4b8d-a01c-bc77debf11da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf2b8ac5-d6b4-427b-aa50-fd0d05a25f74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfde5bc0-cdc7-4c2d-b530-45939f923c65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2cfb687-3ec5-44e8-8dc0-0b5ade75f93a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d3893a-4c39-445a-8bcb-67db2a1bddfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c72d1dbd-4e7c-46b3-b52c-8dc40f41b59e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c73b2845-4485-4ff0-bc1a-9efe8c2f3d22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7a63d77-c4ae-439b-a0a6-f5441b2811bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca66e068-f861-4413-9397-9916567b7f1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd2b9e79-d90a-4fab-adbc-b0527bd63e39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0f71873-d985-4d28-b66e-bcd62af14d47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d135f23c-4f44-42ff-9170-e7ab73f99b9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d27c44bd-3ae5-4890-9317-b9fb2a7d2519");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2dc1670-7428-4a54-9c46-f86a68601225");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7c9f06f-73b4-4a84-9a68-c74facc54436");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d84c6527-c093-4588-86ba-34eafa8899d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d86456b3-bca9-46f2-bbe5-22c2c80b075a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8bbd4de-4f6c-4845-8d35-cf9ac6008df1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dafe4ef0-c80d-4e77-bb34-f22952e5911d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db297c52-69ee-447f-b8d2-bcb9c7f1f802");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db67ff53-e5aa-497b-8144-bf4ea0a46af9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dce99ebb-91e8-4101-9734-4de596c57d69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc38d2f-1001-4089-8df5-707e90d38180");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de7eae72-bcdf-4d3e-8db7-1592e7963db2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df01d150-7318-4989-b6f2-8f96b82d75c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfb190eb-ee18-4ec8-836a-6aba603086f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e052cdf0-e725-4448-bac1-cc249f3d1d94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18b2854-44c5-43ca-8566-156846a93c32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20bfd6b-8690-4d88-8c6f-86b10e49428a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e66504e4-a32c-4f66-8836-548dcd2b5d53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6851b3d-c3c6-4732-b131-569659be3e36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e86dbddb-882f-4183-a196-554a89513540");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8a05f9a-8ae5-4877-acd8-43dac3e98884");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebb8b8fc-5d4f-4e9f-844e-490983759c61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc9b6ad-81be-4ddd-8dfb-2b6a84f61d5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eea9a558-cefe-495e-9314-c54461dd9625");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efb1351f-b73a-4f6d-a6a2-450d92cd8e0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0dc1b3a-17da-427c-afdf-fa7cbc318757");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3d41ea0-9549-4b7e-8776-11cacca155c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f60254cd-c087-4ec6-a587-6b7e028bb4f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f666588b-ff95-4d78-8ce4-7e9365af939e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f893cbcf-f6af-4aa9-8c7c-c820ab98c552");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9b2f5df-a067-4e4d-8c34-449bb695f0c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbf54766-be8f-4a5f-b61f-982dbbcb9b05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc055012-b142-4d70-be53-cdccb21779d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc796a9a-f81b-4b70-b1cf-d8e82932b812");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd2f5529-9091-4d5c-8e20-92d438701a65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fec9d358-a8fc-488d-b81c-d0804bf9b9fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fee3abc0-f73f-4e5a-a84f-a7f28c1e9ab2");

            migrationBuilder.DropColumn(
                name: "ClaseID",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Clases");

            migrationBuilder.RenameColumn(
                name: "MateriaID",
                table: "Clases",
                newName: "ReservaID");

            migrationBuilder.RenameIndex(
                name: "IX_Clases_MateriaID",
                table: "Clases",
                newName: "IX_Clases_ReservaID");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Reservas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MateriasID",
                table: "Clases",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "013ab23e-b391-4218-9b97-70f33e748286", 0, "52bfc9be-7a51-4f6e-9a3c-ec757dcafc04", "dmata@cumbrescaracas.edu.ve", false, "Mata", false, null, "David", "DMATA@CUMBRESCARACAS.EDU.VE", "DMATA", null, null, false, "87e8eaaf-e0de-4c1b-ba26-ae09c896c569", false, "dmata" },
                    { "01ee59a2-6859-4867-8ee5-b4bf6a34e9ef", 0, "2865ef49-65a6-44c0-937a-6dce0a1e48fb", "rsirit@cumbrescaracas.edu.ve", false, "Sirit", false, null, "Ramon", "RSIRIT@CUMBRESCARACAS.EDU.VE", "RSIRIT", null, null, false, "267c3f3a-56ab-4547-8378-82d175b2ccc6", false, "rsirit" },
                    { "0210ef3f-79b0-4e71-8dc2-e8ff6891a370", 0, "328211e6-6a84-47ae-82f1-61c5baecf538", "dlucero@cumbrescaracas.edu.ve", false, "Lucero", false, null, "Deyvi", "DLUCERO@CUMBRESCARACAS.EDU.VE", "DLUCERO", null, null, false, "1a80b7e4-f488-40b7-8e71-a7a9d7cef343", false, "dlucero" },
                    { "0262a84e-6ff3-4c64-82e7-947d59e1b014", 0, "392017b5-764e-4e44-ad53-ca13b66656a1", "cgomez@cumbrescaracas.edu.ve", false, "Gomez", false, null, "Carlos", "CGOMEZ@CUMBRESCARACAS.EDU.VE", "CGOMEZ", null, null, false, "e38c9cb7-60b4-4609-bc26-da2c1209f16a", false, "cgomez" },
                    { "03469aa0-810d-4bff-9738-9a45cfbf2fc1", 0, "830c4dd7-860e-44bc-b50a-e40a2184c3d2", "rangeli@cumbrescaracas.edu.ve", false, "Rene", false, null, "Angeli", "RANGELI@CUMBRESCARACAS.EDU.VE", "RANGELI", null, null, false, "e4988e92-2a98-436b-aa65-25460f349773", false, "rangeli" },
                    { "080df80c-5832-46f5-9354-7b2906eaa1be", 0, "c0f2ac42-5a20-4f98-9d39-ad79ce96960f", "lmesa@cumbrescaracas.edu.ve", false, "Mesa", false, null, "Luisa", "LMESA@CUMBRESCARACAS.EDU.VE", "LMESA", null, null, false, "f1698d28-84b4-49f7-8c6d-a6715766f496", false, "lmesa" },
                    { "0a2ff245-1c7c-4ee2-abd0-704798ef0975", 0, "8948cd0c-963f-4bd1-8318-2c42aa4ec666", "arodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Ana", "ARODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ARODRIGUEZ", null, null, false, "b32bef11-4aef-4f63-b24e-90cc87e12112", false, "arodriguez" },
                    { "0b7164b3-657d-40a4-95aa-c872df90710d", 0, "41a6c193-1af6-4379-b692-1096426c3698", "syanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Simón", "SYANEZ@CUMBRESCARACAS.EDU.VE", "SYANEZ", null, null, false, "9e3c221f-e375-4cf9-9851-797c260bb835", false, "syanez" },
                    { "0cb1faf9-e339-40b5-8844-424919bdb285", 0, "7efe2078-7047-4f7e-ac83-81e64a66f6cd", "agalviz@cumbrescaracas.edu.ve", false, "Galviz", false, null, "Adrian", "AGALVIZ@CUMBRESCARACAS.EDU.VE", "AGALVIZ", null, null, false, "f825c45d-5978-45c5-a44e-9ec668a7b163", false, "agalviz" },
                    { "0d03d3d6-8e88-48b9-a207-76127c26be90", 0, "34092e23-4092-43f7-975f-32bd65a7f45e", "tgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Teresita", "TGARCIA@CUMBRESCARACAS.EDU.VE", "TGARCIA", null, null, false, "b42bb74d-d7b8-4eaa-9e99-a4962977ab9b", false, "tgarcia" },
                    { "0dedf9ae-93e9-4c5d-8417-331be7546670", 0, "29b3a5e2-52f0-424d-a863-fa550980d1a1", "mmata@arcol.org", false, "Mata De Mora", false, null, "María Carolina", "MMATA@ARCOL.ORG", "MMATA", null, null, false, "04c53dbb-e96f-432f-a74a-ee1653494458", false, "mmata" },
                    { "0f308227-654e-4227-83b2-a3f335743033", 0, "bdb6f02e-f7ab-46f6-9b58-dc1f2502c650", "imejias@cumbrescaracas.edu.ve", false, "Mejias", false, null, "Iliana", "IMEJIAS@CUMBRESCARACAS.EDU.VE", "IMEJIAS", null, null, false, "ac4e7fe7-bdfa-4711-845d-94a659bb60af", false, "imejias" },
                    { "0f75b9f1-6334-462b-a933-e799f27f8c1f", 0, "09e935e9-0e93-405c-a70e-77b7277cc289", "wteran@cumbrescaracas.edu.ve", false, "Terán", false, null, "Wilmer", "WTERAN@CUMBRESCARACAS.EDU.VE", "WTERAN", null, null, false, "178ff3e9-b9e4-406b-98be-6f19e74c077c", false, "wteran" },
                    { "17530c08-346c-458d-9108-9c5b0a2b1075", 0, "8dfea1ef-59b4-49e3-baa0-24b613ed9c93", "mcalzadilla@cumbrescaracas.edu.ve", false, "Calzadilla", false, null, "María Alejandra", "MCALZADILLA@CUMBRESCARACAS.EDU.VE", "MCALZADILLA", null, null, false, "6de5a6b9-9bb0-4cf6-9b4e-3402e87ca220", false, "mcalzadilla" },
                    { "1839c5c0-5aa0-4c98-b2cc-0135ef389fad", 0, "b5ff72f2-39f8-4185-b257-179bcce1ba36", "rofernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Rosmary", "ROFERNANDEZ@CUMBRESCARACAS.EDU.VE", "ROFERNANDEZ", null, null, false, "88ffa89b-32b8-4305-9a03-b2b34941baaf", false, "rofernandez" },
                    { "196f76da-bee1-45ee-9e3d-db2e808a7411", 0, "3b3f9af8-9650-41ed-b14d-6f2057f258a8", "dperrucci@cumbrescaracas.edu.ve", false, "Perrucci Meló", false, null, "Daniela Alejandra", "DPERRUCCI@CUMBRESCARACAS.EDU.VE", "DPERRUCCI", null, null, false, "9236cd74-91b3-48b4-a297-081c03f31de4", false, "dperrucci" },
                    { "1c461fdf-a805-4650-a073-bb49fe6a85f4", 0, "a67072cf-d0b4-4297-86de-cf938641ed95", "avalderrama@cumbrescaracas.edu.ve", false, "Valderrama", false, null, "Andrea", "AVALDERRAMA@CUMBRESCARACAS.EDU.VE", "AVALDERRAMA", null, null, false, "4ec3339b-6d80-489c-af50-358a8a49f783", false, "avalderrama" },
                    { "1ca08c4f-78d2-4f8a-8318-75fb7050ba5a", 0, "6b40efb7-ec8e-41c2-980c-5664a7e4e39f", "myanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Miguel Angel", "MYANEZ@CUMBRESCARACAS.EDU.VE", "MYANEZ", null, null, false, "c90a0ca2-d086-42d4-9108-7b85370b8aaf", false, "myanez" },
                    { "2319deb4-6274-4fde-8610-08dc8bc3a9d9", 0, "c22e0bb4-0326-4abe-a9ec-27504827be09", "cchirinos@cumbrescaracas.edu.ve", false, "Chirinos", false, null, "Christian", "CCHIRINOS@CUMBRESCARACAS.EDU.VE", "CCHIRINOS", null, null, false, "4c4ec1cd-9458-401c-a861-a88b667e3511", false, "cchirinos" },
                    { "2392fac1-c670-4d9a-9f8c-da8387d5d585", 0, "ea79c638-c78c-4eb7-806d-190486791647", "earmas@cumbrescaracas.edu.ve", false, "Armas", false, null, "Edilbeck", "EARMAS", "EARMAS@CUMBRESCARACAS.EDU.VE", null, null, false, "1a8cfddc-6575-44e7-8963-0cfe1900198f", false, "earmas" },
                    { "24550c94-4871-4d69-a3cc-ca79b0eff1a5", 0, "70910b88-977e-40cb-a4f3-9fe1471a2508", "jorodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "José Andrés", "JORODRIGUEZ@CUMBRESCARACAS.EDU.VE", "JORODRIGUEZ", null, null, false, "2b5b0a56-e259-43f2-9cf1-85bc5f407eec", false, "jorodriguez" },
                    { "2585d1aa-e554-45ae-8481-96400ff979ea", 0, "5733140d-92ad-4a5a-a9d2-9a54cb09d3b0", "mmichelena@cumbrescaracas.edu.ve", false, "Michelena", false, null, "Mariana", "MMICHELENA@CUMBRESCARACAS.EDU.VE", "MMICHELENA", null, null, false, "11b4dff2-f4ab-455b-88ed-de5db3f16168", false, "mmichelena" },
                    { "290dd206-34f5-49c1-91db-54437a63b7a7", 0, "cba1753b-e8c4-434f-b706-8e8f446725a3", "mtrujillo@cumbrescaracas.edu.ve", false, "Trujillo", false, null, "María Elena", "MTRUJILLO@CUMBRESCARACAS.EDU.VE", "MTRUJILLO", null, null, false, "6e62c77f-462a-4243-8a79-31ea6fd51aa8", false, "mtrujillo" },
                    { "2e87c875-d6ab-4160-ba76-e7ee8a0835dc", 0, "77902a4f-0535-4e1b-aa8c-f9c01f015a8c", "rsanchez@cumbrescaracas.edu.ve", false, "Sánchez", false, null, "Rosario", "RSANCHEZ@CUMBRESCARACAS.EDU.VE", "RSANCHEZ", null, null, false, "7737ffba-6765-4d25-bc11-023c15f4d21f", false, "rsanchez" },
                    { "2ec0438f-3c91-4f38-a962-018b9586f169", 0, "bdb97c28-8633-4750-bc1f-a00f7c7b71b8", "cquintana@cumbrescaracas.edu.ve", false, "Quintana", false, null, "Carla", "CQUINTANA@CUMBRESCARACAS.EDU.VE", "CQUINTANA", null, null, false, "79e00019-00ef-4f2c-8fa7-35454eb13960", false, "cquintana" },
                    { "30cb4ab1-a4ff-4c82-bedf-afc654ea3f2e", 0, "cf2d3dba-1849-458d-b07d-a925928b509c", "mvelasquez@cumbrescaracas.edu.ve", false, "Velásquez", false, null, "Perla Marina", "MVELASQUEZ@CUMBRESCARACAS.EDU.VE", "MVELASQUEZ", null, null, false, "adb43138-088c-46c5-9d41-540f6dbaf5de", false, "mvelasquez" },
                    { "3189d479-90ad-48db-a895-b021a4f18bd7", 0, "e4874bbe-5ae7-4f28-a3d1-b907cd748ca5", "nmagdaleno@cumbrescaracas.edu.ve", false, "Magdaleno", false, null, "Nancy", "NMAGDALENO@CUMBRESCARACAS.EDU.VE", "NMAGDALENO", null, null, false, "08376b5f-490e-41d5-9cd5-1367cea3423b", false, "nmagdaleno" },
                    { "3392df0b-13cc-4e89-9c35-5b9816e07fc2", 0, "d9746099-f907-4b66-8e60-df0c7105fe29", "gbellorin@cumbrescaracas.edu.ve", false, "Bellorin", false, null, "Gilberto", "GBELLORIN@CUMBRESCARACAS.EDU.VE", "GBELLORIN", null, null, false, "0deca760-1bd9-4730-85df-75abfdee38de", false, "gbellorin" },
                    { "34cd3d4c-6f5f-434e-bc44-4ed3b75b1d12", 0, "23be4a15-264f-41a0-8aa1-b546c7e3503f", "mpenaranda@cumbrescaracas.edu.ve", false, "Peñaranda", false, null, "María Antonieta", "MPENARANDA@CUMBRESCARACAS.EDU.VE", "MPENARANDA", null, null, false, "79c5c7a1-b2b8-4bee-80bf-f08db9ac24e2", false, "mpenaranda" },
                    { "357b4aea-dfb9-4177-bc7b-f5e394e00dac", 0, "f8282eed-c9b1-4a66-8dfb-cd3e2fd4c712", "mtortosa@cumbrescaracas.edu.ve", false, "Tortosa", false, null, "Maria Gabriela", "MTORTOSA@CUMBRESCARACAS.EDU.VE", "MTORTOSA", null, null, false, "7f7acfd8-8c49-4b43-a5b2-a3efcffd7f76", false, "mtortosa" },
                    { "38028c8f-3b99-4bed-b73e-7380908d3b2f", 0, "4f7ce4ac-93d4-429f-9303-4dece70f2e31", "mrocha@cumbrescaracas.edu.ve", false, "Vizcarrondo", false, null, "Marisela", "MROCHA@CUMBRESCARACAS.EDU.VE", "MROCHA", null, null, false, "bae91df3-c147-492d-b904-bfd4a3eee9cf", false, "mrocha" },
                    { "39c6c90e-bfe0-46cb-a837-813223c80653", 0, "cc9ec6c4-e2c0-4274-bbaa-06b2a96547dd", "msous@cumbrescaracas.edu.ve", false, "Sous", false, null, "Morela", "MSOUS@CUMBRESCARACAS.EDU.VE", "MSOUS", null, null, false, "fca1c2c1-dc53-40d4-a76e-b091a34d87a9", false, "msous" },
                    { "3a2b3151-a3be-4d66-bf0a-92f9ab59f88c", 0, "8b10e360-4224-4ce2-b4e2-95cae830c928", "loumarangulo@gmail.com", false, "Angulo", false, null, "Verónica", "LOUMARANGULO@GMAIL.COM", "LOUMARANGULO", null, null, false, "9774b76c-f19b-4a55-a803-6166b8ce8a23", false, "loumarangulo" },
                    { "3a54dfaa-265c-4a0c-b235-865743548bba", 0, "b3bad73f-c26c-40a4-97e1-247f085bf7a4", "iavendano@cumbrescaracas.edu.ve", false, "Avendaño", false, null, "Ivana", "IAVENDANO@CUMBRESCARACAS.EDU.VE", "IAVENDANO", null, null, false, "7188c176-96ee-41fb-8a39-4073c121e47f", false, "iavendano" },
                    { "3ac1d43b-601d-4b49-8213-6c95a4da963a", 0, "20e8da7a-1ce7-4a8a-b418-bdf2accf3bd6", "rgallo@cumbrescaracas.edu.ve", false, "Gallo", false, null, "Raffaela", "RGALLO@CUMBRESCARACAS.EDU.VE", "RGALLO", null, null, false, "26f0c288-8e95-47d7-a291-f77a85505cb1", false, "rgallo" },
                    { "3d8a62f3-0e21-43ac-8037-a31fce5cf807", 0, "eb0bb51f-1d8e-4638-ae6f-29a1babbd82b", "isabeldevillasmil@hotmail.com", false, "Bolinaga", false, null, "Isabel", "ISABELDEVILLASMIL@HOTMAIL.COM", "ISABELDEVILLASMIL", null, null, false, "accb0888-f1f7-41f4-8bca-b358c55d6ef7", false, "isabeldevillasmil" },
                    { "3ffe8716-3d73-4a91-9ae9-c021fd56ed7a", 0, "3d5fcc0d-5b31-46eb-984b-cb0c56bb2242", "amarzucco@cumbrescaracas.edu.ve", false, "Marzucco", false, null, "Alberto", "AMARZUCCO@CUMBRESCARACAS.EDU.VE", "AMARZUCCO", null, null, false, "7338dea0-3e63-403b-aaa7-4622202ece42", false, "amarzucco" },
                    { "40b14a2d-edac-4155-acbb-18066d16e60b", 0, "fee3eaf3-f25d-4feb-ac49-780c072dc7d1", "zrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Zamanta", "ZRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ZRODRIGUEZ", null, null, false, "b639aa46-a8d1-4adb-81a6-5bdf42a83fd4", false, "zrodriguez" },
                    { "4168ca16-57b8-40b6-b7a8-7f36060f02bd", 0, "64f73fea-00c0-4a83-b835-5f18bfadb76b", "kmarcano@cumbrescaracas.edu.ve", false, "Marcano", false, null, "Karina", "KMARCANO@CUMBRESCARACAS.EDU.VE", "KMARCANO", null, null, false, "0e640b6b-dbea-413f-b2e5-57640bb84f3f", false, "kmarcano" },
                    { "42051b9b-8cc8-4c43-a996-e16edeccc129", 0, "4e199cc3-0d74-41de-9571-7a24e14fc0b3", "yarrayago@cumbrescaracas.edu.ve", false, "Arrayago", false, null, "Yldith", "YARRAYAGO@CUMBRESCARACAS.EDU.VE", "YARRAYAGO", null, null, false, "698d3fe8-30fb-4120-a6fa-1f185c7bf30a", false, "yarrayago" },
                    { "45474ff0-eb0b-4199-846c-1ba307779f01", 0, "62ffa74e-3637-4b87-8c81-29d9ae4fdea6", "dmoreau@cumbrescaracas.edu.ve", false, "Moreau", false, null, "Desiree", "DMOREAU@CUMBRESCARACAS.EDU.VE", "DMOREAU", null, null, false, "73c09500-d3c8-48e2-844b-271cc68ef2cf", false, "dmoreau" },
                    { "49ac6c06-426f-49ad-a936-a43cb3f84ead", 0, "27dbbc06-3736-4252-a3a2-413265114c70", "jaleman@cumbrescaracas.edu.ve", false, "Alemán", false, null, "José Antonio", "JALEMAN@CUMBRESCARACAS.EDU.VE", "JALEMAN", null, null, false, "67aa700d-dad0-4986-bb4e-d249f762f3b1", false, "jaleman" },
                    { "4aaf50ca-bbde-4a53-8fc5-a690e861372f", 0, "d211c226-cd92-4137-ad78-f7a78ae9453b", "aarmas@cumbrescaracas.edu.ve", false, "Armas De Hanna", false, null, "Anabell", "AARMAS@CUMBRESCARACAS.EDU.VE", "AARMAS", null, null, false, "cc967e00-26b9-49eb-bf6a-acc0eb5b02f5", false, "aarmas" },
                    { "4afa0a79-6dfa-4ba6-a4b9-88dcd3cc5765", 0, "4e2f4855-3956-4365-bde1-882bbb961da5", "chenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Carlos", "CHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "CHENRIQUEZ", null, null, false, "42697cbd-fbf7-4329-a0f6-118a39966460", false, "chenriquez" },
                    { "4bd8e5cd-8ee6-442a-a77e-143c38ca205a", 0, "7232fbe4-b813-425a-a833-7cca5485738c", "lduquem@cumbrescaracas.edu.ve", false, "Duque", false, null, "Lilibeth", "LDUQUEM@CUMBRESCARACAS.EDU.VE", "LDUQUEM", null, null, false, "8d6787be-332a-4680-bf28-6e6dd2f8dd2c", false, "lduquem" },
                    { "4ca16a80-1527-4d20-a80c-15649578680e", 0, "a724cb9e-5d82-48c7-a8bc-c4ca9ad839ca", "apinero@cumbrescaracas.edu.ve", false, "Piñero", false, null, "Adriana", "APINERO@CUMBRESCARACAS.EDU.VE", "APINERO", null, null, false, "3344a855-c47a-4694-a15a-ac8a356fcfab", false, "apinero" },
                    { "4e4e46f5-cca6-458a-9d3c-f20bbc4737c4", 0, "53af20e9-2958-4e78-a634-954085e3b447", "lurueta@cumbrescaracas.edu.ve", false, "Urueta", false, null, "Leonidas", "LURUETA@CUMBRESCARACAS.EDU.VE", "LURUETA", null, null, false, "faef86e8-b0a0-42bc-b85e-2ebaec2afd85", false, "lurueta" },
                    { "4e655418-b0a9-41c2-a6bb-8ccec419a89c", 0, "59e579aa-8236-40b0-b26c-73afae7f7e9f", "yoropeza@cumbrescaracas.edu.ve", false, "Oropeza", false, null, "Yndhira", "YOROPEZA@CUMBRESCARACAS.EDU.VE", "YOROPEZA", null, null, false, "a91f8b75-5a9a-435e-a4ec-3f0b60df01ef", false, "yoropeza" },
                    { "4e739668-4902-405b-a8c3-cda972a5b09e", 0, "cc7e86a8-d12a-4ef2-86a3-fe0d68d4a999", "cchacon@cumbrescaracas.edu.ve", false, "Chacón", false, null, "Claudia", "CCHACON@CUMBRESCARACAS.EDU.VE", "CCHACON", null, null, false, "ddb5383b-de26-4078-958b-a3c56e9e1288", false, "cchacon" },
                    { "4eeeea49-8aba-4719-ad88-8a38f18a3736", 0, "165c1977-4749-4af8-8c58-0da2b3833054", "jthimotheo@cumbrescaracas.edu.ve", false, "Thimotheo", false, null, "José Carlos", "JTHIMOTHEO@CUMBRESCARACAS.EDU.VE", "JTHIMOTHEO", null, null, false, "5408c91c-11d8-4593-abb7-6e0692dd8edc", false, "jthimotheo" },
                    { "4f39ca4e-08c9-403b-8967-2e081e09c7cf", 0, "144b5b11-f698-49c5-af46-0558d9686906", "ldelgado@cumbrescaracas.edu.ve", false, "Delgado", false, null, "Leiza", "LDELGADO@CUMBRESCARACAS.EDU.VE", "LDELGADO", null, null, false, "53746ed9-d9b7-47f4-8566-102b1787868f", false, "ldelgado" },
                    { "50df86c4-2029-417c-9272-c1cbd7d32df9", 0, "e76d842c-46e3-45d6-92f0-31923d449b9f", "mhernandez@cumbrescaracas.edu.ve", false, "Hernandez", false, null, "Monica", "MHERNANDEZ@CUMBRESCARACAS.EDU.VE", "MHERNANDEZ", null, null, false, "31e72484-f276-4523-b049-8b6ad471a89d", false, "mhernandez" },
                    { "518fe5e0-adec-4d48-b9d6-26baeeca2d0d", 0, "1c4f5b8a-39c3-4b14-bab1-91cd8f3edb50", "maurodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Mauricio", "MAURODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MAURODRIGUEZ", null, null, false, "68bd55ca-5b3f-426e-8d30-ed3a277268a0", false, "maurodriguez" },
                    { "51e8cac4-41b8-4138-8f6d-98e8f7f1ad44", 0, "6939cc49-abc4-447f-abd4-904a95355427", "amgarcia@legionaries.org", false, "García", false, null, "Alvaro", "AMGARCIA@LEGIONARIES.ORG", "AMGARCIA", null, null, false, "b01f4a34-3552-4283-a956-25ab91a7c6cd", false, "amgarcia" },
                    { "5453fa73-9720-4ad7-aee8-dee1faffa3dd", 0, "9edd6a0f-4694-4069-b052-29fad18b9a5b", "mgallardo@cumbrescaracas.edu.ve", false, "Benavides", false, null, "Luana", "MGALLARDO@CUMBRESCARACAS.EDU.VE", "MGALLARDO", null, null, false, "8d08e365-7947-4416-9aef-149d6627fb94", false, "mgallardo" },
                    { "54c69dd8-be52-4385-8536-cccd54d0bbdb", 0, "71e09a1d-ee78-470b-9d0e-64de4d016972", "aortuno@cumbrescaracas.edu.ve", false, "Ortuño", false, null, "Andreulys", "AORTUNO@CUMBRESCARACAS.EDU.VE", "AORTUNO", null, null, false, "da571fd8-6133-4fb1-9b5b-040046dbfbd3", false, "aortuno" },
                    { "57873097-057e-45c2-b026-745122967600", 0, "f76bf698-f387-4a04-99d9-e3ed41ed7a59", "lcasique@cumbrescaracas.edu.ve", false, "Casique", false, null, "Liliana", "LCASIQUE@CUMBRESCARACAS.EDU.VE", "LCASIQUE", null, null, false, "ddd865a9-29f3-4814-bda1-ad770e4855c2", false, "lcasique" },
                    { "5b9af06e-0e69-4bd8-b066-c442fe766fea", 0, "8f0f2a28-7677-4894-9583-01c852b92d55", "jmgutierrez@cumbrescracas.edu.ve", false, "Gutierrez", false, null, "José Manuel", "JMGUTIERREZ@CUMBRESCRACAS.EDU.VE", "JMGUTIERREZ", null, null, false, "e32fe70a-65d6-4649-9e85-6364ab43c4de", false, "jmgutierrez" },
                    { "5bf325c9-58c6-454c-a957-a5063c0a6682", 0, "3524906f-812e-45eb-861a-86b8ce5db706", "mcardona@cumbrescaracas.edu.ve", false, "Cardona", false, null, "Marisela", "MCARDONA@CUMBRESCARACAS.EDU.VE", "MCARDONA", null, null, false, "763c86f5-1b80-49f8-af9a-cb1e865a0462", false, "mcardona" },
                    { "5c638ac9-f546-4022-b265-6c53d42745f9", 0, "d2982f04-1db3-474f-b817-4073b2cc469b", "dmarval@cumbrescaracas.edu.ve", false, "Marval", false, null, "Diego", "DMARVAL@CUMBRESCARACAS.EDU.VE", "DMARVAL", null, null, false, "fdc1df49-7d14-414d-b2dd-c0c10f8d33e6", false, "dmarval" },
                    { "5d152fb9-16b4-4535-b93c-0941bad69c77", 0, "3ddd1d76-0134-420e-aa82-4981f161d785", "ninosuanno@cumbrescaracas.edu.ve", false, "Suanno", false, null, "Joaquin", "NINOSUANNO@CUMBRESCARACAS.EDU.VE", "NINOSUANNO", null, null, false, "f8a4de71-2968-49e7-b741-5245933145b3", false, "ninosuanno" },
                    { "5e1a1b4c-9cee-4315-bdc3-83e5c2a62933", 0, "de61d097-881d-4ba2-90bc-2bd0f8c3b77f", "mdiaz@cumbrescaracas.edu.ve", false, "Diaz", false, null, "Maria Fernanda", "MDIAZ@CUMBRESCARACAS.EDU.VE", "MDIAZ", null, null, false, "34a0439c-048a-40db-9a39-b9e94f0ba2d4", false, "mdiaz" },
                    { "61379358-29ab-4f17-9574-1fe2d2882d8d", 0, "ca644e4b-7d89-4d4e-afa3-79527d2b885e", "vvinck@cumbrescaracas.edu.ve", false, "Vinck", false, null, "Vanessa", "VVINCK@CUMBRESCARACAS.EDU.VE", "VVINCK", null, null, false, "8eada567-b28a-4b8a-aa24-d8273fd6723c", false, "vvinck" },
                    { "625ef5d3-598b-4aef-b22a-d20c4b800a0b", 0, "a2fd774f-3763-43c0-8261-0ce537135a64", "jmarti@legionaries.org", false, "Martí", false, null, "Julio César", "JMARTI@LEGIONARIES.ORG", "JMARTI", null, null, false, "74ca5fe2-efb8-49ee-9ed4-87e3e8309488", false, "jmarti" },
                    { "626b2d7a-1465-46d4-8bc4-7172cc19df41", 0, "1086570a-53fc-4bfd-8521-38dbc22c52d8", "cnoguera@cumbrescaracas.edu.ve", false, "Noguera", false, null, "Carlos", "CNOGUERA@CUMBRESCARACAS.EDU.VE", "CNOGUERA", null, null, false, "572c6b03-5728-4536-97f5-08482f35720c", false, "cnoguera" },
                    { "632870e4-99ef-47d0-b87c-3f711ac27bc7", 0, "99f60e02-afd3-4aaa-a82f-85f717017574", "acorton@cumbrescaracas.edu.ve", false, "Corton", false, null, "Andrea", "ACORTON@CUMBRESCARACAS.EDU.VE", "ACORTON", null, null, false, "22993ea6-12af-4c6e-ba36-80809256dbad", false, "acorton" },
                    { "64097d1c-9af9-4aec-a3c6-50648e6edf55", 0, "3a486cfd-b2fd-49eb-8671-637673020020", "mperezr@cumbrescaracas.edu.ve", false, "Pérez", false, null, "Mayela", "MPEREZR@CUMBRESCARACAS.EDU.VE", "MPEREZR", null, null, false, "58617aa7-7ada-42c9-84a7-015bb8dd6960", false, "mperezr" },
                    { "641b4dad-7bae-4e1e-9474-1c19e94689e3", 0, "56bf50e3-40bd-4073-a0be-45ed5b96d6b4", "mitriago@cumbrescaracas.edu.ve", false, "Itriago", false, null, "Marianna", "MITRIAGO@CUMBRESCARACAS.EDU.VE", "MITRIAGO", null, null, false, "b6e559af-f807-4aa1-a942-1fcd22b9c35c", false, "mitriago" },
                    { "64b37343-6f5a-4406-a227-9a1db5c6cadd", 0, "fd66f110-b303-4fb8-9c24-0328eb87ced6", "btrias@cumbrescaracas.edu.ve", false, "Trias", false, null, "Beatriz", "BTRIAS@CUMBRESCARACAS.EDU.VE", "BTRIAS", null, null, false, "dc0113db-6981-410a-90e4-b526d999fd3f", false, "btrias" },
                    { "64c29c60-e3e4-471d-b3b6-69f85b95f2f7", 0, "9f53f7fa-859e-4b12-9637-b27b96c34ee7", "drondon@cumbrescaracas.edu.ve", false, "Rondon", false, null, "Dayana", "DRONDON@CUMBRESCARACAS.EDU.VE", "DRONDON", null, null, false, "7d35634a-26fa-419e-84b5-134f1e2289b5", false, "drondon" },
                    { "64cf3b91-9760-4901-b7b2-42f46a250e67", 0, "1c4e2148-418f-4879-8fc1-14d65cbe5a79", "kbrun@cumbrescaracas.edu.ve", false, "Brun", false, null, "Karina", "KBRUN@CUMBRESCARACAS.EDU.VE", "KBRUN", null, null, false, "eb411cee-586b-4957-bc62-0326368e7700", false, "kbrun" },
                    { "6afb3fa9-f754-4c05-b928-edcca2432a0e", 0, "ad84da0f-5262-4f04-aa53-242e2a539f4e", "jguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "Jessica", "JGUILLEN@CUMBRESCARACAS.EDU.VE", "JGUILLEN", null, null, false, "055c4db3-71b5-4435-88a5-40dd42745d25", false, "jguillen" },
                    { "6bd9700e-4408-443c-bd2f-33b5ff88d757", 0, "80527bd2-e12a-4430-beda-c83b5bec2f5b", "gaguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Greysa", "GAGUILAR@CUMBRESCARACAS.EDU.VE", "GAGUILAR", null, null, false, "6e580b40-22b0-44ef-8a41-b731f7b838b9", false, "gaguilar" },
                    { "6bf35d20-3a93-4169-96e6-a1fdb2fc8b5d", 0, "4be2decc-cb10-4aeb-b6b4-fca814d0f617", "mdjekki@cumbrescaracas.edu.ve", false, "Djekki", false, null, "Marianela", "MDJEKKI@CUMBRESCARACAS.EDU.VE", "MDJEKKI", null, null, false, "18e02ccc-34fe-4068-b334-97c939527172", false, "mdjekki" },
                    { "6d49c2e8-156b-467f-b942-026db4558052", 0, "35850b16-e359-4400-ba7f-a635d6fd40cb", "dsossa@legionaries.org", false, "Sossa", false, null, "Daniel", "DSOSSA@LEGIONARIES.ORG", "DSOSSA", null, null, false, "fdd64f73-72a7-477a-873d-eb65303131b3", false, "dsossa" },
                    { "6dbb3a84-5c13-41ba-af2f-89a5a0c388d2", 0, "f8a18f74-01c2-4ed5-a826-9a78b465538d", "legutierrez@cumbrescaracas.edu.ve", false, "Gutiérrez", false, null, "Leonardo", "LEGUTIERREZ@CUMBRESCARACAS.EDU.VE", "LEGUTIERREZ", null, null, false, "1e2605b7-93b8-4334-ad08-fc2fccda0f20", false, "legutierrez" },
                    { "6e52e385-720b-4c2c-b2b8-0f89dc933242", 0, "21896520-498d-44d8-9b63-0dd329408b70", "gcarvajal@cumbrescaracas.edu.ve", false, "Carvajal", false, null, "Gabriela", "GCARVAJAL@CUMBRESCARACAS.EDU.VE", "GCARVAJAL", null, null, false, "7cc5a597-f829-4b9b-85c7-14023de7b3f7", false, "gcarvajal" },
                    { "6f115045-098b-4188-8b44-9667b9eb2536", 0, "18f1633c-aa01-4d56-8126-70139fe84d00", "iluca@cumbrescaracas.edu.ve", false, "Luca", false, null, "Ivette", "ILUCA@CUMBRESCARACAS.EDU.VE", "ILUCA", null, null, false, "6eb422b2-e4d6-479e-b0fd-bbdd08e91eda", false, "iluca" },
                    { "6f787555-8b82-41dd-964a-c95e28e57f06", 0, "cd35e8fe-8b90-49d7-b871-02f4dd790907", "btogni@cumbrescaracas.edu.ve", false, "Togni", false, null, "Bruno", "BTOGNI@CUMBRESCARACAS.EDU.VE", "BTOGNI", null, null, false, "924e7f95-3794-445b-8af2-0b41aa701ed6", false, "btogni" },
                    { "71123dcb-3687-4c7e-a932-0cfd98470060", 0, "375e8e0c-e5db-41e4-8a3b-cafe6782bd43", "grando@cumbrescaracas.edu.ve", false, "Rando", false, null, "Gabriela", "GRANDO@CUMBRESCARACAS.EDU.VE", "GRANDO", null, null, false, "682f1903-0623-47f6-af38-6706d04b4e0a", false, "grando" },
                    { "72998419-14f4-44e8-9f60-98d85c444ecc", 0, "961139f1-13cb-4171-9b89-c652de7242dc", "yardila@cumbrescaracas.edu.ve", false, "Ardila", false, null, "Yuleima", "YARDILA@CUMBRESCARACAS.EDU.VE", "YARDILA", null, null, false, "6381af0d-fdd2-4927-9fc2-6c0dc88f16e5", false, "yardila" },
                    { "72a0e09b-cbdc-4e59-a0a1-d2594982198d", 0, "59ec84a2-4551-4a03-91dd-dbdd3d7514e7", "mnakhal@cumbrescaracas.edu.ve", false, "Nakhal Akel", false, null, "María Alejandra", "MNAKHAL@CUMBRESCARACAS.EDU.VE", "MNAKHAL", null, null, false, "cc3254c2-4ed5-4d75-b136-e777a064c902", false, "mnakhal" },
                    { "73531d6d-01fd-4b80-93b1-99ad1aca472f", 0, "6335799a-3110-46b6-a8b0-656def20a941", "gaortega@cumbrescaracas.edu.ve", false, "Ortega", false, null, "Gabriela", "GAORTEGA@CUMBRESCARACAS.EDU.VE", "GAORTEGA", null, null, false, "144cd024-50ce-4b39-8e28-324ad76180b0", false, "gaortega" },
                    { "73fce9ad-bf3b-4c50-8920-7cfe38b6332a", 0, "f5a58fc4-5b98-4054-a149-9ed9f491adec", "rpan@cumbrescaracas.edu.ve", false, "Dávila", false, null, "Rebeca", "RPAN@CUMBRESCARACAS.EDU.VE", "RPAN", null, null, false, "a91e39cb-871d-4359-a493-3f68871c6aba", false, "rpan" },
                    { "741116e5-8a8d-4f2e-8301-f11deeac9300", 0, "63f5d056-16fb-4db3-8290-156861fc4c80", "mgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Mariana", "MGONZALEZ@CUMBRESCARACAS.EDU.VE", "MGONZALEZ", null, null, false, "0c6ae942-e4fc-47b4-97a9-abe82e23d37c", false, "mgonzalez" },
                    { "750ba879-14c4-4d85-88ae-36739c6c96cc", 0, "68baf4df-0471-4eba-a47b-aac9d82c2a59", "maherrera@cumbrescaracas.edu.ve", false, "Herrera Bello", false, null, "María Alejandra", "MAHERRERA@CUMBRESCARACAS.EDU.VE", "MAHERRERA", null, null, false, "dedda6e4-f162-4ba6-8c16-0e7f673e2ca4", false, "maherrera" },
                    { "771300b4-1f17-423e-930c-1634b3048038", 0, "5409bb59-7983-4bd3-9359-79903ee1492f", "melavalladares@gmail.com", false, "Valladares", false, null, "Melanie", "MELAVALLADARES@GMAIL.COM", "MELAVALLADARES", null, null, false, "91e3f045-5fc7-46d2-8c59-36c53b2593b9", false, "melavalladares" },
                    { "77a92cd3-eb00-4a6d-bd49-9b7bbac545fc", 0, "b5d63a20-622c-4821-9175-786098133b2f", "jcaraballo@cumbrescaracas.edu.ve", false, "Caraballo", false, null, "José", "JCARABALLO@CUMBRESCARACAS.EDU.VE", "JCARABALLO", null, null, false, "74277103-f5f1-4245-8033-725f49b73f8d", false, "jcaraballo" },
                    { "799d1e47-118c-41ad-b61e-7f91cca440d3", 0, "174b7145-a1db-4dcc-8180-d069fef913c0", "pfernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Paula", "PFERNANDEZ@CUMBRESCARACAS.EDU.VE", "PFERNANDEZ", null, null, false, "dca275b6-7652-4077-804e-b4f1e1a28950", false, "pfernandez" },
                    { "7b1dfd5c-ce4a-414d-bc81-b8769d0c97f8", 0, "cf38de60-bcf0-43ef-885c-b4a4fff174a4", "rescobar@arcol.org", false, "Escobar", false, null, "Ricky", "RESCOBAR@ARCOL.ORG", "RESCOBAR", null, null, false, "62cae692-e491-4b1a-b199-1cfda3eb693e", false, "rescobar" },
                    { "7bbff757-dc9d-4808-bb4e-6c43f13d6a3d", 0, "00e6652d-67c7-4cbd-86f0-8d4ae234542b", "arojas@arcol.org", false, "Rojas", false, null, "Andy", "AROJAS@ARCOL.ORG", "AROJAS", null, null, false, "e2c2130d-2dec-4ff6-866b-642e65b6ddc7", false, "arojas" },
                    { "7dc06641-33ab-406f-84d1-a13e3a8340d4", 0, "7956ed21-5487-46b2-807b-a898f35713bd", "ahenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Andrés", "AHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "AHENRIQUEZ", null, null, false, "5cdfd0c3-26de-4b47-b9ff-35b5f8c7bb84", false, "ahenriquez" },
                    { "7e1ab2b6-060f-4f03-b7c7-bfebd0fed2e1", 0, "e1ac337e-65e0-4de8-a6f4-1086332a74d2", "mestevez@cumbrescaracas.edu.ve", false, "Estévez", false, null, "María Graciela", "MESTEVEZ@CUMBRESCARACAS.EDU.VE", "MESTEVEZ", null, null, false, "ed8fac41-c0af-4393-8a03-281f2a338678", false, "mestevez" },
                    { "7ed31c07-1066-42fc-abdf-3a20cfa1b12f", 0, "e3faefbd-a1de-40b2-892a-012d3dc23034", "gvelandia@cumbrescaracas.edu.ve", false, "Velandia", false, null, "Gabriel", "GVELANDIA@CUMBRESCARACAS.EDU.VE", "GVELANDIA", null, null, false, "8bdac7b0-f29c-4df6-a74f-700c63198b2a", false, "gvelandia" },
                    { "80b6af6f-8804-4790-bdcb-e8f2e48c2a72", 0, "4654a8d1-ecb5-463d-96e5-7914c381968d", "gcardas@cumbrescaracas.edu.ve", false, "Cardas", false, null, "Gwen", "GCARDAS@CUMBRESCARACAS.EDU.VE", "GCARDAS", null, null, false, "db9614af-f0a1-4fe2-8a11-dc4d8459ba17", false, "gcardas" },
                    { "81d963c8-5173-42b0-9641-0e5f5d515025", 0, "ea148988-516b-4525-8b0c-1dc5b5559374", "ecalvo@cumbrescaracas.edu.ve", false, "Calvo", false, null, "Esther", "ECALVO@CUMBRESCARACAS.EDU.VE", "ECALVO", null, null, false, "3f111aee-6a7a-4155-9bf0-1a1934e14a17", false, "ecalvo" },
                    { "8410b87a-3ef2-43ff-ad21-27cf77e35f78", 0, "9693f042-a474-4cd0-9dcb-8f3e5b67a1cf", "mrivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Mariana", "MRIVAS@CUMBRESCARACAS.EDU.VE", "MRIVAS", null, null, false, "8be0b8d2-78ea-49b8-befb-250fd9c75427", false, "mrivas" },
                    { "85616008-e069-4d6e-b7dd-dc169205c4a8", 0, "c474bedf-8f2e-4b1b-b076-72ef09e0093a", "mcastro@cumbrescaracas.edu.ve", false, "Castro", false, null, "Mariela", "MCASTRO@CUMBRESCARACAS.EDU.VE", "MCASTRO", null, null, false, "8ba7c787-4f0e-4609-a3ae-ed145b18e905", false, "mcastro" },
                    { "863fb5bb-9b9e-4844-b81c-216910675e8b", 0, "8cb71b32-0405-4f68-b27d-c2001427be07", "javila@cumbrescaracas.edu.ve", false, "Avila", false, null, "Jhonny", "JAVILA@CUMBRESCARACAS.EDU.VE", "JAVILA", null, null, false, "6439347e-a290-49c0-94b0-82a6076214d8", false, "javila" },
                    { "8734a6ce-8921-408f-88a1-35d89a64f19a", 0, "a6171472-ff50-43bf-8e73-656bba2d0a98", "imaurovich@cumbrescaracas.edu.ve", false, "Maurovich", false, null, "Isabel", "IMAUROVICH@CUMBRESCARACAS.EDU.VE", "IMAUROVICH", null, null, false, "07c333a6-6f03-4b83-8424-02312029f78c", false, "imaurovich" },
                    { "8771e53d-0580-4cd5-8791-fc0e45ddb9c5", 0, "e3ed8096-08f5-4fb9-9cde-8fd9d2503f7f", "ebellorin@cumbrescaracas.edu.ve", false, "Bellorín", false, null, "Ezeangelly", "EBELLORIN@CUMBRESCARACAS.EDU.VE", "EBELLORIN", null, null, false, "03240065-de44-4077-a53c-e2cb41900452", false, "ebellorin" },
                    { "87e2d322-6d23-4b79-a047-1c0ce9e51b62", 0, "4b87de0b-3a45-4b7a-bb57-c57cebc1e5f2", "cpadron@cumbrescaracas.edu.ve", false, "Chumbi", false, null, "Luis", "CPADRON@CUMBRESCARACAS.EDU.VE", "CPADRON", null, null, false, "23ee4ac0-329e-46fc-b655-25f01d914a91", false, "cpadron" },
                    { "8a86b943-5474-4912-b36c-d4e2a73e3a1e", 0, "d6542798-3fa3-4bbf-8c8d-fe27c16b95d1", "blosada@cumbrescaracas.edu.ve", false, "Losada", false, null, "Beatriz", "BLOSADA@CUMBRESCARACAS.EDU.VE", "BLOSADA", null, null, false, "64debb00-ff01-4289-b325-08393bd93d64", false, "blosada" },
                    { "8ad274fb-c6a4-4230-a95b-e07097012a3e", 0, "419c058e-aa46-4068-a67f-3b11cbc253ca", "mguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "María Fernanda", "MGUILLEN@CUMBRESCARACAS.EDU.VE", "MGUILLEN", null, null, false, "7cf39b9c-a4dd-4759-98e9-b11682ca8b27", false, "mguillen" },
                    { "8c3c4f3e-7254-4b65-8a52-06c29389dc24", 0, "600d3791-6d1c-4ac2-8345-b1ea03c0df44", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", "NADORNO@CUMBRESCARACAS.EDU.VE", "NADORNO", null, null, false, "5d599db0-1775-49c7-8baa-6c6146fcf9b6", false, "nadorno" },
                    { "8ea04c6a-18d8-4bb7-9f97-a95016f24e71", 0, "1b9ffe33-31e2-477f-9f5c-2b9d21b806ae", "mariselayjorge@hotmail.com", false, "Rocha", false, null, "Marisela", "MARISELAYJORGE@HOTMAIL.COM", "MARISELAYJORGE", null, null, false, "f313d6d3-2ca8-4dc9-ab45-0a39d4c9359f", false, "mariselayjorge" },
                    { "9313e22e-05c3-44b0-bf53-1c5569e1b774", 0, "d0cb6a9d-3561-4b58-b6c5-4f541964ecfe", "abedetti@cumbrescaracas.edu.ve", false, "Bedetti", false, null, "Alfredo", "ABEDETTI@CUMBRESCARACAS.EDU.VE", "ABEDETTI", null, null, false, "8ed144d2-8cc6-4f05-b1b6-5d714ef17b53", false, "abedetti" },
                    { "9445c4cd-5fe5-4c2a-8437-6dcdc738bf01", 0, "14c0bb4a-1433-48ce-8bd8-d3d798c344da", "gsalas@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriel", "GSALAS@CUMBRESCARACAS.EDU.VE", "GSALAS", null, null, false, "c3b53cbf-3399-49db-a23e-2589b79e77e0", false, "gsalas" },
                    { "945bfc37-cd33-4518-87bf-5479311ea96f", 0, "c5d077fe-07a4-48ce-b50f-e7f221cb487d", "carlosurdaneta@cumbrescaracas.edu.ve", false, "Urdaneta", false, null, "Carlos", "CARLOSURDANETA@CUMBRESCARACAS.EDU.VE", "CARLOSURDANETA", null, null, false, "906beb59-ef15-4425-8b3d-cdfa89a8c28b", false, "carlosurdaneta" },
                    { "97ed3b93-fb1f-4243-b286-ab5f0de17fd6", 0, "f09115fb-d7dd-4173-963c-50c9ab1c49d5", "sharrisson@cumbrescaracas.edu.ve", false, "Harrisson", false, null, "Selene", "SHARRISSON@CUMBRESCARACAS.EDU.VE", "SHARRISSON", null, null, false, "86b56f79-e09c-4785-b659-51f96f4fbebc", false, "sharrisson" },
                    { "9a6e6f84-9408-46a1-8f3a-027b429c6993", 0, "7abd4203-66ff-46cf-ad3d-7bb77d45fe50", "grodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Guida", "GRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "GRODRIGUEZ", null, null, false, "13ab65a9-346f-418a-97ca-7dbe4a7739f2", false, "grodriguez" },
                    { "9d9dda41-d7fc-4b2b-bdc2-ec1927175ce8", 0, "ca95df72-171b-40df-aed0-7ae4bff6c9e9", "ltavares@cumbrescaracas.edu.ve", false, "Tavares Goncalves", false, null, "Lisette", "LTAVARES@CUMBRESCARACAS.EDU.VE", "LTAVARES", null, null, false, "60e35b0b-9b8a-4a1d-b8b9-81e88f66e7f4", false, "ltavares" },
                    { "a0795a96-27e2-4abf-a9c1-609c100a8d61", 0, "939fb2ca-907e-47ee-be94-2e4a0d44169f", "ilugo@cumbrescaracas.edu.ve", false, "Lugo Caravallo", false, null, "Ismael José", "ILUGO@CUMBRESCARACAS.EDU.VE", "ILUGO", null, null, false, "651e82c3-738c-4ddd-85dd-fd74f863e91d", false, "ilugo" },
                    { "a1a26a67-bbca-460f-b08e-7a78d6a35c63", 0, "b6b9c228-7286-47e0-895f-e29b9a77b65b", "dnava@cumbrescaracas.edu.ve", false, "Nava", false, null, "Dayhan", "DNAVA@CUMBRESCARACAS.EDU.VE", "DNAVA", null, null, false, "695c672a-0f9a-4053-85d0-e3437b8367c9", false, "dnava" },
                    { "a60ba0d0-4556-4947-bcb1-e13cc55e4ee1", 0, "91c7e52e-37a3-4b62-abf0-e473bb809259", "cdearmas@cumbrescaracas.edu.ve", false, "De Armas", false, null, "Cristina", "CDEARMAS@CUMBRESCARACAS.EDU.VE", "CDEARMAS", null, null, false, "e6dd0d29-287a-46f7-86e7-615f39c05059", false, "cdearmas" },
                    { "a96143b9-7103-468a-95f1-308b8b8aa200", 0, "ad3e6760-9323-4714-a9f8-0741ffde8f30", "kmoreno@cumbrescaracas.edu.ve", false, "Moreno", false, null, "Katherine", "KMORENO@CUMBRESCARACAS.EDU.VE", "KMORENO", null, null, false, "f4586618-fa82-487f-9833-d91536068557", false, "kmoreno" },
                    { "aa093980-7f6b-4b92-b215-fd7833958817", 0, "456024b1-28e1-4e8e-9f5b-1af62ddec7fa", "jmontilla@cumbrescaracas.edu.ve", false, "Montilla", false, null, "Juan Izquierdo", "JMONTILLA@CUMBRESCARACAS.EDU.VE", "JMONTILLA", null, null, false, "e25aac70-1a89-4c92-8c1c-fd73908baea6", false, "jmontilla" },
                    { "aae9d354-91c7-44cb-9df1-db0a6245533a", 0, "cf11116e-0fa6-471c-aab9-bd76a4315728", "rpunceles@cumbrescaracas.edu.ve", false, "Punceles", false, null, "Rafael", "RPUNCELES@CUMBRESCARACAS.EDU.VE", "RPUNCELES", null, null, false, "85c54fc6-decf-4fd2-86eb-c9df6f47eadd", false, "rpunceles" },
                    { "ab3837c4-fdb4-4602-8480-2311cf699f0d", 0, "7fbf8c2c-e051-4a72-9295-ae014e0363ec", "jduran@cumbrescaracas.edu.ve", false, "Duran", false, null, "Jeniffer", "JDURAN@CUMBRESCARACAS.EDU.VE", "JDURAN", null, null, false, "6d37ace5-d1a4-448f-b8b3-509ef870c733", false, "jduran" },
                    { "afbe1698-1f5f-4757-a75a-0395d3a5e982", 0, "06ec8244-718c-4496-b5f4-b3149f4e5bcf", "drodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Daniella", "DRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "DRODRIGUEZ", null, null, false, "77f81074-853c-4d19-b4a9-78f0eb867e0f", false, "drodriguez" },
                    { "b1155231-d69c-44fa-b985-c67a23a9a034", 0, "f59aa70a-86d1-4b74-a147-e5e16b821954", "jgil@cumbrescaracas.edu.ve", false, "Gil", false, null, "Jesús Enrique", "JGIL@CUMBRESCARACAS.EDU.VE", "JGIL", null, null, false, "5563654e-43c1-4551-803f-3d72fde46c0b", false, "jgil" },
                    { "b228839c-0b53-4da9-ac1c-3d2688c0ba9c", 0, "4adcf030-a583-4fd4-982e-69309db44ccc", "caguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Claudia", "CAGUILAR@CUMBRESCARACAS.EDU.VE", "CAGUILAR", null, null, false, "87f629e3-8e6e-4531-a291-cab2d45b80b5", false, "caguilar" },
                    { "b45ca200-578c-4cd3-8e27-ad564d5cb74c", 0, "7858ec41-d4c1-4927-ae73-35520196db2c", "ccampos@cumbrescaracas.edu.ve", false, "Campos", false, null, "Carelia", "CCAMPOS@CUMBRESCARACAS.EDU.VE", "CCAMPOS", null, null, false, "b60f8365-bb65-46b6-93f1-774bf8644639", false, "ccampos" },
                    { "b6c42ed2-5457-4833-8883-319d5511da63", 0, "7184ce65-5841-4d2d-9b2c-cc4d084a3c86", "mvillasmil@cumbrescaracas.edu.ve", false, "Villasmil", false, null, "María Gabriela", "MVILLASMIL@CUMBRESCARACAS.EDU.VE", "MVILLASMIL", null, null, false, "c86d176a-d60b-4a74-8267-7a7237a74e20", false, "mvillasmil" },
                    { "b72de5b4-3458-4cc7-b56b-855607832fb0", 0, "db9b0bae-6884-4c0a-b777-3035f46f2302", "mariomanrique@cumbrescaracas.edu.ve", false, "Manrique", false, null, "Mario", "MARIOMANRIQUE@CUMBRESCARACAS.EDU.VE", "MARIOMANRIQUE", null, null, false, "2b50e4c9-ce7f-41a1-86f9-3ecb43d32a9b", false, "mariomanrique" },
                    { "b9debb3d-930e-469f-959b-86ede578d272", 0, "b7a37857-fce4-47bc-8415-8d2426823818", "bperez@cumbrescaracas.edu.ve", false, "Perez", false, null, "Beatriz", "BPEREZ@CUMBRESCARACAS.EDU.VE", "BPEREZ", null, null, false, "ad21fe4c-d73a-4df7-8ccd-1effaefdecc7", false, "bperez" },
                    { "ba929648-ef4f-4fc7-a0da-4087847d3817", 0, "23d8dc1b-0dea-4968-9cab-e9c26424b1f2", "lperezcastilla@legionaries.org", false, "Perez Castilla", false, null, "Leonardo", "LPEREZCASTILLA@LEGIONARIES.ORG", "LPEREZCASTILLA", null, null, false, "2580eecc-54f1-4692-b68e-de2fae31040c", false, "lperezcastilla" },
                    { "baa312fc-da09-4394-badd-d4c43639d16d", 0, "3f6105c9-21f4-4b59-a53e-5b23faf89c3c", "jtoro@cumbrescaracas.edu.ve", false, "Toro", false, null, "Jorge", "JTORO@CUMBRESCARACAS.EDU.VE", "JTORO", null, null, false, "85c5ae47-df11-4b5f-8476-76fdcd9ea77b", false, "jtoro" },
                    { "bea7e8fb-7051-4c09-a1c2-6a94224d696f", 0, "297c2398-9851-4e57-8ead-5fe8c687b632", "jblanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Jorge", "JBLANCO@CUMBRESCARACAS.EDU.VE", "JBLANCO", null, null, false, "565ff545-6db3-46fd-94fc-93cefcb06404", false, "jblanco" },
                    { "c1c12679-b121-400f-bf10-6e1c1a76efd5", 0, "aca82e21-a099-4065-9db2-3329fd49691c", "arguerra@cumbrescaracas.edu.ve", false, "Guerra", false, null, "Arminda", "ARGUERRA@CUMBRESCARACAS.EDU.VE", "ARGUERRA", null, null, false, "c84403a9-57d0-455b-a76c-5efa21e4077d", false, "arguerra" },
                    { "c37a5f18-76f1-429e-bbb5-e53d8e282833", 0, "b0b8dfef-36f5-46ee-9669-4140c30db6f4", "ysantaella@cumbrescaracas.edu.ve", false, "Santaella", false, null, "Yajaira", "YSANTAELLA@CUMBRESCARACAS.EDU.VE", "YSANTAELLA", null, null, false, "1190701b-2908-4019-92f3-116369fc195f", false, "ysantaella" },
                    { "c496065b-4ed3-47ab-b96c-ad21ebc0e883", 0, "52767caf-c7c6-4297-8397-23a04de65caa", "mparra@cumbrescaracas.edu.ve", false, "Parra", false, null, "María Virginia", "MPARRA@CUMBRESCARACAS.EDU.VE", "MPARRA", null, null, false, "d6bf150f-1839-48ed-985f-47b67fdab090", false, "mparra" },
                    { "c516fbef-c3bc-45b4-a50e-6c1273cb4635", 0, "e1e98392-47a4-45e4-890e-488ee2c94f93", "ymoreira@cumbrescaracas.edu.ve", false, "Moreira", false, null, "Yenny", "YMOREIRA@CUMBRESCARACAS.EDU.VE", "YMOREIRA", null, null, false, "994df42b-f042-4cc1-9b0a-a9a42cda8988", false, "ymoreira" },
                    { "c6b58645-2844-4a87-8fc9-0d0cf5a4fd50", 0, "f3fd0a64-99c5-4503-b65b-8e75fe0a98e4", "ayepes@cumbrescaracas.edu.ve", false, "Machado", false, null, "Ana Teresa", "AYEPES@CUMBRESCARACAS.EDU.VE", "AYEPES", null, null, false, "4f129a26-1cf5-418f-be36-fffa4716b77c", false, "ayepes" },
                    { "c7099000-4d08-4de0-8990-48de0bad9709", 0, "5a87c64e-6c5e-4231-9c0f-4b36d727c0c6", "adipentima@cumbrescaracas.edu.ve", false, "Vona", false, null, "América", "ADIPENTIMA@CUMBRESCARACAS.EDU.VE", "ADIPENTIMA", null, null, false, "b7bfb3d2-c505-4fc5-b019-7dba4f96c813", false, "adipentima" },
                    { "caaaa2d3-7a32-4d72-8941-e76f6a018a72", 0, "3731eb17-7b03-4323-a5e3-b54d7146c88f", "mrecchiuti@cumbrescaracas.edu.ve", false, "Recchiuti", false, null, "Mauricio", "MRECCHIUTI@CUMBRESCARACAS.EDU.VE", "MRECCHIUTI", null, null, false, "18d53107-9aed-4190-855e-9713fa71cecd", false, "mrecchiuti" },
                    { "cb922ec6-fe32-4232-b48e-69ba6451f46d", 0, "f16951fa-9ec8-47d7-9874-83f9180906ff", "joserivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Jose", "JOSERIVAS@CUMBRESCARACAS.EDU.VE", "JOSERIVAS", null, null, false, "8eb26967-8b10-4938-8223-dbffe0bd60b8", false, "joserivas" },
                    { "cd9c935c-32ce-4fe3-bd63-2678913b77a8", 0, "2eb57005-fc3c-477b-9ddd-fb82f5d15121", "tayling_steffany@hotmail.com", false, "Galindo", false, null, "Tayling", "TAYLING_STEFFANY@HOTMAIL.COM", "TAYLING_STEFFANY", null, null, false, "35455aa0-dbfc-4c0d-8c94-0f0ced940193", false, "tayling_steffany" },
                    { "cdd46e99-0454-4a10-8e39-3caad5e0363b", 0, "f3c89214-1132-478e-b454-9755731c353c", "leninbetancourt@yahoo.es", false, "Betancourt", false, null, "Lenin", "LENINBETANCOURT@YAHOO.ES", "LENINBETANCOURT", null, null, false, "9ee1dfbf-98cc-4b9a-99d8-b024cb14f26c", false, "leninbetancourt" },
                    { "cf827d64-cb29-44e9-a96f-429513bfb8ce", 0, "e47246c7-29b0-4d6a-93c1-92efd6e64735", "mmarquez@cumbrescaracas.edu.ve", false, "Márquez", false, null, "María Esperanza", "MMARQUEZ@CUMBRESCARACAS.EDU.VE", "MMARQUEZ", null, null, false, "6397b21a-0761-41c3-b55e-d6a874504c5b", false, "mmarquez" },
                    { "d1938bfe-d7a7-46c2-858c-9016d08deabe", 0, "b09f1b13-305b-4147-87de-6edef3868192", "dbrando@cumbrescaracas.edu.ve", false, "Brando", false, null, "Daniel", "DBRANDO@CUMBRESCARACAS.EDU.VE", "DBRANDO", null, null, false, "b2fd7d93-8b59-47ab-b053-2559775d8c93", false, "dbrando" },
                    { "d29549db-9374-414b-88a2-4a56ac16ccb3", 0, "8ada9791-ca58-4a9f-9388-91c0b32141f7", "marismendi@cumbrescaracas.edu.ve", false, "Arismendi", false, null, "Martina", "MARISMENDI", "MARISMENDI@CUMBRESCARACAS.EDU.VE", null, null, false, "0f2d28e8-c02f-4cd0-86e8-60eb62612d2a", false, "marismendi" },
                    { "d383dea5-4265-4121-8319-87eb0398a5ee", 0, "8c1e4187-c5e9-4023-b899-fed3dbaa2536", "jumarmol@cumbrescaracas.edu.ve", false, "Mármol", false, null, "Juliana", "JUMARMOL@CUMBRESCARACAS.EDU.VE", "JUMARMOL", null, null, false, "d3dfac9d-090d-4a8b-a0fe-4e5caf9627df", false, "jumarmol" },
                    { "d4d93b83-baa7-4465-8224-0495b7f7868c", 0, "860439b1-ce73-4e6e-a0de-37ac169e3c7b", "jgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Jesús", "JGARCIA@CUMBRESCARACAS.EDU.VE", "JGARCIA", null, null, false, "473eb11c-f62d-4d36-ad95-7056aea0cc25", false, "jgarcia" },
                    { "d5eda6f1-14b9-4e25-8779-c6939c7552b1", 0, "94fd0d6d-8140-4a36-b797-a097c0d9d091", "cadiaz@arcol.org", false, "Díaz", false, null, "Carolina", "CADIAZ@ARCOL.ORG", "CADIAZ", null, null, false, "dc45cfb3-1ed0-4345-b9f2-3c7c998512ba", false, "cadiaz" },
                    { "d6266fdd-5a7d-4991-8b12-6f415e4c0a1d", 0, "10a2dbc9-f52f-44d5-9afd-3dde50f3f304", "rvgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Rossana", "RVGONZALEZ@CUMBRESCARACAS.EDU.VE", "RVGONZALEZ", null, null, false, "c0c1c3c4-c1a8-453d-b5cf-cb3c2b21abbc", false, "rvgonzalez" },
                    { "d86a05bc-26df-41ca-a790-c34a3829b237", 0, "87cdfdf1-8968-4df8-a928-d7fedd57d9b9", "malcala@cumbrescaracas.edu.ve", false, "Alcala", false, null, "Melissa", "MALCALA@CUMBRESCARACAS.EDU.VE", "MALCALA", null, null, false, "4d851bc9-8720-4b7f-aa0e-71a277895d28", false, "malcala" },
                    { "de248982-679f-4cd5-b449-2bd3c2e54577", 0, "ba01cbfe-1b28-4622-bc62-277e880dbd08", "igabaldon@cumbrescaracas.edu.ve", false, "De Gabaldon", false, null, "Isabel", "IGABALDON@CUMBRESCARACAS.EDU.VE", "IGABALDON", null, null, false, "7a7bd262-4c97-476c-830f-77d6f2bb8481", false, "igabaldon" },
                    { "df5579cd-931e-481b-8236-c03d8a02a997", 0, "3f7089b8-f243-49fd-acbd-af3e72d4bcc8", "pdaumy@losarcos.edu.ve", false, "Daumy", false, null, "Patricia", "PDAUMY@LOSARCOS.EDU.VE", "PDAUMY", null, null, false, "f80fb8ea-1b7f-4019-8e16-abc773978bcb", false, "pdaumy" },
                    { "dfde7490-b117-4c0c-87cb-04830bef4838", 0, "90c23fba-3939-4348-a208-c97354a2d7ab", "csuarez@cumbrescaracas.edu.ve", false, "Suárez", false, null, "César", "CSUAREZ@CUMBRESCARACAS.EDU.VE", "CSUAREZ", null, null, false, "ad25145f-841e-4378-8d2b-dc8fdbf9b16b", false, "csuarez" },
                    { "dffe3c4c-b29b-40e9-9ec9-71251bee736d", 0, "878ef9d7-eea7-45c1-b340-113235a46cbd", "larellano@legionaries.org", false, "Arellano", false, null, "Leonardo", "LARELLANO", "LARELLANO@LEGIONARIES.ORG", null, null, false, "687b57cd-bac5-4eb6-bbd3-652dbf33f343", false, "larellano" },
                    { "e39f7025-299d-4d04-9de2-60aa872a64b7", 0, "465b93fb-2c5d-4a82-8b25-894dacb10849", "julieta.elena.rivas@gmail.com", false, "Rivas", false, null, "Julieta", "JULIETA.ELENA.RIVAS@GMAIL.COM", "JULIETA.ELENA.RIVAS", null, null, false, "da27dbbc-1c2f-4fe2-9f41-1fab8a6a3c70", false, "julieta.elena.rivas" },
                    { "e3d5a776-f32e-46ca-b997-dc7843a50b85", 0, "8b8a5e4c-2654-4983-8e29-441cbcab72d2", "pparis@cumbrescaracas.edu.ve", false, "Paris", false, null, "Pedro", "PPARIS@CUMBRESCARACAS.EDU.VE", "PPARIS", null, null, false, "208e19c9-058a-4ba5-9084-ec4993500104", false, "pparis" },
                    { "e654242b-4691-4b17-ad30-0b77941ddc8a", 0, "dc5d9526-7945-4764-a0ba-6dc9de6db21e", "azambrano@cumbrescaracas.edu.ve", false, "Zambrano", false, null, "Alexis", "AZAMBRANO@CUMBRESCARACAS.EDU.VE", "AZAMBRANO", null, null, false, "3901b631-a170-46ea-a021-2e0f1909733d", false, "azambrano" },
                    { "eb22284c-a197-4ddf-b62e-1f1d56c976bc", 0, "9db71af2-1407-4287-91d7-1e6fc6d84e74", "alovera@cumbrescarcas.edu.ve", false, "Lovera", false, null, "Adriana", "ALOVERA@CUMBRESCARCAS.EDU.VE", "ALOVERA", null, null, false, "7c127e23-2f95-47e0-b631-274c1bc59a32", false, "alovera" },
                    { "ee6d90b2-1514-4c8d-b295-769736140720", 0, "c15b7ccf-5121-4954-849f-d908ba159e07", "afeola@cumbrescaracas.edu.ve", false, "Feola Carrasquel", false, null, "Alfonso Eloy", "AFEOLA@CUMBRESCARACAS.EDU.VE", "AFEOLA", null, null, false, "7b3a06d6-61e6-4103-a611-bf881cae2197", false, "afeola" },
                    { "eed83e15-2cb8-4d8d-96ac-87a4dbc1cc7f", 0, "6ff71fa4-f842-4e28-b05e-8279516581f9", "mcapuz@cumbrescaracas.edu.ve", false, "Capuz", false, null, "Marycel", "MCAPUZ@CUMBRESCARACAS.EDU.VE", "MCAPUZ", null, null, false, "87a1f663-6944-4913-be7e-23879ddea3e9", false, "mcapuz" },
                    { "eefb50ff-c3af-4ed5-80b4-2fb1adcf7212", 0, "f3f53d94-c1d5-435b-9493-9fabbd91e593", "avivas@cumbrescaracas.edu.ve", false, "Vivas", false, null, "Alejandra", "AVIVAS@CUMBRESCARACAS.EDU.VE", "AVIVAS", null, null, false, "1d590d95-7ddf-4d96-9c96-3e7af4d17b86", false, "avivas" },
                    { "efbd58b8-5185-4112-b855-b9abc69d046d", 0, "4ba450d6-1628-4252-9a2c-cc803be631c5", "gadiaz@cumbrescaracas.edu.ve", false, "Díaz", false, null, "Guadalupe", "GADIAZ@CUMBRESCARACAS.EDU.VE", "GADIAZ", null, null, false, "7481c9f9-a905-4728-bfd5-c6adec04fe1f", false, "gadiaz" },
                    { "f0891aa7-9eef-4103-afb0-0ad9b538b7b8", 0, "fb55fdc4-f39d-48c7-a945-bca9e3ca6556", "dgiuliani@cumbrescaracas.edu.ve", false, "Giuliani", false, null, "Donatina", "DGIULIANI@CUMBRESCARACAS.EDU.VE", "DGIULIANI", null, null, false, "aad6c5e5-0e7d-4b0c-9cf5-d3837b867bcf", false, "dgiuliani" },
                    { "f1c5948b-d211-4406-82b8-cb76a42596b2", 0, "59f4d6a0-e1bf-4d48-98d4-12f7f2e0a7f4", "mramos@cumbrescaracas.edu.ve", false, "Ramos", false, null, "María", "MRAMOS@CUMBRESCARACAS.EDU.VE", "MRAMOS", null, null, false, "47cc34de-8108-4735-b25d-66d79e233165", false, "mramos" },
                    { "f3a51574-a98b-49de-a94f-6d45ebb031bb", 0, "35b053c7-e8ad-4200-861c-1dd0a541cd96", "gandara@cumbrescaracas.edu.ve", false, "Andara", false, null, "German", "GANDARA@CUMBRESCARACAS.EDU.VE", "GANDARA", null, null, false, "b06627d1-2f97-4505-a5e0-1efdf7a8032b", false, "gandara" },
                    { "f3aa4394-a1f1-475e-9b67-eecc01efff43", 0, "ff1cbed0-2859-4fbb-94a9-199e4eff4be6", "clopez@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriela", "CLOPEZ@CUMBRESCARACAS.EDU.VE", "CLOPEZ", null, null, false, "aff987d0-48a3-4fad-bfe2-12b26eef656b", false, "clopez" },
                    { "f4078f4a-4f3d-4bfe-a158-43f9af828d0c", 0, "fd2ef385-d378-45cd-9404-5db42ba8a093", "ccano@cumbrescaracas.edu.ve", false, "Cano", false, null, "Cristina", "CCANO@CUMBRESCARACAS.EDU.VE", "CCANO", null, null, false, "fca74e8d-d179-479b-bf2b-767159cca1d8", false, "ccano" },
                    { "f664669b-00cd-487a-92cf-2b50c8f66f5a", 0, "4464d75b-03df-466b-9f8a-561891d25984", "ibolivar@cumbrescaracas.edu.ve", false, "Bolívar", false, null, "Ivette", "IBOLIVAR@CUMBRESCARACAS.EDU.VE", "IBOLIVAR", null, null, false, "56df693f-3300-4a4c-a834-6d5db224641c", false, "ibolivar" },
                    { "f6e8cdd3-9e97-474a-8f25-4652bb2d8883", 0, "efc18755-94ff-44ba-92c6-bd3abcdc4c8a", "ablanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Andrés", "ABLANCO@CUMBRESCARACAS.EDU.VE", "ABLANCO", null, null, false, "1c12e83d-70c5-47d9-9efc-005f4e9f0e8e", false, "ablanco" },
                    { "f703ec1c-e29b-4e99-b64a-c7c877193713", 0, "a816cc13-5271-48c0-8e5c-d80e0eb46bd0", "lrodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Luis Antonio", "LRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "LRODRIGUEZ", null, null, false, "a1075c6d-cf62-4ec5-90e9-a30a408c7c53", false, "lrodriguez" },
                    { "faaa3916-9545-4206-a739-180d27ed8286", 0, "63f5ddab-9fa5-48fd-9192-99c7b5297015", "mfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Marianella", "MFUENMAYOR@CUMBRESCARACAS.EDU.VE", "MFUENMAYOR", null, null, false, "32815407-5574-4c53-a9a0-a21b81a8b235", false, "mfuenmayor" },
                    { "faaf4791-07f2-4c90-a61c-b3201f3b0084", 0, "1fb6cdc0-d848-4785-a1a8-16873bb65d8a", "mrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "María Corina", "MRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MRODRIGUEZ", null, null, false, "7a754bba-8577-450d-9c87-1b597fa3b0d7", false, "mrodriguez" },
                    { "fb74c3d0-9a8c-4971-b740-5c05c39791ed", 0, "a02cf7d3-09ba-4f3d-ba00-34c64da2db34", "rdosreis@cumbrescaracas.edu.ve", false, "Dos Reis", false, null, "Rosa", "RDOSREIS@CUMBRESCARACAS.EDU.VE", "RDOSREIS", null, null, false, "5ce916b0-84f7-4423-8d4d-7b82f635da42", false, "rdosreis" },
                    { "fc096dec-c4b4-489a-8c46-523fb93ed2c9", 0, "af2c79f0-d7d3-4c8d-84ba-16798c563d23", "irangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Ignacio", "IRANGEL@CUMBRESCARACAS.EDU.VE", "IRANGEL", null, null, false, "6923927e-558d-4408-8e16-6c4eda78a9e6", false, "irangel" },
                    { "fc24fcd6-2f09-4a76-96de-66ff2a825561", 0, "09b4c293-2720-47c7-8cd7-898f6684a0a9", "mrangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Marco Aurelio", "MRANGEL@CUMBRESCARACAS.EDU.VE", "MRANGEL", null, null, false, "7d38896d-b4a8-422d-ac4d-c9aaec3fc153", false, "mrangel" },
                    { "ff9d05f6-b3d7-4b3e-bd71-68c8afaeb7fd", 0, "aa4370f2-fe27-48d3-b1f1-8f6bc1531b90", "sfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Solimar", "SFUENMAYOR@CUMBRESCARACAS.EDU.VE", "SFUENMAYOR", null, null, false, "b7265053-69a6-4b9b-85c4-54ed68953da2", false, "sfuenmayor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UserID",
                table: "Reservas",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_MateriasID",
                table: "Clases",
                column: "MateriasID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Materias_MateriasID",
                table: "Clases",
                column: "MateriasID",
                principalTable: "Materias",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Reservas_ReservaID",
                table: "Clases",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_UserID",
                table: "Reservas",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Materias_MateriasID",
                table: "Clases");

            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Reservas_ReservaID",
                table: "Clases");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_UserID",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_UserID",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Clases_MateriasID",
                table: "Clases");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "013ab23e-b391-4218-9b97-70f33e748286");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01ee59a2-6859-4867-8ee5-b4bf6a34e9ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0210ef3f-79b0-4e71-8dc2-e8ff6891a370");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0262a84e-6ff3-4c64-82e7-947d59e1b014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03469aa0-810d-4bff-9738-9a45cfbf2fc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080df80c-5832-46f5-9354-7b2906eaa1be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a2ff245-1c7c-4ee2-abd0-704798ef0975");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b7164b3-657d-40a4-95aa-c872df90710d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cb1faf9-e339-40b5-8844-424919bdb285");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d03d3d6-8e88-48b9-a207-76127c26be90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dedf9ae-93e9-4c5d-8417-331be7546670");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f308227-654e-4227-83b2-a3f335743033");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f75b9f1-6334-462b-a933-e799f27f8c1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17530c08-346c-458d-9108-9c5b0a2b1075");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1839c5c0-5aa0-4c98-b2cc-0135ef389fad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "196f76da-bee1-45ee-9e3d-db2e808a7411");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c461fdf-a805-4650-a073-bb49fe6a85f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ca08c4f-78d2-4f8a-8318-75fb7050ba5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2319deb4-6274-4fde-8610-08dc8bc3a9d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2392fac1-c670-4d9a-9f8c-da8387d5d585");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24550c94-4871-4d69-a3cc-ca79b0eff1a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2585d1aa-e554-45ae-8481-96400ff979ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "290dd206-34f5-49c1-91db-54437a63b7a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e87c875-d6ab-4160-ba76-e7ee8a0835dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ec0438f-3c91-4f38-a962-018b9586f169");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30cb4ab1-a4ff-4c82-bedf-afc654ea3f2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3189d479-90ad-48db-a895-b021a4f18bd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3392df0b-13cc-4e89-9c35-5b9816e07fc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34cd3d4c-6f5f-434e-bc44-4ed3b75b1d12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "357b4aea-dfb9-4177-bc7b-f5e394e00dac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38028c8f-3b99-4bed-b73e-7380908d3b2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39c6c90e-bfe0-46cb-a837-813223c80653");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a2b3151-a3be-4d66-bf0a-92f9ab59f88c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a54dfaa-265c-4a0c-b235-865743548bba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ac1d43b-601d-4b49-8213-6c95a4da963a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d8a62f3-0e21-43ac-8037-a31fce5cf807");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ffe8716-3d73-4a91-9ae9-c021fd56ed7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40b14a2d-edac-4155-acbb-18066d16e60b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4168ca16-57b8-40b6-b7a8-7f36060f02bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42051b9b-8cc8-4c43-a996-e16edeccc129");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45474ff0-eb0b-4199-846c-1ba307779f01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49ac6c06-426f-49ad-a936-a43cb3f84ead");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4aaf50ca-bbde-4a53-8fc5-a690e861372f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4afa0a79-6dfa-4ba6-a4b9-88dcd3cc5765");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bd8e5cd-8ee6-442a-a77e-143c38ca205a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ca16a80-1527-4d20-a80c-15649578680e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e4e46f5-cca6-458a-9d3c-f20bbc4737c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e655418-b0a9-41c2-a6bb-8ccec419a89c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e739668-4902-405b-a8c3-cda972a5b09e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eeeea49-8aba-4719-ad88-8a38f18a3736");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f39ca4e-08c9-403b-8967-2e081e09c7cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50df86c4-2029-417c-9272-c1cbd7d32df9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "518fe5e0-adec-4d48-b9d6-26baeeca2d0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51e8cac4-41b8-4138-8f6d-98e8f7f1ad44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5453fa73-9720-4ad7-aee8-dee1faffa3dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54c69dd8-be52-4385-8536-cccd54d0bbdb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57873097-057e-45c2-b026-745122967600");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b9af06e-0e69-4bd8-b066-c442fe766fea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf325c9-58c6-454c-a957-a5063c0a6682");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c638ac9-f546-4022-b265-6c53d42745f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d152fb9-16b4-4535-b93c-0941bad69c77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e1a1b4c-9cee-4315-bdc3-83e5c2a62933");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61379358-29ab-4f17-9574-1fe2d2882d8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "625ef5d3-598b-4aef-b22a-d20c4b800a0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "626b2d7a-1465-46d4-8bc4-7172cc19df41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "632870e4-99ef-47d0-b87c-3f711ac27bc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64097d1c-9af9-4aec-a3c6-50648e6edf55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "641b4dad-7bae-4e1e-9474-1c19e94689e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64b37343-6f5a-4406-a227-9a1db5c6cadd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64c29c60-e3e4-471d-b3b6-69f85b95f2f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64cf3b91-9760-4901-b7b2-42f46a250e67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6afb3fa9-f754-4c05-b928-edcca2432a0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd9700e-4408-443c-bd2f-33b5ff88d757");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bf35d20-3a93-4169-96e6-a1fdb2fc8b5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d49c2e8-156b-467f-b942-026db4558052");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dbb3a84-5c13-41ba-af2f-89a5a0c388d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e52e385-720b-4c2c-b2b8-0f89dc933242");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f115045-098b-4188-8b44-9667b9eb2536");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f787555-8b82-41dd-964a-c95e28e57f06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71123dcb-3687-4c7e-a932-0cfd98470060");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72998419-14f4-44e8-9f60-98d85c444ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a0e09b-cbdc-4e59-a0a1-d2594982198d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73531d6d-01fd-4b80-93b1-99ad1aca472f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73fce9ad-bf3b-4c50-8920-7cfe38b6332a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "741116e5-8a8d-4f2e-8301-f11deeac9300");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "750ba879-14c4-4d85-88ae-36739c6c96cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771300b4-1f17-423e-930c-1634b3048038");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77a92cd3-eb00-4a6d-bd49-9b7bbac545fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "799d1e47-118c-41ad-b61e-7f91cca440d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b1dfd5c-ce4a-414d-bc81-b8769d0c97f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bbff757-dc9d-4808-bb4e-6c43f13d6a3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dc06641-33ab-406f-84d1-a13e3a8340d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e1ab2b6-060f-4f03-b7c7-bfebd0fed2e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ed31c07-1066-42fc-abdf-3a20cfa1b12f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80b6af6f-8804-4790-bdcb-e8f2e48c2a72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81d963c8-5173-42b0-9641-0e5f5d515025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8410b87a-3ef2-43ff-ad21-27cf77e35f78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85616008-e069-4d6e-b7dd-dc169205c4a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "863fb5bb-9b9e-4844-b81c-216910675e8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8734a6ce-8921-408f-88a1-35d89a64f19a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8771e53d-0580-4cd5-8791-fc0e45ddb9c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87e2d322-6d23-4b79-a047-1c0ce9e51b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a86b943-5474-4912-b36c-d4e2a73e3a1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ad274fb-c6a4-4230-a95b-e07097012a3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c3c4f3e-7254-4b65-8a52-06c29389dc24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea04c6a-18d8-4bb7-9f97-a95016f24e71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9313e22e-05c3-44b0-bf53-1c5569e1b774");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9445c4cd-5fe5-4c2a-8437-6dcdc738bf01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "945bfc37-cd33-4518-87bf-5479311ea96f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97ed3b93-fb1f-4243-b286-ab5f0de17fd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a6e6f84-9408-46a1-8f3a-027b429c6993");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d9dda41-d7fc-4b2b-bdc2-ec1927175ce8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0795a96-27e2-4abf-a9c1-609c100a8d61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1a26a67-bbca-460f-b08e-7a78d6a35c63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a60ba0d0-4556-4947-bcb1-e13cc55e4ee1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96143b9-7103-468a-95f1-308b8b8aa200");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa093980-7f6b-4b92-b215-fd7833958817");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aae9d354-91c7-44cb-9df1-db0a6245533a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab3837c4-fdb4-4602-8480-2311cf699f0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afbe1698-1f5f-4757-a75a-0395d3a5e982");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1155231-d69c-44fa-b985-c67a23a9a034");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b228839c-0b53-4da9-ac1c-3d2688c0ba9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b45ca200-578c-4cd3-8e27-ad564d5cb74c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c42ed2-5457-4833-8883-319d5511da63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b72de5b4-3458-4cc7-b56b-855607832fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9debb3d-930e-469f-959b-86ede578d272");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba929648-ef4f-4fc7-a0da-4087847d3817");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baa312fc-da09-4394-badd-d4c43639d16d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bea7e8fb-7051-4c09-a1c2-6a94224d696f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1c12679-b121-400f-bf10-6e1c1a76efd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c37a5f18-76f1-429e-bbb5-e53d8e282833");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c496065b-4ed3-47ab-b96c-ad21ebc0e883");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c516fbef-c3bc-45b4-a50e-6c1273cb4635");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6b58645-2844-4a87-8fc9-0d0cf5a4fd50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7099000-4d08-4de0-8990-48de0bad9709");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caaaa2d3-7a32-4d72-8941-e76f6a018a72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb922ec6-fe32-4232-b48e-69ba6451f46d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd9c935c-32ce-4fe3-bd63-2678913b77a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd46e99-0454-4a10-8e39-3caad5e0363b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf827d64-cb29-44e9-a96f-429513bfb8ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1938bfe-d7a7-46c2-858c-9016d08deabe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d29549db-9374-414b-88a2-4a56ac16ccb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d383dea5-4265-4121-8319-87eb0398a5ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4d93b83-baa7-4465-8224-0495b7f7868c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5eda6f1-14b9-4e25-8779-c6939c7552b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6266fdd-5a7d-4991-8b12-6f415e4c0a1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d86a05bc-26df-41ca-a790-c34a3829b237");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de248982-679f-4cd5-b449-2bd3c2e54577");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5579cd-931e-481b-8236-c03d8a02a997");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfde7490-b117-4c0c-87cb-04830bef4838");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dffe3c4c-b29b-40e9-9ec9-71251bee736d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e39f7025-299d-4d04-9de2-60aa872a64b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d5a776-f32e-46ca-b997-dc7843a50b85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e654242b-4691-4b17-ad30-0b77941ddc8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb22284c-a197-4ddf-b62e-1f1d56c976bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee6d90b2-1514-4c8d-b295-769736140720");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eed83e15-2cb8-4d8d-96ac-87a4dbc1cc7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eefb50ff-c3af-4ed5-80b4-2fb1adcf7212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efbd58b8-5185-4112-b855-b9abc69d046d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0891aa7-9eef-4103-afb0-0ad9b538b7b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1c5948b-d211-4406-82b8-cb76a42596b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3a51574-a98b-49de-a94f-6d45ebb031bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3aa4394-a1f1-475e-9b67-eecc01efff43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4078f4a-4f3d-4bfe-a158-43f9af828d0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f664669b-00cd-487a-92cf-2b50c8f66f5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6e8cdd3-9e97-474a-8f25-4652bb2d8883");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f703ec1c-e29b-4e99-b64a-c7c877193713");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faaa3916-9545-4206-a739-180d27ed8286");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faaf4791-07f2-4c90-a61c-b3201f3b0084");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb74c3d0-9a8c-4971-b740-5c05c39791ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc096dec-c4b4-489a-8c46-523fb93ed2c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc24fcd6-2f09-4a76-96de-66ff2a825561");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff9d05f6-b3d7-4b3e-bd71-68c8afaeb7fd");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "MateriasID",
                table: "Clases");

            migrationBuilder.RenameColumn(
                name: "ReservaID",
                table: "Clases",
                newName: "MateriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Clases_ReservaID",
                table: "Clases",
                newName: "IX_Clases_MateriaID");

            migrationBuilder.AddColumn<int>(
                name: "ClaseID",
                table: "Reservas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Clases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04c5318c-d89d-4d43-9e09-7bbb3479a727", 0, "0c1225ae-d900-4379-9f13-54bf5b2d824f", "rgallo@cumbrescaracas.edu.ve", false, "Gallo", false, null, "Raffaela", "RGALLO@CUMBRESCARACAS.EDU.VE", "RGALLO", null, null, false, "c7b62174-6105-49e2-9f49-5e58cdc405f2", 0, false, "rgallo" },
                    { "05c03e19-15da-4a89-ac1b-8e25aa8c9883", 0, "9f3ab105-4bf9-4b90-b842-8476ec60219b", "gvelandia@cumbrescaracas.edu.ve", false, "Velandia", false, null, "Gabriel", "GVELANDIA@CUMBRESCARACAS.EDU.VE", "GVELANDIA", null, null, false, "51374a62-f14e-4894-8cf2-a37d96abcf40", 0, false, "gvelandia" },
                    { "07ccd2b2-9728-4408-b720-d59594c39b74", 0, "7c98bb7d-b72a-404f-8e80-4b53286f2d4c", "amarzucco@cumbrescaracas.edu.ve", false, "Marzucco", false, null, "Alberto", "AMARZUCCO@CUMBRESCARACAS.EDU.VE", "AMARZUCCO", null, null, false, "de7940d5-ec6f-47a0-97fe-51099f572a20", 0, false, "amarzucco" },
                    { "163bcc38-8582-42ae-ab6c-4f41d0100295", 0, "397d7d3c-fbe6-4745-beae-2d85594dba20", "azambrano@cumbrescaracas.edu.ve", false, "Zambrano", false, null, "Alexis", "AZAMBRANO@CUMBRESCARACAS.EDU.VE", "AZAMBRANO", null, null, false, "c7422ceb-acc2-4e9f-9ce8-80a90d801874", 0, false, "azambrano" },
                    { "1760af59-3ad8-4ada-9432-54f1bfa31e43", 0, "363f42f9-e846-4753-82cc-5b027d4466b4", "gadiaz@cumbrescaracas.edu.ve", false, "Díaz", false, null, "Guadalupe", "GADIAZ@CUMBRESCARACAS.EDU.VE", "GADIAZ", null, null, false, "edcc42d7-fe33-4c24-aa83-ce0d04cacaea", 0, false, "gadiaz" },
                    { "179e99fe-efe1-4760-ab1e-c4fa9a94b3ef", 0, "344e6188-40cb-4110-8c99-7a6dd9832cd8", "syanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Simón", "SYANEZ@CUMBRESCARACAS.EDU.VE", "SYANEZ", null, null, false, "50fb3b7f-26ff-404d-a43c-8f48a6f1a35c", 0, false, "syanez" },
                    { "18532745-82d6-479b-a2cf-dd280af13368", 0, "d4a98286-98fd-4b8c-a109-f60ad815e098", "kbrun@cumbrescaracas.edu.ve", false, "Brun", false, null, "Karina", "KBRUN@CUMBRESCARACAS.EDU.VE", "KBRUN", null, null, false, "99a952ec-db8c-4006-9dad-434f74a1d91f", 0, false, "kbrun" },
                    { "1aa6e31c-262f-422f-9921-75bad7e65f34", 0, "9d4c9e1c-7386-45e0-9ed4-1b04313a5ce1", "ahenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Andrés", "AHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "AHENRIQUEZ", null, null, false, "a6494a94-e0cc-4577-8dc8-5036ac74867d", 0, false, "ahenriquez" },
                    { "1d91b3d6-7103-43c3-88d4-36376ab18b6d", 0, "abef1f65-98a1-451c-abd3-621ee7a6ac71", "javila@cumbrescaracas.edu.ve", false, "Avila", false, null, "Jhonny", "JAVILA@CUMBRESCARACAS.EDU.VE", "JAVILA", null, null, false, "a91ea899-64d4-434c-81ee-0ce38c85f286", 0, false, "javila" },
                    { "1dea203c-72eb-4481-a5d7-44e5539a41b0", 0, "d18a79f3-8544-42e6-9c99-ef7a3a13863d", "dperrucci@cumbrescaracas.edu.ve", false, "Perrucci Meló", false, null, "Daniela Alejandra", "DPERRUCCI@CUMBRESCARACAS.EDU.VE", "DPERRUCCI", null, null, false, "9019288c-8e08-4c72-94b3-2b34ac91fc17", 0, false, "dperrucci" },
                    { "1fd5f3a8-6aee-41ed-a6a5-ef7059eba083", 0, "119a9091-2269-48ae-82a8-11aee3d4f445", "loumarangulo@gmail.com", false, "Angulo", false, null, "Verónica", "LOUMARANGULO@GMAIL.COM", "LOUMARANGULO", null, null, false, "badb954c-685a-40ed-9ef1-060331d81465", 0, false, "loumarangulo" },
                    { "21101e42-2173-4e17-8cdc-db7c182d6869", 0, "663ffc9d-af7f-4172-889d-7eb30fa26367", "tayling_steffany@hotmail.com", false, "Galindo", false, null, "Tayling", "TAYLING_STEFFANY@HOTMAIL.COM", "TAYLING_STEFFANY", null, null, false, "6c7a28e6-f6fa-4358-8aa9-d008e85cee33", 0, false, "tayling_steffany" },
                    { "217a8633-e6f0-4a82-8647-9c827e4cbe7d", 0, "728af5c9-571a-4709-b7f9-69cfdad623d7", "rdosreis@cumbrescaracas.edu.ve", false, "Dos Reis", false, null, "Rosa", "RDOSREIS@CUMBRESCARACAS.EDU.VE", "RDOSREIS", null, null, false, "09253a5b-9c19-409c-aec8-deb7aa714538", 0, false, "rdosreis" },
                    { "2327bbf4-e75f-4dfa-9b31-8df1b8d19ea3", 0, "e0d64022-bb70-4adb-af8c-68ea10c9df91", "lduquem@cumbrescaracas.edu.ve", false, "Duque", false, null, "Lilibeth", "LDUQUEM@CUMBRESCARACAS.EDU.VE", "LDUQUEM", null, null, false, "b36504dd-aad7-401a-9841-926e5e37b6d9", 0, false, "lduquem" },
                    { "246a7a65-59ea-446c-9b05-065cb52aa04e", 0, "1cd74d52-ab55-4cf2-a26b-a61db0d2b124", "jcaraballo@cumbrescaracas.edu.ve", false, "Caraballo", false, null, "José", "JCARABALLO@CUMBRESCARACAS.EDU.VE", "JCARABALLO", null, null, false, "5bf9c4c1-9337-4bf7-a12d-d396aaa3b83e", 0, false, "jcaraballo" },
                    { "26360a8e-7f2b-4608-9760-c0b3d787ed62", 0, "460a4a97-3d6e-47f1-a020-ff04bbe8486b", "grodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Guida", "GRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "GRODRIGUEZ", null, null, false, "a199fcef-924f-4b7a-9f26-bc460f06a338", 0, false, "grodriguez" },
                    { "27ab85a4-9af2-40b1-991e-df1d76743e4a", 0, "51d99a19-e587-4434-b0ed-62dbff588881", "blosada@cumbrescaracas.edu.ve", false, "Losada", false, null, "Beatriz", "BLOSADA@CUMBRESCARACAS.EDU.VE", "BLOSADA", null, null, false, "91c9508f-a315-42b3-a993-ade941a2e408", 0, false, "blosada" },
                    { "27deaee3-d337-44e9-9049-9a0368cb17fd", 0, "65b158a1-48a8-4dd6-b895-43edfb8c8357", "grando@cumbrescaracas.edu.ve", false, "Rando", false, null, "Gabriela", "GRANDO@CUMBRESCARACAS.EDU.VE", "GRANDO", null, null, false, "15cb3fc2-9a7d-427e-81ac-89ed54a79729", 0, false, "grando" },
                    { "2a4658b4-e508-4659-95c4-d976a91cf418", 0, "7e8432e6-e6a8-420b-8ee3-4a26b2364122", "rangeli@cumbrescaracas.edu.ve", false, "Rene", false, null, "Angeli", "RANGELI@CUMBRESCARACAS.EDU.VE", "RANGELI", null, null, false, "7ba14dc2-d3c3-4645-8b92-bd7bd31be625", 0, false, "rangeli" },
                    { "2bc96170-dcbb-4c5d-b540-1ec3c7724919", 0, "644d09ff-2865-42c1-9502-3c5fc0082a75", "mcalzadilla@cumbrescaracas.edu.ve", false, "Calzadilla", false, null, "María Alejandra", "MCALZADILLA@CUMBRESCARACAS.EDU.VE", "MCALZADILLA", null, null, false, "bf27962f-2816-449f-9f2c-b9eb7d16fcc0", 0, false, "mcalzadilla" },
                    { "2be1d632-7cf2-44a3-88b9-df5a0927c106", 0, "799b661d-d271-4493-bbdc-ca0eaedbc6a8", "jmontilla@cumbrescaracas.edu.ve", false, "Montilla", false, null, "Juan Izquierdo", "JMONTILLA@CUMBRESCARACAS.EDU.VE", "JMONTILLA", null, null, false, "112e5aa7-b86c-4088-a64f-246a3f12a8ec", 0, false, "jmontilla" },
                    { "2bef021a-a909-4ed8-a139-bee1a1350681", 0, "af74b496-49a7-487a-af61-22d032adee92", "mtortosa@cumbrescaracas.edu.ve", false, "Tortosa", false, null, "Maria Gabriela", "MTORTOSA@CUMBRESCARACAS.EDU.VE", "MTORTOSA", null, null, false, "8996f30b-ec0b-493e-8756-0d1f553a2149", 0, false, "mtortosa" },
                    { "2e713b64-427a-4380-81aa-52b319361506", 0, "4bee576e-785d-411c-817d-1574127eabbd", "mitriago@cumbrescaracas.edu.ve", false, "Itriago", false, null, "Marianna", "MITRIAGO@CUMBRESCARACAS.EDU.VE", "MITRIAGO", null, null, false, "737e6437-d232-48c5-81a7-d004958bf3f3", 0, false, "mitriago" },
                    { "2f450fa8-41e9-47fa-81fb-d14f0d0d7510", 0, "25cba01c-e3d5-484b-90f9-24611ce312e4", "tgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Teresita", "TGARCIA@CUMBRESCARACAS.EDU.VE", "TGARCIA", null, null, false, "cb1cf530-729c-4dca-aeb7-742fff0025bf", 0, false, "tgarcia" },
                    { "324bcf23-95f9-4adb-8dba-f6251294fff1", 0, "b38c677d-2a8a-4512-a443-d01482b98f00", "cchacon@cumbrescaracas.edu.ve", false, "Chacón", false, null, "Claudia", "CCHACON@CUMBRESCARACAS.EDU.VE", "CCHACON", null, null, false, "f507db86-2a27-460f-ba6a-7124f0cd903d", 0, false, "cchacon" },
                    { "32e62e5f-fb16-46a6-9308-81ed2b8d737e", 0, "5843b57d-8ca2-4d2a-95cc-2366f1ee9b56", "gaortega@cumbrescaracas.edu.ve", false, "Ortega", false, null, "Gabriela", "GAORTEGA@CUMBRESCARACAS.EDU.VE", "GAORTEGA", null, null, false, "bd3171fd-cfad-496c-8e0a-b1f53307361a", 0, false, "gaortega" },
                    { "34f99f7b-7cf4-4b08-9d2a-9bf12ca897b0", 0, "fae3f1e4-3322-4152-bcd7-f1d756bba84c", "cadiaz@arcol.org", false, "Díaz", false, null, "Carolina", "CADIAZ@ARCOL.ORG", "CADIAZ", null, null, false, "50f5c70c-eda6-4b0c-961a-016a613f945f", 0, false, "cadiaz" },
                    { "35939959-a846-4907-a2ab-48259733417a", 0, "5cc8c187-ed26-49a0-9636-bd722f4db71a", "jduran@cumbrescaracas.edu.ve", false, "Duran", false, null, "Jeniffer", "JDURAN@CUMBRESCARACAS.EDU.VE", "JDURAN", null, null, false, "79bc85b4-d32b-4dc6-8515-1e78a8236e87", 0, false, "jduran" },
                    { "364b3174-19ed-45ec-b91d-4a8a7c466d3f", 0, "78c28b4f-a8dc-4d44-bec3-d617f3de1ebe", "yoropeza@cumbrescaracas.edu.ve", false, "Oropeza", false, null, "Yndhira", "YOROPEZA@CUMBRESCARACAS.EDU.VE", "YOROPEZA", null, null, false, "1c2f4920-c18a-432f-84ee-6567dafd0cca", 0, false, "yoropeza" },
                    { "36dbc44a-841f-43ce-9a8a-fedc1418b960", 0, "01611428-e2e5-4a2e-92d0-eb1f119b4529", "jtoro@cumbrescaracas.edu.ve", false, "Toro", false, null, "Jorge", "JTORO@CUMBRESCARACAS.EDU.VE", "JTORO", null, null, false, "0049f594-e0ea-4fcb-8edc-2e805c5858d7", 0, false, "jtoro" },
                    { "3749cdbb-74ae-4192-a68b-f55c2d597d1f", 0, "ef497140-3911-4ae6-ad0b-132026410412", "ecalvo@cumbrescaracas.edu.ve", false, "Calvo", false, null, "Esther", "ECALVO@CUMBRESCARACAS.EDU.VE", "ECALVO", null, null, false, "2cf38836-3144-4d94-b58f-72c390e44300", 0, false, "ecalvo" },
                    { "385c5c34-7139-41e9-8f82-1d1bce0eb492", 0, "91a86660-d4a2-4363-b388-dd7a9d506ee7", "zrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Zamanta", "ZRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ZRODRIGUEZ", null, null, false, "8c2dab0c-bf11-4e27-8183-211efe233498", 0, false, "zrodriguez" },
                    { "389607e9-f3bf-461c-9736-8032cff6b9ee", 0, "08698988-4862-4b57-9c7f-290db0d27088", "afeola@cumbrescaracas.edu.ve", false, "Feola Carrasquel", false, null, "Alfonso Eloy", "AFEOLA@CUMBRESCARACAS.EDU.VE", "AFEOLA", null, null, false, "a266d480-7d3e-4907-87d4-e4a530673bd7", 0, false, "afeola" },
                    { "39793b16-f1c1-4100-955f-2ece0fe47b3a", 0, "1f10bba6-25fd-4b1e-95bb-140eaee83dae", "ldelgado@cumbrescaracas.edu.ve", false, "Delgado", false, null, "Leiza", "LDELGADO@CUMBRESCARACAS.EDU.VE", "LDELGADO", null, null, false, "3d6ed738-f390-4425-b98e-74df3b31415c", 0, false, "ldelgado" },
                    { "39d0c8aa-2163-428c-81da-35eae9448b45", 0, "4989f93e-d36c-40e9-a028-bc8c9cf05c96", "imaurovich@cumbrescaracas.edu.ve", false, "Maurovich", false, null, "Isabel", "IMAUROVICH@CUMBRESCARACAS.EDU.VE", "IMAUROVICH", null, null, false, "8e31e217-538c-4d8d-89f6-086a37564f57", 0, false, "imaurovich" },
                    { "3aa53ec5-95f6-4f70-8279-9120cb3ff88f", 0, "8e55b179-f49e-42df-bc89-1fd46a427634", "jaleman@cumbrescaracas.edu.ve", false, "Alemán", false, null, "José Antonio", "JALEMAN@CUMBRESCARACAS.EDU.VE", "JALEMAN", null, null, false, "1083defa-ff08-450b-bcbd-68013f5ae42f", 0, false, "jaleman" },
                    { "3c72b541-8e00-4723-bbea-23f8a3b8ec26", 0, "78b8ac07-9b31-451d-9619-f2688f9f1d12", "jumarmol@cumbrescaracas.edu.ve", false, "Mármol", false, null, "Juliana", "JUMARMOL@CUMBRESCARACAS.EDU.VE", "JUMARMOL", null, null, false, "4e17a1e4-5da8-4baf-bb33-2ba48ec7f8b4", 0, false, "jumarmol" },
                    { "3f503236-ba3e-4cb0-a2d6-38aa0f07c1e1", 0, "baabce00-0d17-458c-a692-ebecd27c1bdf", "mariselayjorge@hotmail.com", false, "Rocha", false, null, "Marisela", "MARISELAYJORGE@HOTMAIL.COM", "MARISELAYJORGE", null, null, false, "1dc73148-fe50-4dce-be28-b0be2ce75dd6", 0, false, "mariselayjorge" },
                    { "40a63081-cf80-4ac7-9e81-79505f0155e3", 0, "d8984648-362f-46e8-9551-d9d4511a08cf", "nmagdaleno@cumbrescaracas.edu.ve", false, "Magdaleno", false, null, "Nancy", "NMAGDALENO@CUMBRESCARACAS.EDU.VE", "NMAGDALENO", null, null, false, "327753e2-5144-43a3-882c-49ddb97cabaa", 0, false, "nmagdaleno" },
                    { "4117f488-8fab-4163-b629-ee8022b56c53", 0, "6c60a610-dff2-4b4b-a297-f6f3dfdd6fd1", "jguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "Jessica", "JGUILLEN@CUMBRESCARACAS.EDU.VE", "JGUILLEN", null, null, false, "ddb2a421-086c-44e0-91b7-9232ff448ff4", 0, false, "jguillen" },
                    { "4147d1eb-7156-4645-8b95-7c6f68e2562d", 0, "11d5e901-a757-411c-9c50-fe86fb4465ea", "pfernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Paula", "PFERNANDEZ@CUMBRESCARACAS.EDU.VE", "PFERNANDEZ", null, null, false, "98ec1ae6-0a75-44ae-8a60-4b2143eb3454", 0, false, "pfernandez" },
                    { "420bfac8-4e7d-4003-9ccc-857d0007008d", 0, "fbcafd94-8f29-44eb-96ea-6251e4fb9627", "lurueta@cumbrescaracas.edu.ve", false, "Urueta", false, null, "Leonidas", "LURUETA@CUMBRESCARACAS.EDU.VE", "LURUETA", null, null, false, "e566dd09-f895-4e50-9e16-e0741b446db8", 0, false, "lurueta" },
                    { "43b2f79b-030f-48f7-bbd9-6d258d549e32", 0, "6e0a1f13-5243-439f-8cdf-5025e0c3e91f", "ninosuanno@cumbrescaracas.edu.ve", false, "Suanno", false, null, "Joaquin", "NINOSUANNO@CUMBRESCARACAS.EDU.VE", "NINOSUANNO", null, null, false, "b2377dcc-d87b-4b7e-b1b8-7323f3a6bbe0", 0, false, "ninosuanno" },
                    { "442419cd-4a67-43df-b0fa-8352a6225f1f", 0, "d05299a9-5e10-4b1d-8d8c-a2087190cf8a", "larellano@legionaries.org", false, "Arellano", false, null, "Leonardo", "LARELLANO", "LARELLANO@LEGIONARIES.ORG", null, null, false, "dba2d0cd-5610-4876-bcad-30c5d9eea030", 0, false, "larellano" },
                    { "451d6155-e120-4ede-8912-780be14484ea", 0, "7b31ae1c-3d77-4ae2-abb9-566904db316d", "cchirinos@cumbrescaracas.edu.ve", false, "Chirinos", false, null, "Christian", "CCHIRINOS@CUMBRESCARACAS.EDU.VE", "CCHIRINOS", null, null, false, "94549728-bdd3-4914-8719-893fe5217c4c", 0, false, "cchirinos" },
                    { "45db9c4f-7e3d-4d8b-ba28-10ea92af55d7", 0, "096feca1-f4c6-45fd-a839-04a47405bc43", "rpan@cumbrescaracas.edu.ve", false, "Dávila", false, null, "Rebeca", "RPAN@CUMBRESCARACAS.EDU.VE", "RPAN", null, null, false, "8e56614d-bb31-4c4f-943e-df2dce5a9568", 0, false, "rpan" },
                    { "463c50b8-1113-462d-aeb3-2a7130227ac6", 0, "063f3ba5-7f81-44e5-b14c-cdde1bf5750a", "jthimotheo@cumbrescaracas.edu.ve", false, "Thimotheo", false, null, "José Carlos", "JTHIMOTHEO@CUMBRESCARACAS.EDU.VE", "JTHIMOTHEO", null, null, false, "86139aba-b30e-4137-ae0a-463c4fe4871a", 0, false, "jthimotheo" },
                    { "46af9dd0-0c1c-43e2-8515-e987c2722a74", 0, "95ef7a58-3ed4-4d7c-b080-35d8d15a36f4", "gcardas@cumbrescaracas.edu.ve", false, "Cardas", false, null, "Gwen", "GCARDAS@CUMBRESCARACAS.EDU.VE", "GCARDAS", null, null, false, "e8075b6d-0768-48c9-aec7-18a21a59eff8", 0, false, "gcardas" },
                    { "47459420-b320-490f-a761-912415b28488", 0, "108a45c0-c3de-4a03-a8b4-f3e762e2d62a", "imejias@cumbrescaracas.edu.ve", false, "Mejias", false, null, "Iliana", "IMEJIAS@CUMBRESCARACAS.EDU.VE", "IMEJIAS", null, null, false, "84468b93-be96-45e2-a331-c7910ad97b51", 0, false, "imejias" },
                    { "4762b663-c213-4e43-bcc8-efb9945b70e7", 0, "310a01df-8e6d-4987-87b5-8511ea2f231f", "mdjekki@cumbrescaracas.edu.ve", false, "Djekki", false, null, "Marianela", "MDJEKKI@CUMBRESCARACAS.EDU.VE", "MDJEKKI", null, null, false, "8aedfb5f-3c0d-4fc4-a218-90b2c51d5240", 0, false, "mdjekki" },
                    { "4845db00-23c9-4001-8b82-8365c9311126", 0, "8653c474-fffc-437e-b736-5b2e6a971417", "jgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Jesús", "JGARCIA@CUMBRESCARACAS.EDU.VE", "JGARCIA", null, null, false, "c3d47b5d-bcf4-40df-b3d3-22521ebdf930", 0, false, "jgarcia" },
                    { "4c85c081-7803-4e81-997f-bba5a04b3b19", 0, "8ba660d4-de0c-4920-8f0c-38194fe8b641", "msous@cumbrescaracas.edu.ve", false, "Sous", false, null, "Morela", "MSOUS@CUMBRESCARACAS.EDU.VE", "MSOUS", null, null, false, "1828896e-a01b-4a81-83c6-e244ff585f67", 0, false, "msous" },
                    { "4cb0c7fe-b741-4d90-8f3e-d98155764d7b", 0, "6c4b78d4-1d0d-4661-a593-4ebfccb12c04", "mcardona@cumbrescaracas.edu.ve", false, "Cardona", false, null, "Marisela", "MCARDONA@CUMBRESCARACAS.EDU.VE", "MCARDONA", null, null, false, "04e4bb19-af6d-4809-a915-54f9feb2f48b", 0, false, "mcardona" },
                    { "50c5b28f-da00-4ad2-8fd2-5e24991859cc", 0, "2788eaca-a0cb-461a-9542-ba437c86e421", "jmgutierrez@cumbrescracas.edu.ve", false, "Gutierrez", false, null, "José Manuel", "JMGUTIERREZ@CUMBRESCRACAS.EDU.VE", "JMGUTIERREZ", null, null, false, "10fe92ee-f358-4a6e-965a-b491dac83cbf", 0, false, "jmgutierrez" },
                    { "52e0837d-35a6-4eae-bc49-99bcd6512e6a", 0, "59105fb2-9842-43ec-8754-a221f31a5d0d", "mvelasquez@cumbrescaracas.edu.ve", false, "Velásquez", false, null, "Perla Marina", "MVELASQUEZ@CUMBRESCARACAS.EDU.VE", "MVELASQUEZ", null, null, false, "dbc1e5da-874d-4edf-80d5-7e831f3d51d9", 0, false, "mvelasquez" },
                    { "54cb73fc-1537-46a1-a5d3-becb6cb55127", 0, "13572856-0bc4-434c-a43f-3447fe3603b8", "ilugo@cumbrescaracas.edu.ve", false, "Lugo Caravallo", false, null, "Ismael José", "ILUGO@CUMBRESCARACAS.EDU.VE", "ILUGO", null, null, false, "6486dd2e-4380-4541-8b61-a2e7231f931f", 0, false, "ilugo" },
                    { "586a34c8-fd44-41f5-84d2-eb2589f863e7", 0, "dff4945d-d963-4feb-8ea1-5b894527005c", "mrocha@cumbrescaracas.edu.ve", false, "Vizcarrondo", false, null, "Marisela", "MROCHA@CUMBRESCARACAS.EDU.VE", "MROCHA", null, null, false, "b693308d-de92-4afd-8f23-fcbeffc1babd", 0, false, "mrocha" },
                    { "58ee8d1e-c91c-4989-bc17-2b1b9f2fe932", 0, "1a87d36b-8529-4fa1-981c-de81d5c01fc4", "sharrisson@cumbrescaracas.edu.ve", false, "Harrisson", false, null, "Selene", "SHARRISSON@CUMBRESCARACAS.EDU.VE", "SHARRISSON", null, null, false, "b676d523-71d9-4522-b61e-27fe337b1e39", 0, false, "sharrisson" },
                    { "59d06da2-2728-414d-952f-aab56ee669c2", 0, "a70735a1-f57e-4afd-8e90-47a5a0f4e8f3", "aortuno@cumbrescaracas.edu.ve", false, "Ortuño", false, null, "Andreulys", "AORTUNO@CUMBRESCARACAS.EDU.VE", "AORTUNO", null, null, false, "20c2f148-1b6d-4a5c-8fbd-58bc50c515f1", 0, false, "aortuno" },
                    { "5d4b57e8-4a9d-4fe2-82e3-e2cb576aa010", 0, "077aac2f-81fe-4cd2-ae5b-608b01f35d74", "legutierrez@cumbrescaracas.edu.ve", false, "Gutiérrez", false, null, "Leonardo", "LEGUTIERREZ@CUMBRESCARACAS.EDU.VE", "LEGUTIERREZ", null, null, false, "5ce4e497-5254-4e1f-8e8f-3fa71efd89b1", 0, false, "legutierrez" },
                    { "614be560-8758-47e7-bd86-71ab073497ae", 0, "002bf4a6-8dbc-4332-8a99-8eedc060639f", "maherrera@cumbrescaracas.edu.ve", false, "Herrera Bello", false, null, "María Alejandra", "MAHERRERA@CUMBRESCARACAS.EDU.VE", "MAHERRERA", null, null, false, "4f42dfd7-1d7c-4101-bb95-5a6c07bdbd35", 0, false, "maherrera" },
                    { "62be3207-8bd4-4149-93ab-9976758d1652", 0, "82c93f1e-45f2-4696-bb55-952ee246e794", "mvillasmil@cumbrescaracas.edu.ve", false, "Villasmil", false, null, "María Gabriela", "MVILLASMIL@CUMBRESCARACAS.EDU.VE", "MVILLASMIL", null, null, false, "ec1f87b5-94b9-455c-b960-2ab61f6b85df", 0, false, "mvillasmil" },
                    { "63716184-f298-469c-b916-a60592f8cff0", 0, "b9015885-9c48-45a6-a6b9-02359607f1d2", "mrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "María Corina", "MRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MRODRIGUEZ", null, null, false, "c689ef36-caf6-44d3-ae16-47d22f433804", 0, false, "mrodriguez" },
                    { "66bbfded-6aff-4878-9a89-0c8133edb427", 0, "e9f80c46-2fe9-4f59-8038-722659741363", "alovera@cumbrescarcas.edu.ve", false, "Lovera", false, null, "Adriana", "ALOVERA@CUMBRESCARCAS.EDU.VE", "ALOVERA", null, null, false, "61ccfd66-628f-4b8e-8c76-b6c04ff5b18f", 0, false, "alovera" },
                    { "670ea2b3-1aba-433e-94b4-04cabc614927", 0, "727da29b-37c8-4c98-81e7-cdd10bff1fd5", "cdearmas@cumbrescaracas.edu.ve", false, "De Armas", false, null, "Cristina", "CDEARMAS@CUMBRESCARACAS.EDU.VE", "CDEARMAS", null, null, false, "1c0f1e84-a1f2-477e-873e-7d64a802ef42", 0, false, "cdearmas" },
                    { "67a3cf44-7646-465e-be39-dd8b624784b4", 0, "29119a2d-d318-4665-b11c-eb16038d7e09", "acorton@cumbrescaracas.edu.ve", false, "Corton", false, null, "Andrea", "ACORTON@CUMBRESCARACAS.EDU.VE", "ACORTON", null, null, false, "a05988b7-aae7-474e-92f7-4bb743280c82", 0, false, "acorton" },
                    { "682db033-e1b9-4f56-b4f1-5accf32a8002", 0, "3fef3c8e-4e6c-481c-91ff-43dcd3d7618b", "julieta.elena.rivas@gmail.com", false, "Rivas", false, null, "Julieta", "JULIETA.ELENA.RIVAS@GMAIL.COM", "JULIETA.ELENA.RIVAS", null, null, false, "fb1295dd-f1c3-4401-889e-272fcac14f07", 0, false, "julieta.elena.rivas" },
                    { "69baf96d-a188-408b-bf35-14614ed898a6", 0, "e93844eb-0a2d-49ce-91a4-a4cf8912261d", "arodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Ana", "ARODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ARODRIGUEZ", null, null, false, "24d1c177-07a4-4abb-87aa-321233782ddf", 0, false, "arodriguez" },
                    { "6a949eea-b6a0-47c2-b126-6325b0210807", 0, "24834123-ae2a-47ff-bc6f-b39568328af0", "mdiaz@cumbrescaracas.edu.ve", false, "Diaz", false, null, "Maria Fernanda", "MDIAZ@CUMBRESCARACAS.EDU.VE", "MDIAZ", null, null, false, "d02e2839-f9f0-4d39-94d9-58f79813b7bd", 0, false, "mdiaz" },
                    { "7019ee69-bbbe-4fc6-95c3-49f63d0ecbd4", 0, "068d82f3-c126-40af-84b0-828d2a5ba3e5", "cgomez@cumbrescaracas.edu.ve", false, "Gomez", false, null, "Carlos", "CGOMEZ@CUMBRESCARACAS.EDU.VE", "CGOMEZ", null, null, false, "f6e713c1-2c28-4774-aee4-0f75ad47fd41", 0, false, "cgomez" },
                    { "70378d7b-2a8a-410b-b7f5-dd11d91350f6", 0, "478eee1e-b23a-4240-bcaf-b3a98b96b7f9", "agalviz@cumbrescaracas.edu.ve", false, "Galviz", false, null, "Adrian", "AGALVIZ@CUMBRESCARACAS.EDU.VE", "AGALVIZ", null, null, false, "ca7f5ce7-69a5-4411-b683-83bfb021531c", 0, false, "agalviz" },
                    { "7268c40f-cf3f-44e8-b529-64b6a52440b7", 0, "a5465694-4037-4322-8a5a-4c7be437962c", "apinero@cumbrescaracas.edu.ve", false, "Piñero", false, null, "Adriana", "APINERO@CUMBRESCARACAS.EDU.VE", "APINERO", null, null, false, "8a4fba3b-927b-4357-8914-c3d1ab688749", 0, false, "apinero" },
                    { "733c4c86-4851-4edd-835c-6d4e9d46392c", 0, "b0da69cf-0211-4438-a2c5-c6199c39171e", "leninbetancourt@yahoo.es", false, "Betancourt", false, null, "Lenin", "LENINBETANCOURT@YAHOO.ES", "LENINBETANCOURT", null, null, false, "913da19d-0d1e-4895-9618-ce5cdafc99ce", 0, false, "leninbetancourt" },
                    { "73c65f20-79f9-4bad-8cf9-ee2d46fe304b", 0, "5c5d3cf4-33f7-4001-b8af-470e4d987404", "adipentima@cumbrescaracas.edu.ve", false, "Vona", false, null, "América", "ADIPENTIMA@CUMBRESCARACAS.EDU.VE", "ADIPENTIMA", null, null, false, "3b3a9637-e820-413c-9f18-859e284df503", 0, false, "adipentima" },
                    { "76e52545-e878-473f-9490-3b35b7fc962b", 0, "c594e85a-eb08-4c6f-9142-accc332f2e65", "carlosurdaneta@cumbrescaracas.edu.ve", false, "Urdaneta", false, null, "Carlos", "CARLOSURDANETA@CUMBRESCARACAS.EDU.VE", "CARLOSURDANETA", null, null, false, "6923ec87-0ff6-42c6-8010-2d1fef235540", 0, false, "carlosurdaneta" },
                    { "77ac976b-cf9f-43f0-88ac-0fd49861b4e1", 0, "255cfe1c-c130-4158-b782-b9dbd176af5f", "dmoreau@cumbrescaracas.edu.ve", false, "Moreau", false, null, "Desiree", "DMOREAU@CUMBRESCARACAS.EDU.VE", "DMOREAU", null, null, false, "5df2add4-ff98-48ec-aa46-319ef6650f2b", 0, false, "dmoreau" },
                    { "784f9311-cdd8-4e7c-b930-2d8e2e00ae23", 0, "9bbb7945-7c9f-4920-ab0f-ed4c4d703ae8", "mestevez@cumbrescaracas.edu.ve", false, "Estévez", false, null, "María Graciela", "MESTEVEZ@CUMBRESCARACAS.EDU.VE", "MESTEVEZ", null, null, false, "f716d995-83b8-4ea5-950f-0486d68bfd87", 0, false, "mestevez" },
                    { "7a24a647-9db6-4aa3-9c30-4b7ada91f688", 0, "a62be13b-3cc7-41d3-95bb-5e3cc5c62fb8", "mhernandez@cumbrescaracas.edu.ve", false, "Hernandez", false, null, "Monica", "MHERNANDEZ@CUMBRESCARACAS.EDU.VE", "MHERNANDEZ", null, null, false, "27eb232e-6e43-4e46-9228-bf1fa550e176", 0, false, "mhernandez" },
                    { "7cdff295-70d8-461d-b912-5e3f795610e3", 0, "19d6a484-c1a4-40d9-9cb5-6cc914d6905d", "melavalladares@gmail.com", false, "Valladares", false, null, "Melanie", "MELAVALLADARES@GMAIL.COM", "MELAVALLADARES", null, null, false, "d4688a92-1f86-4068-b704-0a83f7305c87", 0, false, "melavalladares" },
                    { "7dc7e18f-e8b4-4fb5-b9be-708aa627e261", 0, "02d0ded8-3d72-4a5a-bbe3-d3fd43a5b347", "dlucero@cumbrescaracas.edu.ve", false, "Lucero", false, null, "Deyvi", "DLUCERO@CUMBRESCARACAS.EDU.VE", "DLUCERO", null, null, false, "920fee1d-d66d-45f0-8322-9e5a3cc33903", 0, false, "dlucero" },
                    { "8068203e-a0f8-4b38-9633-998720689676", 0, "28338ad0-9778-496a-a291-f6113f99ffb1", "csuarez@cumbrescaracas.edu.ve", false, "Suárez", false, null, "César", "CSUAREZ@CUMBRESCARACAS.EDU.VE", "CSUAREZ", null, null, false, "bdd78a5d-db89-4586-b611-32642205ae5b", 0, false, "csuarez" },
                    { "82221a1e-b2be-49a8-9b21-25c935b5ef4b", 0, "39c377cb-ccbc-4240-bf8f-000b75f1592f", "gsalas@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriel", "GSALAS@CUMBRESCARACAS.EDU.VE", "GSALAS", null, null, false, "fc9edbd0-c6e8-46cb-95ee-a8e9a8e1f34c", 0, false, "gsalas" },
                    { "828a4df0-f828-406e-9206-59dd3914083b", 0, "9af23a2c-eb10-4a02-a09e-7a7cfffb95bf", "mpenaranda@cumbrescaracas.edu.ve", false, "Peñaranda", false, null, "María Antonieta", "MPENARANDA@CUMBRESCARACAS.EDU.VE", "MPENARANDA", null, null, false, "b8a8cd8a-644b-4484-ace9-7c1d7008704f", 0, false, "mpenaranda" },
                    { "85ef9a7c-b986-4983-9315-30f501c55ea6", 0, "43a1a9eb-7aba-47f7-8a97-9ca6acd28665", "iluca@cumbrescaracas.edu.ve", false, "Luca", false, null, "Ivette", "ILUCA@CUMBRESCARACAS.EDU.VE", "ILUCA", null, null, false, "2cde46d0-8d87-4063-8057-610988203b15", 0, false, "iluca" },
                    { "871dc97a-1a1d-439a-8899-2fa7e8136534", 0, "a0b71fc6-3a0b-43f9-8860-8425b48d9176", "mcapuz@cumbrescaracas.edu.ve", false, "Capuz", false, null, "Marycel", "MCAPUZ@CUMBRESCARACAS.EDU.VE", "MCAPUZ", null, null, false, "b1423f9e-9d6e-46af-9ec8-bad99287fd62", 0, false, "mcapuz" },
                    { "872ad393-38d2-4836-8637-90ab56a37b2c", 0, "e04350b4-dc66-4ada-ac5c-e149a190bb03", "abedetti@cumbrescaracas.edu.ve", false, "Bedetti", false, null, "Alfredo", "ABEDETTI@CUMBRESCARACAS.EDU.VE", "ABEDETTI", null, null, false, "f3df1301-e331-4b48-8966-51a373a838de", 0, false, "abedetti" },
                    { "87cbb38e-7752-491b-9af4-c888ca0cd2d3", 0, "8be491c8-b3b0-43b5-b2a3-8f3f0fb62711", "rofernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Rosmary", "ROFERNANDEZ@CUMBRESCARACAS.EDU.VE", "ROFERNANDEZ", null, null, false, "14f0dda5-1472-404f-a38d-31bff0f0cbba", 0, false, "rofernandez" },
                    { "8845e856-0ffc-432f-b707-a7708fd4993e", 0, "3f7f8b01-9d68-493e-9a30-0fd2d506ed98", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", "NADORNO@CUMBRESCARACAS.EDU.VE", "NADORNO", null, null, false, "0d89041f-e2d0-4cef-8c36-e99c45299248", 0, false, "nadorno" },
                    { "89cc38df-b54e-42df-b660-dcdc14aa01a6", 0, "08cacca8-18c8-470d-9892-56c4c2627cf7", "lrodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Luis Antonio", "LRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "LRODRIGUEZ", null, null, false, "f265bbce-4c06-4728-9f88-127f54341826", 0, false, "lrodriguez" },
                    { "8a29622e-285f-4107-8f55-d4bf0adbb07d", 0, "7943f69f-7495-41b0-a620-374bc574f87e", "rsanchez@cumbrescaracas.edu.ve", false, "Sánchez", false, null, "Rosario", "RSANCHEZ@CUMBRESCARACAS.EDU.VE", "RSANCHEZ", null, null, false, "2e8a0390-c213-42e0-bcf2-b32a2c4651e2", 0, false, "rsanchez" },
                    { "8a32c559-19fb-4c21-b06b-36ec0c742df5", 0, "d6dfb9a4-6d65-4473-8a78-9ba3ab6794fd", "ysantaella@cumbrescaracas.edu.ve", false, "Santaella", false, null, "Yajaira", "YSANTAELLA@CUMBRESCARACAS.EDU.VE", "YSANTAELLA", null, null, false, "a9ad266c-ba9f-4de6-ab76-1af006b67e85", 0, false, "ysantaella" },
                    { "8a58d771-9a1c-4889-a236-3b4ac760f08c", 0, "52d6cae9-963a-4a74-a88e-15ec778e6772", "ltavares@cumbrescaracas.edu.ve", false, "Tavares Goncalves", false, null, "Lisette", "LTAVARES@CUMBRESCARACAS.EDU.VE", "LTAVARES", null, null, false, "1ece9f0d-8495-4d02-8ed6-121baa87a2e1", 0, false, "ltavares" },
                    { "8d011773-a1f1-4b45-a432-0d0f5964ed68", 0, "6d2264fd-692f-4e4b-b6e0-5d902c738161", "jmarti@legionaries.org", false, "Martí", false, null, "Julio César", "JMARTI@LEGIONARIES.ORG", "JMARTI", null, null, false, "545420f9-4ccd-485d-beac-a8774107f864", 0, false, "jmarti" },
                    { "8dcd00c6-7bdb-4d24-a94d-726b14e54574", 0, "fb75b2a3-12da-4195-ab34-7835f3de43de", "gcarvajal@cumbrescaracas.edu.ve", false, "Carvajal", false, null, "Gabriela", "GCARVAJAL@CUMBRESCARACAS.EDU.VE", "GCARVAJAL", null, null, false, "c5567ce8-526c-4570-a877-2fba197f0a39", 0, false, "gcarvajal" },
                    { "8de46a92-cf21-4a7b-a3d1-ae6a6e77b6b9", 0, "bf626832-cfe5-4b93-bc86-0e3e460726d6", "irangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Ignacio", "IRANGEL@CUMBRESCARACAS.EDU.VE", "IRANGEL", null, null, false, "8dcf03d3-2ba3-487e-a7ec-626c99948350", 0, false, "irangel" },
                    { "8e463f9b-282d-4a59-b52c-2edfcd016fc0", 0, "7f199d5a-c59e-4e1c-b212-6514b740f627", "arojas@arcol.org", false, "Rojas", false, null, "Andy", "AROJAS@ARCOL.ORG", "AROJAS", null, null, false, "4c40d263-f0ea-4f0d-9393-5efe208b3d4c", 0, false, "arojas" },
                    { "8fde220b-6520-430d-994b-d484bb35d387", 0, "d8a82502-33a4-467a-b3de-5fd00cb1eef7", "jgil@cumbrescaracas.edu.ve", false, "Gil", false, null, "Jesús Enrique", "JGIL@CUMBRESCARACAS.EDU.VE", "JGIL", null, null, false, "66d8a87f-7858-440a-8c60-824d257253a3", 0, false, "jgil" },
                    { "91fdcb09-bda8-487d-aef3-30e495c381cd", 0, "e6387894-d980-4d21-92d4-dbf62c2e9d90", "mgallardo@cumbrescaracas.edu.ve", false, "Benavides", false, null, "Luana", "MGALLARDO@CUMBRESCARACAS.EDU.VE", "MGALLARDO", null, null, false, "32c5d139-edc9-4726-8ed0-a49946545f5a", 0, false, "mgallardo" },
                    { "91fea212-48a0-4182-8e6c-c918ae4fa2fd", 0, "0a3ac080-0d51-4c14-8db6-ca8ef05aa808", "drondon@cumbrescaracas.edu.ve", false, "Rondon", false, null, "Dayana", "DRONDON@CUMBRESCARACAS.EDU.VE", "DRONDON", null, null, false, "5d9d4ca6-77d9-42af-97c9-42feba374221", 0, false, "drondon" },
                    { "922578b0-d830-422a-890b-cbdf67915bda", 0, "443ae20b-a6fd-4a90-9637-11e4e375ca6c", "iavendano@cumbrescaracas.edu.ve", false, "Avendaño", false, null, "Ivana", "IAVENDANO@CUMBRESCARACAS.EDU.VE", "IAVENDANO", null, null, false, "5d4807fd-a782-4171-b7b4-3083a22f45a6", 0, false, "iavendano" },
                    { "9343e566-9b56-4a28-9323-f2abbb009bfb", 0, "bf4a377a-6723-4f04-9961-5370cec2293f", "rescobar@arcol.org", false, "Escobar", false, null, "Ricky", "RESCOBAR@ARCOL.ORG", "RESCOBAR", null, null, false, "1fdc5df7-b2a8-4b67-9ec3-e2956f17cb04", 0, false, "rescobar" },
                    { "93de6bc1-2446-417e-988a-016cfd7af441", 0, "a359aa51-7e73-471c-bbf8-d30937972619", "gaguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Greysa", "GAGUILAR@CUMBRESCARACAS.EDU.VE", "GAGUILAR", null, null, false, "733912b6-acf3-4d9a-84b7-7f42ec521e60", 0, false, "gaguilar" },
                    { "9424e5a8-db50-4325-9427-ff5d424b7390", 0, "87abc69f-d7e6-4287-a12e-d36aa1c7b536", "cquintana@cumbrescaracas.edu.ve", false, "Quintana", false, null, "Carla", "CQUINTANA@CUMBRESCARACAS.EDU.VE", "CQUINTANA", null, null, false, "18488109-0ac4-4bea-8c52-4eacb02713f0", 0, false, "cquintana" },
                    { "969c06d6-0975-4a89-a6e6-d9217057205d", 0, "b0f4dbef-1556-4444-bc10-a317b9153899", "bperez@cumbrescaracas.edu.ve", false, "Perez", false, null, "Beatriz", "BPEREZ@CUMBRESCARACAS.EDU.VE", "BPEREZ", null, null, false, "ea729e78-6403-4e8c-b887-c13969d7c25c", 0, false, "bperez" },
                    { "980b450f-f60d-481a-a197-2a59098b8466", 0, "7db719e5-a064-4624-9247-c6d1f09a394a", "caguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Claudia", "CAGUILAR@CUMBRESCARACAS.EDU.VE", "CAGUILAR", null, null, false, "4caec3e3-e0e9-4820-91c7-649d679e7fa2", 0, false, "caguilar" },
                    { "99516b95-8c75-4a07-8ea7-579020ee3701", 0, "672ee61b-37d4-43d2-8ce7-052d191e4db5", "ibolivar@cumbrescaracas.edu.ve", false, "Bolívar", false, null, "Ivette", "IBOLIVAR@CUMBRESCARACAS.EDU.VE", "IBOLIVAR", null, null, false, "e19a1694-8b15-44de-a0a4-21c0bc592939", 0, false, "ibolivar" },
                    { "9bfbe12e-8059-417f-9b1b-9c5bc4c592e4", 0, "b1cb2ca5-785f-4124-b603-38bcac1e91d6", "ablanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Andrés", "ABLANCO@CUMBRESCARACAS.EDU.VE", "ABLANCO", null, null, false, "1974bf1f-9957-478b-8916-a23cc68af711", 0, false, "ablanco" },
                    { "9c42b9b3-e35b-4514-a556-abc2a643f62a", 0, "af7bb7c7-0e49-4f93-8934-213b1a1558b1", "clopez@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriela", "CLOPEZ@CUMBRESCARACAS.EDU.VE", "CLOPEZ", null, null, false, "8081ac1d-bd31-40cc-93b6-d83373404e8f", 0, false, "clopez" },
                    { "9c6b4873-5aff-4ba1-8802-e58255dd9a13", 0, "79e2bb8b-94e4-42f6-8683-425eaac85439", "yarrayago@cumbrescaracas.edu.ve", false, "Arrayago", false, null, "Yldith", "YARRAYAGO@CUMBRESCARACAS.EDU.VE", "YARRAYAGO", null, null, false, "e86367ed-7d24-4f9e-aebf-d3bae8ff6e54", 0, false, "yarrayago" },
                    { "9ef3df34-0213-4dcc-89f5-ed52a3db08a3", 0, "b74bc6d4-c27f-43ae-bd1d-41ee38ecb9dc", "lmesa@cumbrescaracas.edu.ve", false, "Mesa", false, null, "Luisa", "LMESA@CUMBRESCARACAS.EDU.VE", "LMESA", null, null, false, "ef7ce9c9-94af-4a14-bf54-bd4b70767a52", 0, false, "lmesa" },
                    { "a00247c7-c27f-4ec7-a75b-bd10c7be0020", 0, "fffd530c-0c3e-43c1-b70a-d579218cdfb9", "chenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Carlos", "CHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "CHENRIQUEZ", null, null, false, "57c39f60-574c-403d-a2d3-77126cf8804b", 0, false, "chenriquez" },
                    { "a0f70227-a4fe-4f4f-b81d-84bb7dd70ab2", 0, "6fabeab7-e2ec-47f7-9d39-4b4bd6643fb6", "mmichelena@cumbrescaracas.edu.ve", false, "Michelena", false, null, "Mariana", "MMICHELENA@CUMBRESCARACAS.EDU.VE", "MMICHELENA", null, null, false, "8a24c344-95e5-43a9-8c8b-22442aafccd8", 0, false, "mmichelena" },
                    { "a4a7a38e-7725-4e46-a189-e56ea04c037c", 0, "8bdc21f8-e288-46c8-a909-fde867111436", "dmarval@cumbrescaracas.edu.ve", false, "Marval", false, null, "Diego", "DMARVAL@CUMBRESCARACAS.EDU.VE", "DMARVAL", null, null, false, "eaf92eae-e7eb-49ea-a882-fa71911f727c", 0, false, "dmarval" },
                    { "a6ed5e54-961a-4637-bcc2-4ce2868f215b", 0, "24159086-57ab-457b-9600-cf16c20d4b35", "igabaldon@cumbrescaracas.edu.ve", false, "De Gabaldon", false, null, "Isabel", "IGABALDON@CUMBRESCARACAS.EDU.VE", "IGABALDON", null, null, false, "3cbb9462-6454-4002-86f0-53c19f2e1379", 0, false, "igabaldon" },
                    { "a791c6b9-0115-4886-8db6-0da19fd8e61f", 0, "4acbc28a-db92-4fd2-81bb-aabc75ea66ce", "marismendi@cumbrescaracas.edu.ve", false, "Arismendi", false, null, "Martina", "MARISMENDI", "MARISMENDI@CUMBRESCARACAS.EDU.VE", null, null, false, "b2a1e6ae-5a49-4f4b-897c-67ee0671102e", 0, false, "marismendi" },
                    { "a988654b-9ccc-4f5c-97c0-c7673a14ebe9", 0, "829518f4-0f50-49b2-8dde-956aeb1b7303", "isabeldevillasmil@hotmail.com", false, "Bolinaga", false, null, "Isabel", "ISABELDEVILLASMIL@HOTMAIL.COM", "ISABELDEVILLASMIL", null, null, false, "43ff5049-e195-4b40-91c5-454d6ce64e79", 0, false, "isabeldevillasmil" },
                    { "ab9c5e4e-f44d-4c8b-8eda-141efd6ccb5b", 0, "612c6715-d15f-439e-9ff9-c5ba44e5b3c5", "jorodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "José Andrés", "JORODRIGUEZ@CUMBRESCARACAS.EDU.VE", "JORODRIGUEZ", null, null, false, "433b45b2-5df3-43e8-9f49-bb0a369020bd", 0, false, "jorodriguez" },
                    { "ac472523-142b-4f52-9fc0-53ad6b81b7b3", 0, "c2178dfd-fec3-4924-9160-cec1e46cf9fe", "maurodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Mauricio", "MAURODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MAURODRIGUEZ", null, null, false, "0c88e54c-6004-4ce0-9610-b75047ecc6d7", 0, false, "maurodriguez" },
                    { "ac76909f-1a01-49b1-b1c8-b35e33a82a86", 0, "933db7d1-8060-4b38-a6b2-4d5f459790ea", "malcala@cumbrescaracas.edu.ve", false, "Alcala", false, null, "Melissa", "MALCALA@CUMBRESCARACAS.EDU.VE", "MALCALA", null, null, false, "5001eb1a-4107-45a4-8f70-7a842ad0bc6f", 0, false, "malcala" },
                    { "ae2447e8-e9c9-428c-a297-f82756316c9c", 0, "113e3c95-d00c-4e8a-ac1c-c95e0e729cad", "mtrujillo@cumbrescaracas.edu.ve", false, "Trujillo", false, null, "María Elena", "MTRUJILLO@CUMBRESCARACAS.EDU.VE", "MTRUJILLO", null, null, false, "08bca294-68c1-4786-a769-f098fdb93259", 0, false, "mtrujillo" },
                    { "ae9f559d-ea4a-458a-8202-9fd5a363eda8", 0, "e5afe9c9-ab23-4999-abdc-4d2ae6e545d7", "myanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Miguel Angel", "MYANEZ@CUMBRESCARACAS.EDU.VE", "MYANEZ", null, null, false, "a839356b-e3e0-4d29-be0f-e2eca0c330c9", 0, false, "myanez" },
                    { "b0415e34-ea3e-4046-835a-fb5cabdad530", 0, "eefa6395-e3b2-4ff7-b705-1eb487364f4a", "avivas@cumbrescaracas.edu.ve", false, "Vivas", false, null, "Alejandra", "AVIVAS@CUMBRESCARACAS.EDU.VE", "AVIVAS", null, null, false, "cb093cb4-ebdf-4121-bad2-a926f3e17802", 0, false, "avivas" },
                    { "b08d201b-1e5c-40b6-82e9-6a9f948d4df9", 0, "2cd8721a-daa6-434c-b5eb-13a121f9fb72", "yardila@cumbrescaracas.edu.ve", false, "Ardila", false, null, "Yuleima", "YARDILA@CUMBRESCARACAS.EDU.VE", "YARDILA", null, null, false, "4f5c4625-2e0f-4991-98a3-b73f6278f65e", 0, false, "yardila" },
                    { "b7012a96-4c97-45ef-9994-325c91a43793", 0, "4546c6c1-ec90-4eb6-8ce1-61dfe03ccc1c", "mparra@cumbrescaracas.edu.ve", false, "Parra", false, null, "María Virginia", "MPARRA@CUMBRESCARACAS.EDU.VE", "MPARRA", null, null, false, "8ffd58b4-2618-4aba-84aa-8b0eba9a3bbd", 0, false, "mparra" },
                    { "bc30e212-6b45-4b8d-a01c-bc77debf11da", 0, "3e96d6f8-9d02-4051-a46e-d6e7f21713b6", "pparis@cumbrescaracas.edu.ve", false, "Paris", false, null, "Pedro", "PPARIS@CUMBRESCARACAS.EDU.VE", "PPARIS", null, null, false, "e8b65734-a874-452d-b38d-c7a898f1508f", 0, false, "pparis" },
                    { "bf2b8ac5-d6b4-427b-aa50-fd0d05a25f74", 0, "221a7fe6-38d2-4e32-8fb6-e6172ecd88c7", "ayepes@cumbrescaracas.edu.ve", false, "Machado", false, null, "Ana Teresa", "AYEPES@CUMBRESCARACAS.EDU.VE", "AYEPES", null, null, false, "d7902180-e68c-46a6-ab8c-2adf13361d89", 0, false, "ayepes" },
                    { "bfde5bc0-cdc7-4c2d-b530-45939f923c65", 0, "41f13aa5-a34a-43f1-b719-d65c6df18447", "arguerra@cumbrescaracas.edu.ve", false, "Guerra", false, null, "Arminda", "ARGUERRA@CUMBRESCARACAS.EDU.VE", "ARGUERRA", null, null, false, "bc401ad5-a5d2-4e1a-b7c1-1e9ec1a5e741", 0, false, "arguerra" },
                    { "c2cfb687-3ec5-44e8-8dc0-0b5ade75f93a", 0, "6778f20d-a42b-4dd6-9842-c5d6f1850f72", "amgarcia@legionaries.org", false, "García", false, null, "Alvaro", "AMGARCIA@LEGIONARIES.ORG", "AMGARCIA", null, null, false, "342e549f-72f8-41e0-8a5f-e5ac9ba356f3", 0, false, "amgarcia" },
                    { "c3d3893a-4c39-445a-8bcb-67db2a1bddfc", 0, "7be1dd88-e8b6-40ad-8438-cac467323433", "mperezr@cumbrescaracas.edu.ve", false, "Pérez", false, null, "Mayela", "MPEREZR@CUMBRESCARACAS.EDU.VE", "MPEREZR", null, null, false, "9f785574-e714-471a-9c06-0199cc1ba023", 0, false, "mperezr" },
                    { "c72d1dbd-4e7c-46b3-b52c-8dc40f41b59e", 0, "8df831dc-824c-442f-8caa-ccf9bf65a867", "lcasique@cumbrescaracas.edu.ve", false, "Casique", false, null, "Liliana", "LCASIQUE@CUMBRESCARACAS.EDU.VE", "LCASIQUE", null, null, false, "2030b010-7984-4a28-aa31-ab0e32cdbe82", 0, false, "lcasique" },
                    { "c73b2845-4485-4ff0-bc1a-9efe8c2f3d22", 0, "7e2d5f95-243a-40bf-baa4-418cb5db9c42", "mfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Marianella", "MFUENMAYOR@CUMBRESCARACAS.EDU.VE", "MFUENMAYOR", null, null, false, "2d44311c-7ced-48fd-876d-a66190c4447f", 0, false, "mfuenmayor" },
                    { "c7a63d77-c4ae-439b-a0a6-f5441b2811bd", 0, "65b1a9ff-1812-477a-96e6-c4a134850740", "joserivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Jose", "JOSERIVAS@CUMBRESCARACAS.EDU.VE", "JOSERIVAS", null, null, false, "845f4533-1f3d-4ac9-aa79-0bfef7b2a735", 0, false, "joserivas" },
                    { "ca66e068-f861-4413-9397-9916567b7f1f", 0, "afcaa278-2af8-4874-910e-90254e07d779", "aarmas@cumbrescaracas.edu.ve", false, "Armas De Hanna", false, null, "Anabell", "AARMAS@CUMBRESCARACAS.EDU.VE", "AARMAS", null, null, false, "10867de3-923c-492a-919c-37978dcd2115", 0, false, "aarmas" },
                    { "cd2b9e79-d90a-4fab-adbc-b0527bd63e39", 0, "acda556e-7b4e-4a3c-b426-49e359564f06", "avalderrama@cumbrescaracas.edu.ve", false, "Valderrama", false, null, "Andrea", "AVALDERRAMA@CUMBRESCARACAS.EDU.VE", "AVALDERRAMA", null, null, false, "7f781401-fdff-4f6b-ae32-00488df42626", 0, false, "avalderrama" },
                    { "d0f71873-d985-4d28-b66e-bcd62af14d47", 0, "4ba947ab-991a-4213-996c-4eff26d43850", "dsossa@legionaries.org", false, "Sossa", false, null, "Daniel", "DSOSSA@LEGIONARIES.ORG", "DSOSSA", null, null, false, "031f9eef-b1e6-454d-be6f-48758d118a68", 0, false, "dsossa" },
                    { "d135f23c-4f44-42ff-9170-e7ab73f99b9c", 0, "adf0b762-ebc3-43aa-a858-849c4c40b511", "ymoreira@cumbrescaracas.edu.ve", false, "Moreira", false, null, "Yenny", "YMOREIRA@CUMBRESCARACAS.EDU.VE", "YMOREIRA", null, null, false, "300befc7-7504-48c4-8743-6f5612ab6d05", 0, false, "ymoreira" },
                    { "d27c44bd-3ae5-4890-9317-b9fb2a7d2519", 0, "fd78edeb-ff50-4c01-91f1-9981e0c361e6", "dmata@cumbrescaracas.edu.ve", false, "Mata", false, null, "David", "DMATA@CUMBRESCARACAS.EDU.VE", "DMATA", null, null, false, "8d5c9b4d-fc40-45af-918f-9978381b0cf4", 0, false, "dmata" },
                    { "d2dc1670-7428-4a54-9c46-f86a68601225", 0, "4c03a065-7615-4870-b09d-2a35cac4ee37", "mgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Mariana", "MGONZALEZ@CUMBRESCARACAS.EDU.VE", "MGONZALEZ", null, null, false, "77ed0f2f-3b19-48ea-b0bf-d555edfdd941", 0, false, "mgonzalez" },
                    { "d7c9f06f-73b4-4a84-9a68-c74facc54436", 0, "a5f2d189-79c9-4352-b4cf-d67f7c66dd0b", "mrecchiuti@cumbrescaracas.edu.ve", false, "Recchiuti", false, null, "Mauricio", "MRECCHIUTI@CUMBRESCARACAS.EDU.VE", "MRECCHIUTI", null, null, false, "69b5b27c-491f-4a50-b302-3b0a1bd66b41", 0, false, "mrecchiuti" },
                    { "d84c6527-c093-4588-86ba-34eafa8899d4", 0, "375c780f-4378-4e4b-a76b-cfa52fafe3ff", "wteran@cumbrescaracas.edu.ve", false, "Terán", false, null, "Wilmer", "WTERAN@CUMBRESCARACAS.EDU.VE", "WTERAN", null, null, false, "205e8987-5bdb-4341-9c0b-e880f7d8598f", 0, false, "wteran" },
                    { "d86456b3-bca9-46f2-bbe5-22c2c80b075a", 0, "f8bf6ffe-3bf9-4b79-820c-54bf97251dce", "dbrando@cumbrescaracas.edu.ve", false, "Brando", false, null, "Daniel", "DBRANDO@CUMBRESCARACAS.EDU.VE", "DBRANDO", null, null, false, "66857c64-b642-42f0-a6e4-4ffec933ba41", 0, false, "dbrando" },
                    { "d8bbd4de-4f6c-4845-8d35-cf9ac6008df1", 0, "706b128e-f544-4226-b8e1-6d6d18a6efca", "sfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Solimar", "SFUENMAYOR@CUMBRESCARACAS.EDU.VE", "SFUENMAYOR", null, null, false, "c489a3e3-d9c2-4978-aa92-e48b4aa2fcb5", 0, false, "sfuenmayor" },
                    { "dafe4ef0-c80d-4e77-bb34-f22952e5911d", 0, "a50832cd-e343-471b-8ec3-1dfd9015836a", "mguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "María Fernanda", "MGUILLEN@CUMBRESCARACAS.EDU.VE", "MGUILLEN", null, null, false, "8e85ca24-3696-4f88-83a1-c5a6b7630049", 0, false, "mguillen" },
                    { "db297c52-69ee-447f-b8d2-bcb9c7f1f802", 0, "22aa1dac-9b19-4555-97ca-7719c70d0eb2", "ebellorin@cumbrescaracas.edu.ve", false, "Bellorín", false, null, "Ezeangelly", "EBELLORIN@CUMBRESCARACAS.EDU.VE", "EBELLORIN", null, null, false, "8bb88c55-c48f-4648-8c79-8cc215155e4b", 0, false, "ebellorin" },
                    { "db67ff53-e5aa-497b-8144-bf4ea0a46af9", 0, "5cedc000-9263-427e-9924-756204d06451", "mcastro@cumbrescaracas.edu.ve", false, "Castro", false, null, "Mariela", "MCASTRO@CUMBRESCARACAS.EDU.VE", "MCASTRO", null, null, false, "b2a6d4f0-9642-445e-8943-73c7b1bcef32", 0, false, "mcastro" },
                    { "dce99ebb-91e8-4101-9734-4de596c57d69", 0, "e3d4663d-3b3c-4dd4-862f-2b8ccb2b33d9", "drodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Daniella", "DRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "DRODRIGUEZ", null, null, false, "ded2055a-e56f-4047-a010-2429fa3ba1df", 0, false, "drodriguez" },
                    { "ddc38d2f-1001-4089-8df5-707e90d38180", 0, "c499e236-c5d0-4983-8bb1-3eda6c2453f6", "mariomanrique@cumbrescaracas.edu.ve", false, "Manrique", false, null, "Mario", "MARIOMANRIQUE@CUMBRESCARACAS.EDU.VE", "MARIOMANRIQUE", null, null, false, "b72c2e57-7f3a-4677-83f3-00ea4f644b86", 0, false, "mariomanrique" },
                    { "de7eae72-bcdf-4d3e-8db7-1592e7963db2", 0, "a4b1acf7-dc31-4490-933f-94ee5e2f42f5", "vvinck@cumbrescaracas.edu.ve", false, "Vinck", false, null, "Vanessa", "VVINCK@CUMBRESCARACAS.EDU.VE", "VVINCK", null, null, false, "4aad9551-7160-469c-b736-899da12ea7c7", 0, false, "vvinck" },
                    { "df01d150-7318-4989-b6f2-8f96b82d75c0", 0, "b297c49b-dde5-48d8-9fc3-81f26788c678", "ccampos@cumbrescaracas.edu.ve", false, "Campos", false, null, "Carelia", "CCAMPOS@CUMBRESCARACAS.EDU.VE", "CCAMPOS", null, null, false, "6ad752a7-e004-45de-b40c-966b8f2110f4", 0, false, "ccampos" },
                    { "dfb190eb-ee18-4ec8-836a-6aba603086f4", 0, "b96ae149-0ae4-4ed9-af6d-d6f5f63538d9", "cpadron@cumbrescaracas.edu.ve", false, "Chumbi", false, null, "Luis", "CPADRON@CUMBRESCARACAS.EDU.VE", "CPADRON", null, null, false, "bbbf9f7d-78e9-46e1-aae7-a2295be9e000", 0, false, "cpadron" },
                    { "e052cdf0-e725-4448-bac1-cc249f3d1d94", 0, "a8963cc1-3f01-4fe9-ac16-28446216e5b5", "rsirit@cumbrescaracas.edu.ve", false, "Sirit", false, null, "Ramon", "RSIRIT@CUMBRESCARACAS.EDU.VE", "RSIRIT", null, null, false, "afda9b85-615e-4e21-9197-1c3731132b35", 0, false, "rsirit" },
                    { "e18b2854-44c5-43ca-8566-156846a93c32", 0, "5dabd99c-da26-45c6-ad50-dc9d582508e2", "mramos@cumbrescaracas.edu.ve", false, "Ramos", false, null, "María", "MRAMOS@CUMBRESCARACAS.EDU.VE", "MRAMOS", null, null, false, "4a39eb2b-9251-469d-9539-1cf986ad82f4", 0, false, "mramos" },
                    { "e20bfd6b-8690-4d88-8c6f-86b10e49428a", 0, "76a64630-fa56-41cf-8ad7-0306a81291c2", "pdaumy@losarcos.edu.ve", false, "Daumy", false, null, "Patricia", "PDAUMY@LOSARCOS.EDU.VE", "PDAUMY", null, null, false, "3160049c-3c88-4ad3-9df9-5a0f4a8e3d8b", 0, false, "pdaumy" },
                    { "e66504e4-a32c-4f66-8836-548dcd2b5d53", 0, "14983ff5-763e-451f-a0d2-7a87ba4b9f56", "gbellorin@cumbrescaracas.edu.ve", false, "Bellorin", false, null, "Gilberto", "GBELLORIN@CUMBRESCARACAS.EDU.VE", "GBELLORIN", null, null, false, "3c38f358-9771-4b0e-b219-48dc1eb9c527", 0, false, "gbellorin" },
                    { "e6851b3d-c3c6-4732-b131-569659be3e36", 0, "d2359549-008b-4a37-8989-ca883418a84d", "btrias@cumbrescaracas.edu.ve", false, "Trias", false, null, "Beatriz", "BTRIAS@CUMBRESCARACAS.EDU.VE", "BTRIAS", null, null, false, "a28ffc06-c574-4476-ba93-427736e27159", 0, false, "btrias" },
                    { "e86dbddb-882f-4183-a196-554a89513540", 0, "d276b198-3182-4c39-9e6b-7fde455b0eae", "mmata@arcol.org", false, "Mata De Mora", false, null, "María Carolina", "MMATA@ARCOL.ORG", "MMATA", null, null, false, "eaf73417-8263-4a50-aae2-bb5032b82d34", 0, false, "mmata" },
                    { "e8a05f9a-8ae5-4877-acd8-43dac3e98884", 0, "dc09bd42-b293-42d7-8b2e-17ec557b054c", "lperezcastilla@legionaries.org", false, "Perez Castilla", false, null, "Leonardo", "LPEREZCASTILLA@LEGIONARIES.ORG", "LPEREZCASTILLA", null, null, false, "8896b010-87db-460d-97c3-d58f1621654f", 0, false, "lperezcastilla" },
                    { "ebb8b8fc-5d4f-4e9f-844e-490983759c61", 0, "6c49c29e-0c9c-41d8-965a-4843e18a7c8e", "earmas@cumbrescaracas.edu.ve", false, "Armas", false, null, "Edilbeck", "EARMAS", "EARMAS@CUMBRESCARACAS.EDU.VE", null, null, false, "e2dc6ecd-88b5-4f7d-81f4-98b47dd047df", 0, false, "earmas" },
                    { "edc9b6ad-81be-4ddd-8dfb-2b6a84f61d5b", 0, "24d901cc-54db-4109-ba47-a48f5f89176f", "cnoguera@cumbrescaracas.edu.ve", false, "Noguera", false, null, "Carlos", "CNOGUERA@CUMBRESCARACAS.EDU.VE", "CNOGUERA", null, null, false, "97c503e6-f113-4b62-85a4-fcfef3623a32", 0, false, "cnoguera" },
                    { "eea9a558-cefe-495e-9314-c54461dd9625", 0, "889e6868-c035-4e68-a717-83d19eef2ff6", "jblanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Jorge", "JBLANCO@CUMBRESCARACAS.EDU.VE", "JBLANCO", null, null, false, "cec0a811-551f-4f26-8b31-378059a16ff9", 0, false, "jblanco" },
                    { "efb1351f-b73a-4f6d-a6a2-450d92cd8e0b", 0, "3784af83-8fce-4aab-9210-5d1562479965", "mnakhal@cumbrescaracas.edu.ve", false, "Nakhal Akel", false, null, "María Alejandra", "MNAKHAL@CUMBRESCARACAS.EDU.VE", "MNAKHAL", null, null, false, "66da4a6e-4e5d-4fe3-8878-6ef0f6b4773d", 0, false, "mnakhal" },
                    { "f0dc1b3a-17da-427c-afdf-fa7cbc318757", 0, "447c1632-c843-4d64-a1b6-e392c34e0d83", "dnava@cumbrescaracas.edu.ve", false, "Nava", false, null, "Dayhan", "DNAVA@CUMBRESCARACAS.EDU.VE", "DNAVA", null, null, false, "48eb6283-6802-4d0b-9f8e-8a77b62b2865", 0, false, "dnava" },
                    { "f3d41ea0-9549-4b7e-8776-11cacca155c5", 0, "a65fceea-9dca-447c-b5d6-bb5769bb2ea5", "rpunceles@cumbrescaracas.edu.ve", false, "Punceles", false, null, "Rafael", "RPUNCELES@CUMBRESCARACAS.EDU.VE", "RPUNCELES", null, null, false, "c9fb1f83-4791-42f7-a7af-d78eb5ea1a57", 0, false, "rpunceles" },
                    { "f60254cd-c087-4ec6-a587-6b7e028bb4f8", 0, "94105df3-a1ea-4bca-a554-04e9a4eedc82", "dgiuliani@cumbrescaracas.edu.ve", false, "Giuliani", false, null, "Donatina", "DGIULIANI@CUMBRESCARACAS.EDU.VE", "DGIULIANI", null, null, false, "a2c628cb-4827-43e9-98d4-e1ddb72bef33", 0, false, "dgiuliani" },
                    { "f666588b-ff95-4d78-8ce4-7e9365af939e", 0, "a22f40ce-bb4d-4852-ab98-3b6901c006ad", "gandara@cumbrescaracas.edu.ve", false, "Andara", false, null, "German", "GANDARA@CUMBRESCARACAS.EDU.VE", "GANDARA", null, null, false, "1db91ca7-8a76-468b-82ee-a1410e704443", 0, false, "gandara" },
                    { "f893cbcf-f6af-4aa9-8c7c-c820ab98c552", 0, "08ef2e49-cd12-46a4-a34d-5e2c6e109f65", "ccano@cumbrescaracas.edu.ve", false, "Cano", false, null, "Cristina", "CCANO@CUMBRESCARACAS.EDU.VE", "CCANO", null, null, false, "6d417f0e-3e21-4731-9dda-5d2a2870eb3a", 0, false, "ccano" },
                    { "f9b2f5df-a067-4e4d-8c34-449bb695f0c1", 0, "53395d55-ad10-4d64-bd75-b7ffd09165e6", "kmoreno@cumbrescaracas.edu.ve", false, "Moreno", false, null, "Katherine", "KMORENO@CUMBRESCARACAS.EDU.VE", "KMORENO", null, null, false, "e9d38117-d629-4044-b520-07e15cbc2e9b", 0, false, "kmoreno" },
                    { "fbf54766-be8f-4a5f-b61f-982dbbcb9b05", 0, "76883166-c23d-4a4d-b098-779cf3ce73e0", "mrivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Mariana", "MRIVAS@CUMBRESCARACAS.EDU.VE", "MRIVAS", null, null, false, "5ad30532-a8bd-42f1-a8d7-c8acf06a047f", 0, false, "mrivas" },
                    { "fc055012-b142-4d70-be53-cdccb21779d7", 0, "260ac71e-0a49-4455-8d81-a119e41b4caa", "btogni@cumbrescaracas.edu.ve", false, "Togni", false, null, "Bruno", "BTOGNI@CUMBRESCARACAS.EDU.VE", "BTOGNI", null, null, false, "fee4c5c0-355e-4a77-ae9d-e2c803c230d0", 0, false, "btogni" },
                    { "fc796a9a-f81b-4b70-b1cf-d8e82932b812", 0, "20ea07f9-3de8-46fa-8eb7-6944b6524a5c", "mrangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Marco Aurelio", "MRANGEL@CUMBRESCARACAS.EDU.VE", "MRANGEL", null, null, false, "1a89c64c-f328-4392-9290-fb3c49cb446d", 0, false, "mrangel" },
                    { "fd2f5529-9091-4d5c-8e20-92d438701a65", 0, "2ab55c9b-d163-4e42-8826-85c849863914", "mmarquez@cumbrescaracas.edu.ve", false, "Márquez", false, null, "María Esperanza", "MMARQUEZ@CUMBRESCARACAS.EDU.VE", "MMARQUEZ", null, null, false, "922fe103-46e5-42cd-8128-35aaf76ec6c2", 0, false, "mmarquez" },
                    { "fec9d358-a8fc-488d-b81c-d0804bf9b9fe", 0, "e5ba62d1-695b-4371-b3ef-e613c438c6e0", "rvgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Rossana", "RVGONZALEZ@CUMBRESCARACAS.EDU.VE", "RVGONZALEZ", null, null, false, "04ff5868-9a2d-4b18-9837-9a30cd8809a9", 0, false, "rvgonzalez" },
                    { "fee3abc0-f73f-4e5a-a84f-a7f28c1e9ab2", 0, "add816df-f220-4005-adc8-f4ee1afde145", "kmarcano@cumbrescaracas.edu.ve", false, "Marcano", false, null, "Karina", "KMARCANO@CUMBRESCARACAS.EDU.VE", "KMARCANO", null, null, false, "0cc9344f-49d3-4963-8a71-15b2e6608beb", 0, false, "kmarcano" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClaseID",
                table: "Reservas",
                column: "ClaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_UserID",
                table: "Clases",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_AspNetUsers_UserID",
                table: "Clases",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Materias_MateriaID",
                table: "Clases",
                column: "MateriaID",
                principalTable: "Materias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clases_ClaseID",
                table: "Reservas",
                column: "ClaseID",
                principalTable: "Clases",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
