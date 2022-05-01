using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICCReservasServer.Migrations
{
    public partial class ApplicationUserInserts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a288e6a4-2f61-4dbf-ad97-d6d21b564002");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00416244-55ab-48d8-9829-6a3c3bb6d064", 0, "3ce05f61-edcc-4c89-929f-27aab2037806", "cchacon@cumbrescaracas.edu.ve", false, "Chacón", false, null, "Claudia", "CCHACON@CUMBRESCARACAS.EDU.VE", "CCHACON", null, null, false, "067a1ea4-5fdc-4b12-9c8f-ece2aa255b94", false, "cchacon" },
                    { "00697ab8-7d45-4464-9574-62013c44b1bb", 0, "39de38b8-d35b-4eb9-b213-abb0be088896", "dnava@cumbrescaracas.edu.ve", false, "Nava", false, null, "Dayhan", "DNAVA@CUMBRESCARACAS.EDU.VE", "DNAVA", null, null, false, "30104c24-8ca5-4a8f-adef-dfb736ea95dc", false, "dnava" },
                    { "00ea3354-fc30-45bf-9197-f95c4e71f254", 0, "ee7cc1e1-81e0-421b-b4af-3f5195502374", "melavalladares@gmail.com", false, "Valladares", false, null, "Melanie", "MELAVALLADARES@GMAIL.COM", "MELAVALLADARES", null, null, false, "6d420865-9f5f-4016-a07d-336314f1b1fb", false, "melavalladares" },
                    { "01df7b95-b356-40b5-907a-1f0c1b5c1008", 0, "97767dbc-114d-46b5-a068-61319d037305", "agalviz@cumbrescaracas.edu.ve", false, "Galviz", false, null, "Adrian", "AGALVIZ@CUMBRESCARACAS.EDU.VE", "AGALVIZ", null, null, false, "d57c5991-43b8-4c7b-8009-5839087586f2", false, "agalviz" },
                    { "021f70a7-ba61-4de3-8c5e-e0a31e9ec1c7", 0, "c5b137cf-6d62-48f0-9fe6-c9e0cbd86cc7", "mguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "María Fernanda", "MGUILLEN@CUMBRESCARACAS.EDU.VE", "MGUILLEN", null, null, false, "f572e788-414d-4d81-8662-d17ad9a55f5b", false, "mguillen" },
                    { "038c0670-8df4-44e6-8e7a-61d88f492568", 0, "7ba5ee81-1534-4b62-969f-0086076a74ac", "amgarcia@legionaries.org", false, "García", false, null, "Alvaro", "AMGARCIA@LEGIONARIES.ORG", "AMGARCIA", null, null, false, "aab034d2-1f34-4373-87b1-b6b2b0978ca8", false, "amgarcia" },
                    { "0500a6de-c43d-4ceb-8fd2-929475c01afa", 0, "a33be1aa-f993-4b90-a9b8-e4967149c7f5", "mvillasmil@cumbrescaracas.edu.ve", false, "Villasmil", false, null, "María Gabriela", "MVILLASMIL@CUMBRESCARACAS.EDU.VE", "MVILLASMIL", null, null, false, "83e27e27-d50d-46c7-a65e-7756dc91e94c", false, "mvillasmil" },
                    { "05cf0b7c-2c16-4158-8536-a8dfe286c4bd", 0, "8dddd925-893c-4404-8ae6-f8a6bf82b608", "mrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "María Corina", "MRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MRODRIGUEZ", null, null, false, "ac7544e7-6462-45f4-9bd9-a48ca024ce30", false, "mrodriguez" },
                    { "06bcae5e-46d1-4112-8279-02994854cc58", 0, "03822048-78b0-427e-a7cb-68e7b6db3820", "iavendano@cumbrescaracas.edu.ve", false, "Avendaño", false, null, "Ivana", "IAVENDANO@CUMBRESCARACAS.EDU.VE", "IAVENDANO", null, null, false, "63dfa5b9-f938-410b-a98d-4c364d44095c", false, "iavendano" },
                    { "07c39199-d777-40b6-9555-8a7deb5f3743", 0, "d58cb77b-b0d7-40ac-8c3b-584c975cfe8f", "ysantaella@cumbrescaracas.edu.ve", false, "Santaella", false, null, "Yajaira", "YSANTAELLA@CUMBRESCARACAS.EDU.VE", "YSANTAELLA", null, null, false, "e508e5af-2726-46ce-b663-dee885412140", false, "ysantaella" },
                    { "0a0a19ab-8af9-4e82-b037-5678a8a02c9e", 0, "72f4f4a7-dcd0-470c-9f09-7e92c73154b0", "jorodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "José Andrés", "JORODRIGUEZ@CUMBRESCARACAS.EDU.VE", "JORODRIGUEZ", null, null, false, "8644c1a4-b42d-4024-b640-b4619f64e890", false, "jorodriguez" },
                    { "0ab79bb2-9546-4de8-b5ff-30956a28647a", 0, "b3cefc66-673b-4377-b6b4-9141c5c0a1af", "gaguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Greysa", "GAGUILAR@CUMBRESCARACAS.EDU.VE", "GAGUILAR", null, null, false, "b7574e00-228d-4118-82a4-ef2ae3c3c836", false, "gaguilar" },
                    { "0dc96b63-c33b-4390-9944-d9e4b331757e", 0, "a70a3473-4142-4f33-839f-31b3e8b4734b", "dperrucci@cumbrescaracas.edu.ve", false, "Perrucci Meló", false, null, "Daniela Alejandra", "DPERRUCCI@CUMBRESCARACAS.EDU.VE", "DPERRUCCI", null, null, false, "b6c3d72d-b683-42ae-b4e7-9a775ac654fa", false, "dperrucci" },
                    { "0e6ad9ee-1861-4eb8-bc35-361099d8cf8c", 0, "49a5dc8c-44d8-4750-ad18-dbb304fd1f25", "igabaldon@cumbrescaracas.edu.ve", false, "De Gabaldon", false, null, "Isabel", "IGABALDON@CUMBRESCARACAS.EDU.VE", "IGABALDON", null, null, false, "30fece7d-81eb-4f67-8e01-ca8d4f72ff14", false, "igabaldon" },
                    { "10c8d3e1-8d41-4c6a-8338-d570ab7c6a35", 0, "b4baa070-24ee-4bca-b523-02ba3b40dbd8", "jaleman@cumbrescaracas.edu.ve", false, "Alemán", false, null, "José Antonio", "JALEMAN@CUMBRESCARACAS.EDU.VE", "JALEMAN", null, null, false, "b2f0582a-45a4-4679-b07b-4e4bcb7fa84b", false, "jaleman" },
                    { "13330bb8-75ce-4fb3-bf49-5e43e2047957", 0, "5623f2a2-57e4-4741-a939-9188f9ddcb66", "mramos@cumbrescaracas.edu.ve", false, "Ramos", false, null, "María", "MRAMOS@CUMBRESCARACAS.EDU.VE", "MRAMOS", null, null, false, "277829ec-d3e3-4240-98eb-eb0282859c11", false, "mramos" },
                    { "177232c0-f3d3-4ec7-a289-446f054e900f", 0, "5e505d0a-a4fa-4042-a20b-c997e015faf9", "ablanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Andrés", "ABLANCO@CUMBRESCARACAS.EDU.VE", "ABLANCO", null, null, false, "48785157-d423-42b1-82be-d3b8a85521b6", false, "ablanco" },
                    { "184475e3-13bb-45f3-8b51-1a84eb8758ed", 0, "6733ae6f-6e28-4595-8553-df2cddfe354b", "ccano@cumbrescaracas.edu.ve", false, "Cano", false, null, "Cristina", "CCANO@CUMBRESCARACAS.EDU.VE", "CCANO", null, null, false, "a5a827db-faa5-4171-950a-1aa09bedb755", false, "ccano" },
                    { "1bc72a4a-e613-44e9-aa7a-1ffb4b15bd65", 0, "67c523ce-1020-412a-858b-139a717fcd71", "ahenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Andrés", "AHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "AHENRIQUEZ", null, null, false, "cfb130fe-325c-48e4-8c57-6806aefea539", false, "ahenriquez" },
                    { "1c02187f-2a56-4a81-a563-6a6b55895fe3", 0, "24c1e904-dbc9-49ae-b54b-c5c4416cc9b1", "cchirinos@cumbrescaracas.edu.ve", false, "Chirinos", false, null, "Christian", "CCHIRINOS@CUMBRESCARACAS.EDU.VE", "CCHIRINOS", null, null, false, "cd7a379f-6d79-4ca6-b49f-d91e04dee054", false, "cchirinos" },
                    { "1ce7051d-af8c-48c2-9156-ba88b5e1c4fb", 0, "a59dcb34-5ce3-45e9-8db5-72eeb87de9c4", "marismendi@cumbrescaracas.edu.ve", false, "Arismendi", false, null, "Martina", "MARISMENDI", "MARISMENDI@CUMBRESCARACAS.EDU.VE", null, null, false, "95afc90a-cd54-43ff-8c8e-db03583a0946", false, "marismendi" },
                    { "1d1d221d-41e0-4dce-afc9-c44e98c32271", 0, "9dd5e06a-9335-4f82-bb90-c66c53b699dd", "mcalzadilla@cumbrescaracas.edu.ve", false, "Calzadilla", false, null, "María Alejandra", "MCALZADILLA@CUMBRESCARACAS.EDU.VE", "MCALZADILLA", null, null, false, "664a7011-1ed6-43b2-9219-55692eb97440", false, "mcalzadilla" },
                    { "1d8d0ef1-a441-4b6e-9b97-e901cd2b14fd", 0, "051e8917-c45f-419c-835b-0f5e05cd777c", "ymoreira@cumbrescaracas.edu.ve", false, "Moreira", false, null, "Yenny", "YMOREIRA@CUMBRESCARACAS.EDU.VE", "YMOREIRA", null, null, false, "16e3fa1d-40ac-4115-a50b-b35db7b69cfd", false, "ymoreira" },
                    { "1db3db7c-c0dc-4594-b2ff-824f0c660e3f", 0, "02bd2ac5-911b-4dbd-bd4b-1a9b40926b67", "mrecchiuti@cumbrescaracas.edu.ve", false, "Recchiuti", false, null, "Mauricio", "MRECCHIUTI@CUMBRESCARACAS.EDU.VE", "MRECCHIUTI", null, null, false, "d69eb50a-0846-48df-83a9-8945adb5887d", false, "mrecchiuti" },
                    { "1e180c0c-11a0-48e3-ada2-9acf92e61ad4", 0, "569ed05f-3fa0-4a23-ade0-ace3c889b1fc", "joserivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Jose", "JOSERIVAS@CUMBRESCARACAS.EDU.VE", "JOSERIVAS", null, null, false, "057558ab-ac6a-4ee7-9828-dd7d09e73ae3", false, "joserivas" },
                    { "1e45412d-2dfb-4842-b5ba-07c79c3a434a", 0, "ca099f73-0170-4133-9d75-2a6b1c81d91e", "maurodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Mauricio", "MAURODRIGUEZ@CUMBRESCARACAS.EDU.VE", "MAURODRIGUEZ", null, null, false, "7e85a9b0-6957-4793-a4c3-6d42691da991", false, "maurodriguez" },
                    { "1fb74c96-e859-4f1c-879c-2c2ee6148c02", 0, "b15a39e9-58f9-435f-ad1b-18622f424c6c", "apinero@cumbrescaracas.edu.ve", false, "Piñero", false, null, "Adriana", "APINERO@CUMBRESCARACAS.EDU.VE", "APINERO", null, null, false, "8b8634ba-69de-44b8-bbfa-b410eabce7a6", false, "apinero" },
                    { "1fba167a-d1b4-4c2a-8b6e-077c178c81d9", 0, "3f18eff0-04b5-4a2e-9aec-5102c9c7d6a7", "tayling_steffany@hotmail.com", false, "Galindo", false, null, "Tayling", "TAYLING_STEFFANY@HOTMAIL.COM", "TAYLING_STEFFANY", null, null, false, "9284d7b8-f493-4e4d-9fad-e2f2d95a6843", false, "tayling_steffany" },
                    { "21a29030-90c5-4079-8607-7dcd7d22bf20", 0, "e7416553-360a-4c57-8d3d-8057d98f8cb0", "btrias@cumbrescaracas.edu.ve", false, "Trias", false, null, "Beatriz", "BTRIAS@CUMBRESCARACAS.EDU.VE", "BTRIAS", null, null, false, "e53e11b3-9582-48d8-86fc-e609b7243ebe", false, "btrias" },
                    { "220ed2a3-1121-4d7a-a1aa-698a542643c2", 0, "094e29e6-dce6-438b-b11a-a25dc650925f", "irangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Ignacio", "IRANGEL@CUMBRESCARACAS.EDU.VE", "IRANGEL", null, null, false, "52e546c8-b11e-48ff-a63f-a785c9bc9b34", false, "irangel" },
                    { "2222771e-3efc-4fec-a62a-cd27a5b9abf3", 0, "f841f466-1a25-4518-88bf-2c8b62b8443d", "julieta.elena.rivas@gmail.com", false, "Rivas", false, null, "Julieta", "JULIETA.ELENA.RIVAS@GMAIL.COM", "JULIETA.ELENA.RIVAS", null, null, false, "5b8c0231-b240-4933-9b1b-972c9edc5e0a", false, "julieta.elena.rivas" },
                    { "2457a878-0e96-4742-9459-ebc895b9425c", 0, "10483b0d-01d3-4b20-8d34-8706368ffefd", "rpunceles@cumbrescaracas.edu.ve", false, "Punceles", false, null, "Rafael", "RPUNCELES@CUMBRESCARACAS.EDU.VE", "RPUNCELES", null, null, false, "c00f5340-d917-4db3-ac3c-78ac87baaf74", false, "rpunceles" },
                    { "24669978-a9e1-4211-a131-93d053226444", 0, "2d55e062-d764-4194-be58-43e2fdfce47a", "cpadron@cumbrescaracas.edu.ve", false, "Chumbi", false, null, "Luis", "CPADRON@CUMBRESCARACAS.EDU.VE", "CPADRON", null, null, false, "07339489-439f-43fc-ade3-d82398e998b7", false, "cpadron" },
                    { "24ef5f9f-887e-4ed6-bafe-2ee72601cac6", 0, "95ce5ab6-7569-420b-8b3c-6a9cd6f1e347", "jumarmol@cumbrescaracas.edu.ve", false, "Mármol", false, null, "Juliana", "JUMARMOL@CUMBRESCARACAS.EDU.VE", "JUMARMOL", null, null, false, "db1fdbff-e25b-4fc3-9f16-cbd2a1ce6418", false, "jumarmol" },
                    { "2530c832-4536-4e79-806f-d84fa6c61522", 0, "6325c31b-c1f5-4a34-b5ec-8ad08e3f8912", "tgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Teresita", "TGARCIA@CUMBRESCARACAS.EDU.VE", "TGARCIA", null, null, false, "41046c04-407f-4719-ae62-a4fef0622344", false, "tgarcia" },
                    { "257a3b42-bb8d-4c3e-ae73-ee9ff658b569", 0, "69d4b5f7-4071-41f8-b171-9a7825b121cd", "kmarcano@cumbrescaracas.edu.ve", false, "Marcano", false, null, "Karina", "KMARCANO@CUMBRESCARACAS.EDU.VE", "KMARCANO", null, null, false, "2f6e4185-3b4c-458b-b7d7-d608d1c8c7eb", false, "kmarcano" },
                    { "28505776-12f6-4db2-a039-d8831bbbbb69", 0, "d53e668c-b005-4d04-bb0a-9e1d875adbf9", "lcasique@cumbrescaracas.edu.ve", false, "Casique", false, null, "Liliana", "LCASIQUE@CUMBRESCARACAS.EDU.VE", "LCASIQUE", null, null, false, "ab472826-9bdd-4b05-b66c-0fa974cf766f", false, "lcasique" },
                    { "2a3fdf95-e1d2-47fd-9229-902c00b6ff85", 0, "f1b806ee-37f0-435b-bac3-97249ce8a202", "jmontilla@cumbrescaracas.edu.ve", false, "Montilla", false, null, "Juan Izquierdo", "JMONTILLA@CUMBRESCARACAS.EDU.VE", "JMONTILLA", null, null, false, "a29e36f5-da3a-4d94-a073-b97134ebd013", false, "jmontilla" },
                    { "2bc262d2-44c6-40d6-b8b9-4390d8278a45", 0, "bdc62b9a-2995-4f1b-9c2c-ea9b660569e8", "aarmas@cumbrescaracas.edu.ve", false, "Armas De Hanna", false, null, "Anabell", "AARMAS@CUMBRESCARACAS.EDU.VE", "AARMAS", null, null, false, "d42b202f-526d-4adc-9439-0d6feb58ba1a", false, "aarmas" },
                    { "2d758233-1ed3-4e99-be0c-ce5273879d37", 0, "568d3860-8aa7-435b-b5fd-057b848915a9", "clopez@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriela", "CLOPEZ@CUMBRESCARACAS.EDU.VE", "CLOPEZ", null, null, false, "86ba54a4-f13f-4f08-89e1-0733891bea4d", false, "clopez" },
                    { "2d8b3966-f1a1-40b6-a35a-3545872ef7a4", 0, "060070c8-3043-4287-89af-8b8ebdce6e90", "grando@cumbrescaracas.edu.ve", false, "Rando", false, null, "Gabriela", "GRANDO@CUMBRESCARACAS.EDU.VE", "GRANDO", null, null, false, "5c7fd2bf-a9ac-4bba-9e7f-160f476a8560", false, "grando" },
                    { "3158ff0d-6abb-4dfc-969f-1867234da27f", 0, "4472cfcc-3f7a-40cb-ba61-9da607ed4d95", "ninosuanno@cumbrescaracas.edu.ve", false, "Suanno", false, null, "Joaquin", "NINOSUANNO@CUMBRESCARACAS.EDU.VE", "NINOSUANNO", null, null, false, "f025351c-1fe8-4b05-b1e3-aca7b1b13d1f", false, "ninosuanno" },
                    { "323a44c3-007d-41f0-ac6f-2c60796155de", 0, "5696f4e5-f315-4b19-98d2-e20ce45a9023", "ibolivar@cumbrescaracas.edu.ve", false, "Bolívar", false, null, "Ivette", "IBOLIVAR@CUMBRESCARACAS.EDU.VE", "IBOLIVAR", null, null, false, "d5036b7a-87b6-463b-bf0d-8b0bc3777e5a", false, "ibolivar" },
                    { "32e9d00e-1c9e-4c0d-858c-6a5fcf7f8ba1", 0, "67eb570c-c958-4e88-a154-ee364aea277d", "earmas@cumbrescaracas.edu.ve", false, "Armas", false, null, "Edilbeck", "EARMAS", "EARMAS@CUMBRESCARACAS.EDU.VE", null, null, false, "653cd418-6575-4be0-bd08-6e2b2f71f7bd", false, "earmas" },
                    { "33a72360-dd95-4bc6-a50d-192208aed158", 0, "1448e506-b07e-4efe-8c50-c30613479d70", "imaurovich@cumbrescaracas.edu.ve", false, "Maurovich", false, null, "Isabel", "IMAUROVICH@CUMBRESCARACAS.EDU.VE", "IMAUROVICH", null, null, false, "29943cc5-7f46-4438-b6c8-e19f22a618df", false, "imaurovich" },
                    { "37a9d8a1-47a1-463a-8fe0-ba34d7319296", 0, "40528c50-7905-42a5-8a93-6b5f02bab1d3", "javila@cumbrescaracas.edu.ve", false, "Avila", false, null, "Jhonny", "JAVILA@CUMBRESCARACAS.EDU.VE", "JAVILA", null, null, false, "263352b6-a69b-49f7-b8ba-c3d61e01e945", false, "javila" },
                    { "398b15c9-185d-4461-8673-c7a00afa0b3f", 0, "a8abe8fb-1429-485f-9503-fbbb95ffe8f5", "jtoro@cumbrescaracas.edu.ve", false, "Toro", false, null, "Jorge", "JTORO@CUMBRESCARACAS.EDU.VE", "JTORO", null, null, false, "2ba5871f-0ac7-4796-9d0c-6e9508cdfe48", false, "jtoro" },
                    { "3b63ab6a-38b9-4d65-ae3d-846c95d5258e", 0, "ef78a384-d2eb-4537-a877-87df6f22945c", "rdosreis@cumbrescaracas.edu.ve", false, "Dos Reis", false, null, "Rosa", "RDOSREIS@CUMBRESCARACAS.EDU.VE", "RDOSREIS", null, null, false, "f99161fe-8fdf-4bff-abad-6893068fe3e6", false, "rdosreis" },
                    { "3bbc1aee-c499-4b80-bd46-8aee4d315560", 0, "57dd02ae-bcca-4e90-ae54-805a0715f09b", "maherrera@cumbrescaracas.edu.ve", false, "Herrera Bello", false, null, "María Alejandra", "MAHERRERA@CUMBRESCARACAS.EDU.VE", "MAHERRERA", null, null, false, "00ce949a-f560-4628-a707-6d6ac6f7b6e1", false, "maherrera" },
                    { "3c1d8736-421c-4f28-85c4-103e9a721b3a", 0, "47d7d2b9-a524-4c4d-b9bb-c2484a3fe6b3", "mmarquez@cumbrescaracas.edu.ve", false, "Márquez", false, null, "María Esperanza", "MMARQUEZ@CUMBRESCARACAS.EDU.VE", "MMARQUEZ", null, null, false, "a8c9c680-f2ee-432a-b233-2b1df4287238", false, "mmarquez" },
                    { "3c5488fa-b52d-46fa-bc2d-2bb3ec3722a8", 0, "adf94db2-bbb9-4f3c-bcd1-f13c1785981a", "jduran@cumbrescaracas.edu.ve", false, "Duran", false, null, "Jeniffer", "JDURAN@CUMBRESCARACAS.EDU.VE", "JDURAN", null, null, false, "7ef6c6da-5a55-455b-9d1d-8d4c794a8418", false, "jduran" },
                    { "404926a7-1148-4397-a297-1427b322b712", 0, "3c5a14bc-e7bd-48b2-8e80-28c6afba0285", "afeola@cumbrescaracas.edu.ve", false, "Feola Carrasquel", false, null, "Alfonso Eloy", "AFEOLA@CUMBRESCARACAS.EDU.VE", "AFEOLA", null, null, false, "7e64349d-25af-4719-a4ff-851ff40f4ae8", false, "afeola" },
                    { "43032c92-7ffc-4ca0-9686-b94699b97376", 0, "224cd2c9-23a2-4d8c-b08f-11511299a543", "gvelandia@cumbrescaracas.edu.ve", false, "Velandia", false, null, "Gabriel", "GVELANDIA@CUMBRESCARACAS.EDU.VE", "GVELANDIA", null, null, false, "f70d3cba-ccea-4abd-8420-487ee98caeea", false, "gvelandia" },
                    { "43e6d9db-98ad-474a-8a4f-66b2da601b15", 0, "0f1229bd-821b-423e-b53b-246d4d7ce119", "jmgutierrez@cumbrescracas.edu.ve", false, "Gutierrez", false, null, "José Manuel", "JMGUTIERREZ@CUMBRESCRACAS.EDU.VE", "JMGUTIERREZ", null, null, false, "4407ce70-815c-42f8-9e23-3ed1df88b253", false, "jmgutierrez" },
                    { "45799f44-48e3-46f3-9584-023e89fc21e7", 0, "17fefd21-9705-4afd-bb24-a5ac488a3eda", "mmichelena@cumbrescaracas.edu.ve", false, "Michelena", false, null, "Mariana", "MMICHELENA@CUMBRESCARACAS.EDU.VE", "MMICHELENA", null, null, false, "cf03d84c-2c6e-4a07-9d49-95a265abe475", false, "mmichelena" },
                    { "45b295d9-b56c-4a89-808e-15518cbf2ca4", 0, "6dbcb85b-17a4-48d3-b3ef-058494f6cd22", "azambrano@cumbrescaracas.edu.ve", false, "Zambrano", false, null, "Alexis", "AZAMBRANO@CUMBRESCARACAS.EDU.VE", "AZAMBRANO", null, null, false, "91ddeb29-0a09-4ef7-bbba-abe7f9b23f75", false, "azambrano" },
                    { "46b31416-eae6-4e8d-949d-49ec268e7e49", 0, "15543bcb-cb51-4cf7-b1dc-0c24580ff08b", "mgallardo@cumbrescaracas.edu.ve", false, "Benavides", false, null, "Luana", "MGALLARDO@CUMBRESCARACAS.EDU.VE", "MGALLARDO", null, null, false, "0bc0ec8f-3ffc-407e-825b-a3655ecdc434", false, "mgallardo" },
                    { "48403e12-5a35-46c2-bc76-4730c17b77cc", 0, "0eb6b3e5-5525-4283-aeb4-b46223301028", "gaortega@cumbrescaracas.edu.ve", false, "Ortega", false, null, "Gabriela", "GAORTEGA@CUMBRESCARACAS.EDU.VE", "GAORTEGA", null, null, false, "fa5b978a-2b8b-4c6a-8738-9718985896d0", false, "gaortega" },
                    { "4d023a76-4f43-4eed-b670-9c52359837e1", 0, "515f2213-fc6f-49ea-92b5-ce029add5225", "kmoreno@cumbrescaracas.edu.ve", false, "Moreno", false, null, "Katherine", "KMORENO@CUMBRESCARACAS.EDU.VE", "KMORENO", null, null, false, "3dfbb7f8-96cf-4bb0-b0f9-863ebc0a8d62", false, "kmoreno" },
                    { "4e51517b-527f-43cc-9ad1-e028168dce4a", 0, "68bc3ddd-4f35-43f2-b6eb-9358c74902ad", "lrodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Luis Antonio", "LRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "LRODRIGUEZ", null, null, false, "d6080991-d26b-48b4-a95c-3b8924f3c46d", false, "lrodriguez" },
                    { "4f253fcc-cb7e-47ba-8d21-2d1756b5103d", 0, "904c3743-461a-4b97-9764-d3b5e034e77a", "vvinck@cumbrescaracas.edu.ve", false, "Vinck", false, null, "Vanessa", "VVINCK@CUMBRESCARACAS.EDU.VE", "VVINCK", null, null, false, "6b42706d-eedd-4261-b3ed-0a90a10c6d40", false, "vvinck" },
                    { "4f68d965-c55a-4402-8907-36a6372fdf6d", 0, "7c3f4446-d937-440f-a6c1-969405f921b1", "arojas@arcol.org", false, "Rojas", false, null, "Andy", "AROJAS@ARCOL.ORG", "AROJAS", null, null, false, "8be9424f-93a1-4297-9b5e-f893a6d2884f", false, "arojas" },
                    { "50e68a1d-6a34-446c-aed7-08ca93cabfd2", 0, "a9c4e38e-d167-4ced-aa46-b506e838e9a0", "mgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Mariana", "MGONZALEZ@CUMBRESCARACAS.EDU.VE", "MGONZALEZ", null, null, false, "eb16b55e-a566-4097-9110-d119a9fbc40c", false, "mgonzalez" },
                    { "51e4b08d-291b-4819-903f-cb0da0cb9759", 0, "37ba7e51-799f-4d26-8663-647025eed8a6", "avalderrama@cumbrescaracas.edu.ve", false, "Valderrama", false, null, "Andrea", "AVALDERRAMA@CUMBRESCARACAS.EDU.VE", "AVALDERRAMA", null, null, false, "12a494db-088f-4be5-b442-6fa86bfebfeb", false, "avalderrama" },
                    { "52844a63-9cfb-43f1-8a7a-a62ac40fbf68", 0, "c93b2b6a-7e47-4568-834c-d943bc24e4b1", "mtrujillo@cumbrescaracas.edu.ve", false, "Trujillo", false, null, "María Elena", "MTRUJILLO@CUMBRESCARACAS.EDU.VE", "MTRUJILLO", null, null, false, "71d78ec2-bd8f-4827-bab6-eab2e3d6a7d2", false, "mtrujillo" },
                    { "560e3072-ba4b-4139-baf2-139565f8c191", 0, "a9ecdaa6-e942-476b-85b7-cea87a89a77a", "legutierrez@cumbrescaracas.edu.ve", false, "Gutiérrez", false, null, "Leonardo", "LEGUTIERREZ@CUMBRESCARACAS.EDU.VE", "LEGUTIERREZ", null, null, false, "6293f45f-baa8-4595-9f0f-0a36b43499b6", false, "legutierrez" },
                    { "567f2e03-9c43-4945-8acf-9a68c2d77573", 0, "35c13d5d-c701-4593-a3e9-3920fac87d21", "jgil@cumbrescaracas.edu.ve", false, "Gil", false, null, "Jesús Enrique", "JGIL@CUMBRESCARACAS.EDU.VE", "JGIL", null, null, false, "06f8bbc2-eeef-4b06-aeab-49aa9141cfe9", false, "jgil" },
                    { "58b42f0b-0f45-4df1-abe7-2acb8237c61c", 0, "c399fa4c-da7f-494a-aba9-a9b336505070", "mfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Marianella", "MFUENMAYOR@CUMBRESCARACAS.EDU.VE", "MFUENMAYOR", null, null, false, "23b63e0e-b780-4677-9bda-1e78f77ca3fb", false, "mfuenmayor" },
                    { "5ae69c0b-a06d-4643-b13b-9ccd4e6070d9", 0, "1997c2c3-1fad-41d8-973e-9d907c48015d", "ccampos@cumbrescaracas.edu.ve", false, "Campos", false, null, "Carelia", "CCAMPOS@CUMBRESCARACAS.EDU.VE", "CCAMPOS", null, null, false, "2c33e10e-65c1-4e8f-9509-a6d91f83bc59", false, "ccampos" },
                    { "5dd9720d-7b93-42c1-8435-e4d3ccf000bf", 0, "c071720b-7e40-43e9-a4ce-c247f27d9289", "leninbetancourt@yahoo.es", false, "Betancourt", false, null, "Lenin", "LENINBETANCOURT@YAHOO.ES", "LENINBETANCOURT", null, null, false, "1c638441-17ef-4a61-9800-4acc8771d823", false, "leninbetancourt" },
                    { "5ef4fa7b-9c88-4df2-84cf-203153433989", 0, "03ab613d-bcb2-4145-9dd2-86b14156069b", "btogni@cumbrescaracas.edu.ve", false, "Togni", false, null, "Bruno", "BTOGNI@CUMBRESCARACAS.EDU.VE", "BTOGNI", null, null, false, "e5df44b9-c15f-4d08-a69b-fc581e6f59c5", false, "btogni" },
                    { "5f93f0df-8157-4481-84aa-2b524c18b215", 0, "90e7bee1-4d15-4143-8d83-3112bb99a9b4", "grodriguez@cumbrescaracas.edu.ve", false, "Rodriguez", false, null, "Guida", "GRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "GRODRIGUEZ", null, null, false, "5e4b10b0-4571-408a-9531-99d1f049d5b1", false, "grodriguez" },
                    { "605417a9-4203-4ab4-b7b7-729f538f9bc5", 0, "d4e117c5-7827-4ecc-b0e3-cf4f88cb8746", "yardila@cumbrescaracas.edu.ve", false, "Ardila", false, null, "Yuleima", "YARDILA@CUMBRESCARACAS.EDU.VE", "YARDILA", null, null, false, "db41dae5-3480-4ca2-b279-b681fe421c3d", false, "yardila" },
                    { "6095b88a-f123-4762-9bac-0f4cda81547a", 0, "b7e6cd73-aa07-45c6-90cc-ba9af8cec115", "zrodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Zamanta", "ZRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ZRODRIGUEZ", null, null, false, "1a71b28a-73dd-4aa5-b1d4-3eb3405534d1", false, "zrodriguez" },
                    { "616b60dc-2f9e-413a-a0db-df1065f535b6", 0, "d01e0d10-3cfc-4828-a98a-fbd3f0064e65", "mcapuz@cumbrescaracas.edu.ve", false, "Capuz", false, null, "Marycel", "MCAPUZ@CUMBRESCARACAS.EDU.VE", "MCAPUZ", null, null, false, "faf3e663-ccb2-4e8b-827a-15d378696278", false, "mcapuz" },
                    { "630acbc8-a625-41bd-8850-f5160a2641be", 0, "0b50e6fe-83f7-4114-a7dd-55a7475e8d09", "gandara@cumbrescaracas.edu.ve", false, "Andara", false, null, "German", "GANDARA@CUMBRESCARACAS.EDU.VE", "GANDARA", null, null, false, "7f69e7b1-7575-484b-a77f-508101660f29", false, "gandara" },
                    { "6340480a-4509-4118-b060-a67e09ad2532", 0, "4fd7d372-e8da-416a-920d-0b43e5d0c2af", "csuarez@cumbrescaracas.edu.ve", false, "Suárez", false, null, "César", "CSUAREZ@CUMBRESCARACAS.EDU.VE", "CSUAREZ", null, null, false, "282261a6-4a85-4d8f-b8ba-e102406e2296", false, "csuarez" },
                    { "661616ab-9254-4e8b-b5e9-5ad9ac7956f9", 0, "bfec6f66-b54c-4106-b7e5-b8244232ffaa", "mparra@cumbrescaracas.edu.ve", false, "Parra", false, null, "María Virginia", "MPARRA@CUMBRESCARACAS.EDU.VE", "MPARRA", null, null, false, "b8975c06-b475-47f1-af6c-cdea7f75affa", false, "mparra" },
                    { "66bf5dd8-71af-4e85-9fd8-03fc4fc4e004", 0, "be36e353-d624-4355-886f-922d54758105", "dmarval@cumbrescaracas.edu.ve", false, "Marval", false, null, "Diego", "DMARVAL@CUMBRESCARACAS.EDU.VE", "DMARVAL", null, null, false, "5a91267a-916b-47a4-9bea-43fc281300b8", false, "dmarval" },
                    { "6838711e-9918-427f-a4da-3c9c7e0edc02", 0, "981d9374-8d92-453b-b507-a71bc8cd5acb", "rofernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Rosmary", "ROFERNANDEZ@CUMBRESCARACAS.EDU.VE", "ROFERNANDEZ", null, null, false, "9504f2f5-78bd-4e3e-826f-b5ad92d286b1", false, "rofernandez" },
                    { "6c6f14b9-8f77-46aa-90d4-fcd99a199fea", 0, "8850e48f-4a8a-47ee-8360-165d905e91b2", "wteran@cumbrescaracas.edu.ve", false, "Terán", false, null, "Wilmer", "WTERAN@CUMBRESCARACAS.EDU.VE", "WTERAN", null, null, false, "290ddadc-a4fb-44e6-816b-bfe34ac22fba", false, "wteran" },
                    { "6c8866e5-f978-44c0-bae3-09186dc5dd2f", 0, "9c25ed50-1de8-4775-bfb7-7c7d3aa5db51", "rvgonzalez@cumbrescaracas.edu.ve", false, "González", false, null, "Rossana", "RVGONZALEZ@CUMBRESCARACAS.EDU.VE", "RVGONZALEZ", null, null, false, "0c555167-78a6-4c3e-9448-3f8bcf7b4dbb", false, "rvgonzalez" },
                    { "6d62dd18-d867-4466-9738-6637546fde60", 0, "b74cf3b5-6b4e-4239-b986-991d70521029", "mnakhal@cumbrescaracas.edu.ve", false, "Nakhal Akel", false, null, "María Alejandra", "MNAKHAL@CUMBRESCARACAS.EDU.VE", "MNAKHAL", null, null, false, "68c4bc24-a6bc-4a2b-a340-b570179406d5", false, "mnakhal" },
                    { "6d6b9b06-5fe2-42e1-9234-26cba935e12e", 0, "9ba762b6-8a81-483c-8491-5d10717f551b", "jthimotheo@cumbrescaracas.edu.ve", false, "Thimotheo", false, null, "José Carlos", "JTHIMOTHEO@CUMBRESCARACAS.EDU.VE", "JTHIMOTHEO", null, null, false, "b4fd768c-0406-4953-be5c-d251d8b8422a", false, "jthimotheo" },
                    { "6e2a27dc-0ec1-4980-ae9c-0c6ef873fc36", 0, "7784027b-fa9e-40f9-8c96-3764c9eb6be2", "mmata@arcol.org", false, "Mata De Mora", false, null, "María Carolina", "MMATA@ARCOL.ORG", "MMATA", null, null, false, "af59db35-f4c2-4499-96cb-a6960351e67d", false, "mmata" },
                    { "6f5a57c7-fbbe-4261-9055-a388e82ba81e", 0, "c2005b41-26fb-4c69-8135-2a15d26e2b4d", "rgallo@cumbrescaracas.edu.ve", false, "Gallo", false, null, "Raffaela", "RGALLO@CUMBRESCARACAS.EDU.VE", "RGALLO", null, null, false, "6a3e0a09-fa02-4b10-bc72-1b5d2e2cb1b9", false, "rgallo" },
                    { "705f51da-7adb-4800-ab6a-2d04b5e578bc", 0, "cd10c44d-6bcb-40ce-adc1-add002f0bba2", "mariselayjorge@hotmail.com", false, "Rocha", false, null, "Marisela", "MARISELAYJORGE@HOTMAIL.COM", "MARISELAYJORGE", null, null, false, "4b2a7533-09c3-4f35-b2a4-fdd366c6caa0", false, "mariselayjorge" },
                    { "73c13401-2748-4b6e-a83b-3175a2401e3e", 0, "0151bfef-9e6e-457a-bcb9-5693bee59cde", "mestevez@cumbrescaracas.edu.ve", false, "Estévez", false, null, "María Graciela", "MESTEVEZ@CUMBRESCARACAS.EDU.VE", "MESTEVEZ", null, null, false, "329d46d8-778c-49bf-aaa9-0a3660076e64", false, "mestevez" },
                    { "767eb7fa-a84b-480f-8d77-5f1c2fd1e61c", 0, "cafcd2af-bff5-4009-b1b8-bdb2dff260fd", "abedetti@cumbrescaracas.edu.ve", false, "Bedetti", false, null, "Alfredo", "ABEDETTI@CUMBRESCARACAS.EDU.VE", "ABEDETTI", null, null, false, "af09b435-f1a1-40b5-95c9-bcd474a0b470", false, "abedetti" },
                    { "768574c9-20ae-4c1e-9e28-457bae8966cc", 0, "65f55b77-8ce5-4ca7-9ec5-5b56a1a1371d", "caguilar@cumbrescaracas.edu.ve", false, "Aguilar", false, null, "Claudia", "CAGUILAR@CUMBRESCARACAS.EDU.VE", "CAGUILAR", null, null, false, "274047e2-7cfe-4e09-8301-861fe8041ffc", false, "caguilar" },
                    { "76b2e5ad-5333-4fb9-8a45-ebc415241462", 0, "de5e6471-ad8a-406d-b42c-f4466fc2df4a", "lmesa@cumbrescaracas.edu.ve", false, "Mesa", false, null, "Luisa", "LMESA@CUMBRESCARACAS.EDU.VE", "LMESA", null, null, false, "be3f5770-219c-4d69-8e76-6f0da869b635", false, "lmesa" },
                    { "79d9c729-d091-4e90-a831-eae2a96d4280", 0, "408025a3-66eb-406b-979c-129563faba69", "dgiuliani@cumbrescaracas.edu.ve", false, "Giuliani", false, null, "Donatina", "DGIULIANI@CUMBRESCARACAS.EDU.VE", "DGIULIANI", null, null, false, "ee235f77-e2ed-4fca-9923-7f48beaa202f", false, "dgiuliani" },
                    { "7bc781c9-d7e0-4c51-b805-7efb0e12060c", 0, "8537fb62-7f5c-45a5-9554-65abc503fd5f", "mariomanrique@cumbrescaracas.edu.ve", false, "Manrique", false, null, "Mario", "MARIOMANRIQUE@CUMBRESCARACAS.EDU.VE", "MARIOMANRIQUE", null, null, false, "307b2ff2-1197-4be1-8178-4b20548de14f", false, "mariomanrique" },
                    { "7c0bdcfa-1b3d-4b13-9b16-72ff3b677f1a", 0, "0e5b9db8-8a89-4b05-85cd-7df0245b3319", "rsirit@cumbrescaracas.edu.ve", false, "Sirit", false, null, "Ramon", "RSIRIT@CUMBRESCARACAS.EDU.VE", "RSIRIT", null, null, false, "8bc4b356-ce4c-48df-9544-095acac3c8c8", false, "rsirit" },
                    { "7dc19937-b837-434c-bbeb-8fb8050f44ec", 0, "b65c70e5-ff41-49a7-be31-5c3f9faf1b30", "mcastro@cumbrescaracas.edu.ve", false, "Castro", false, null, "Mariela", "MCASTRO@CUMBRESCARACAS.EDU.VE", "MCASTRO", null, null, false, "452e45b0-7d83-4432-9f1c-9b77049d03d9", false, "mcastro" },
                    { "7df5b86b-d090-4dfc-8cfb-a1a3e4128496", 0, "9ffe7d3c-149f-483f-a6eb-90c8e4effc11", "gbellorin@cumbrescaracas.edu.ve", false, "Bellorin", false, null, "Gilberto", "GBELLORIN@CUMBRESCARACAS.EDU.VE", "GBELLORIN", null, null, false, "59808ae5-45a8-45d0-bd1a-61161aa9cd58", false, "gbellorin" },
                    { "7f9cbac5-0385-48d6-ad5c-1d524febd734", 0, "c1154fad-92cf-4518-b3e2-68705f64764c", "isabeldevillasmil@hotmail.com", false, "Bolinaga", false, null, "Isabel", "ISABELDEVILLASMIL@HOTMAIL.COM", "ISABELDEVILLASMIL", null, null, false, "93f96edd-5171-4dc0-a0fb-6dca454e1574", false, "isabeldevillasmil" },
                    { "80e13729-051a-4fa7-8f7f-0f37b1048027", 0, "428bf283-0d4d-46b2-87ab-ee535113b875", "jguillen@cumbrescaracas.edu.ve", false, "Guillén", false, null, "Jessica", "JGUILLEN@CUMBRESCARACAS.EDU.VE", "JGUILLEN", null, null, false, "d7ce5f2d-97a4-4c1e-ad42-5cdde351994c", false, "jguillen" },
                    { "84047cd2-4bfd-446d-8c19-f4e4a9e11621", 0, "fcd6990d-2560-462e-b412-6ea7bf744e55", "nmagdaleno@cumbrescaracas.edu.ve", false, "Magdaleno", false, null, "Nancy", "NMAGDALENO@CUMBRESCARACAS.EDU.VE", "NMAGDALENO", null, null, false, "89ee9a92-8a24-4419-882a-eede5a046ab2", false, "nmagdaleno" },
                    { "84c76d4b-94da-4f32-909f-ac11c8154431", 0, "664bc413-f0d1-4db7-9d66-e40a62b85d4b", "gsalas@cumbrescaracas.edu.ve", false, "Salas", false, null, "Gabriel", "GSALAS@CUMBRESCARACAS.EDU.VE", "GSALAS", null, null, false, "35652fb8-61a0-4593-94cb-7b70e6854797", false, "gsalas" },
                    { "8677d8d4-7741-4c9e-8644-8f6f95380c1d", 0, "b6b73682-0cf9-45ae-9ccc-7646495b7f71", "loumarangulo@gmail.com", false, "Angulo", false, null, "Verónica", "LOUMARANGULO@GMAIL.COM", "LOUMARANGULO", null, null, false, "16db55a6-baa0-4b02-b2ce-76c4cedbc9f1", false, "loumarangulo" },
                    { "8812d8d6-6c69-4d92-b816-0845838c6a6b", 0, "b601a53d-de3b-4e71-b5a2-b564c54f4666", "iluca@cumbrescaracas.edu.ve", false, "Luca", false, null, "Ivette", "ILUCA@CUMBRESCARACAS.EDU.VE", "ILUCA", null, null, false, "124c7ce2-8580-474f-9537-60747d2791bc", false, "iluca" },
                    { "8ac92417-cd94-48f8-ab14-0336a55600de", 0, "4c785600-9b8a-4f9f-a07d-0dff53509022", "mitriago@cumbrescaracas.edu.ve", false, "Itriago", false, null, "Marianna", "MITRIAGO@CUMBRESCARACAS.EDU.VE", "MITRIAGO", null, null, false, "85511937-ccd7-44db-9330-df34d013632a", false, "mitriago" },
                    { "8d922462-6f40-4b72-97d2-d6bbd7989fd0", 0, "5ace9e68-efa8-42d7-9c17-c564cd5db70c", "mdiaz@cumbrescaracas.edu.ve", false, "Diaz", false, null, "Maria Fernanda", "MDIAZ@CUMBRESCARACAS.EDU.VE", "MDIAZ", null, null, false, "3e617142-6dc0-413e-be64-4e6d58435e3e", false, "mdiaz" },
                    { "8eb2d23a-bb49-46d4-81d2-f1c08a480982", 0, "881f89c0-515b-4b71-8a6d-01f7d6adaeb8", "blosada@cumbrescaracas.edu.ve", false, "Losada", false, null, "Beatriz", "BLOSADA@CUMBRESCARACAS.EDU.VE", "BLOSADA", null, null, false, "e4c0367b-4505-4eee-9f0d-107f641e6b9a", false, "blosada" },
                    { "8fb3b6f6-6997-46c7-803c-569d6c3113df", 0, "62389af1-b54c-4bf3-9e09-8487e8ec7cc1", "ebellorin@cumbrescaracas.edu.ve", false, "Bellorín", false, null, "Ezeangelly", "EBELLORIN@CUMBRESCARACAS.EDU.VE", "EBELLORIN", null, null, false, "ee2138cc-f670-4a95-a637-45866be7fc99", false, "ebellorin" },
                    { "9048514b-f2af-4358-8718-34cfc3b7b127", 0, "4abbeb6a-b2ff-48af-9d35-c3c5bca0e71a", "jgarcia@cumbrescaracas.edu.ve", false, "García", false, null, "Jesús", "JGARCIA@CUMBRESCARACAS.EDU.VE", "JGARCIA", null, null, false, "1b5ac23e-f844-405c-9708-46790cdce316", false, "jgarcia" },
                    { "91e33b8e-f796-464d-8858-d261ecc28096", 0, "689c8d1b-2f6d-4625-ad0e-24830ed824ce", "gadiaz@cumbrescaracas.edu.ve", false, "Díaz", false, null, "Guadalupe", "GADIAZ@CUMBRESCARACAS.EDU.VE", "GADIAZ", null, null, false, "dda64839-04c7-4077-84b7-876941742b9f", false, "gadiaz" },
                    { "921a6762-eeba-4c6e-b5f2-fd8098be5e42", 0, "50789423-67c4-487d-922f-62ca20fc1948", "rescobar@arcol.org", false, "Escobar", false, null, "Ricky", "RESCOBAR@ARCOL.ORG", "RESCOBAR", null, null, false, "fb69a9ee-8074-41ed-8149-33cd8791623f", false, "rescobar" },
                    { "930c8226-c673-4ec3-9ef5-de42253daf79", 0, "13d10229-8dc9-42da-b6f4-c73a6be02eed", "sfuenmayor@cumbrescaracas.edu.ve", false, "Fuenmayor", false, null, "Solimar", "SFUENMAYOR@CUMBRESCARACAS.EDU.VE", "SFUENMAYOR", null, null, false, "5f5c7cab-687f-4a94-83be-40e1a43ee402", false, "sfuenmayor" },
                    { "93a4c2ea-56ee-4b7b-9bbe-8955b9252974", 0, "056a62ea-a3e1-413d-b285-cab47e8bdbd2", "dsossa@legionaries.org", false, "Sossa", false, null, "Daniel", "DSOSSA@LEGIONARIES.ORG", "DSOSSA", null, null, false, "2bdc5254-824f-4635-98ce-096dadbbf61a", false, "dsossa" },
                    { "94d53b17-7b98-4afa-935c-bf06b38757be", 0, "1705c231-a487-42ff-9ee1-7cf06e22d6ec", "imejias@cumbrescaracas.edu.ve", false, "Mejias", false, null, "Iliana", "IMEJIAS@CUMBRESCARACAS.EDU.VE", "IMEJIAS", null, null, false, "10e83b70-5500-47f1-8d0a-fd100694da2c", false, "imejias" },
                    { "95fc31c4-6564-48c5-9ce7-b5b8ed0bd2ee", 0, "d4e28530-c58e-4023-b4d7-9e1a94c6f412", "arguerra@cumbrescaracas.edu.ve", false, "Guerra", false, null, "Arminda", "ARGUERRA@CUMBRESCARACAS.EDU.VE", "ARGUERRA", null, null, false, "eb39a95d-828f-489e-8563-772b269dd87b", false, "arguerra" },
                    { "9785ebd7-ce33-4cb5-9eca-82e54ab6d9e2", 0, "f17338b3-3b6a-4211-a92e-b77c1af7e428", "msous@cumbrescaracas.edu.ve", false, "Sous", false, null, "Morela", "MSOUS@CUMBRESCARACAS.EDU.VE", "MSOUS", null, null, false, "8cee78df-838a-4df3-8a0e-b96361885fa7", false, "msous" },
                    { "97e5d85a-37dd-4695-a602-62cc608d282b", 0, "19cc9b46-620c-45d1-92c1-ed6d850883b1", "cgomez@cumbrescaracas.edu.ve", false, "Gomez", false, null, "Carlos", "CGOMEZ@CUMBRESCARACAS.EDU.VE", "CGOMEZ", null, null, false, "c7261675-5f26-4f6b-9f96-0746286d6967", false, "cgomez" },
                    { "988828c9-a504-43dc-93dc-082f76ed78ab", 0, "ae5f924a-f994-4f15-b083-57b29433e127", "arodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Ana", "ARODRIGUEZ@CUMBRESCARACAS.EDU.VE", "ARODRIGUEZ", null, null, false, "fd383d1b-f2e4-4e16-86fc-5cf0088fca23", false, "arodriguez" },
                    { "9a215488-34cf-4d12-8622-8a6a9dcabc06", 0, "b57d560c-6a96-4d9e-848a-64b8aa0bcc87", "lurueta@cumbrescaracas.edu.ve", false, "Urueta", false, null, "Leonidas", "LURUETA@CUMBRESCARACAS.EDU.VE", "LURUETA", null, null, false, "e47d3bf5-f340-43b3-b4d1-2bd3f167ab72", false, "lurueta" },
                    { "9a593634-1b81-4501-8898-d62d41958830", 0, "6405c360-3900-41c3-aa70-05d64c9d409b", "ldelgado@cumbrescaracas.edu.ve", false, "Delgado", false, null, "Leiza", "LDELGADO@CUMBRESCARACAS.EDU.VE", "LDELGADO", null, null, false, "bdb43ade-a9db-41f7-9ef7-85b6cb0dec10", false, "ldelgado" },
                    { "9bceea00-e3b9-4495-afe5-73790de9d63d", 0, "2f9e0e90-efcd-47eb-a253-4e30dab22200", "sharrisson@cumbrescaracas.edu.ve", false, "Harrisson", false, null, "Selene", "SHARRISSON@CUMBRESCARACAS.EDU.VE", "SHARRISSON", null, null, false, "604c8e89-c1d1-4fd4-ab32-70d528aaa52d", false, "sharrisson" },
                    { "9bebc920-3442-456a-be89-71072d111baa", 0, "f0861916-46f4-4326-a509-a4d59d7cf86d", "carlosurdaneta@cumbrescaracas.edu.ve", false, "Urdaneta", false, null, "Carlos", "CARLOSURDANETA@CUMBRESCARACAS.EDU.VE", "CARLOSURDANETA", null, null, false, "f28c81cb-8f03-4159-b36c-8b1b12ba7453", false, "carlosurdaneta" },
                    { "9d5262e8-e2b1-4c17-a9d9-2f637873ce65", 0, "b8d32d48-3ad2-4410-831e-83761df1809e", "jblanco@cumbrescaracas.edu.ve", false, "Blanco", false, null, "Jorge", "JBLANCO@CUMBRESCARACAS.EDU.VE", "JBLANCO", null, null, false, "2a0e165c-8b65-4c99-abed-d72ab1539829", false, "jblanco" },
                    { "9e3629ca-29a9-4dec-9ebc-947a0a855c8b", 0, "4ce4a7d9-468f-46be-a399-f5c37043a2cb", "jmarti@legionaries.org", false, "Martí", false, null, "Julio César", "JMARTI@LEGIONARIES.ORG", "JMARTI", null, null, false, "5e06cb36-cacc-495d-9706-f81aecaaad1e", false, "jmarti" },
                    { "a00460d7-c7a0-49c7-acf2-d66031e92ca3", 0, "b05116ca-b14c-451a-a60e-e1be9126081c", "mcardona@cumbrescaracas.edu.ve", false, "Cardona", false, null, "Marisela", "MCARDONA@CUMBRESCARACAS.EDU.VE", "MCARDONA", null, null, false, "6f58b8e1-b69c-4bf2-ab6a-4808bb9822ed", false, "mcardona" },
                    { "a3989650-9e58-4da5-90a7-3e0088bfbc1a", 0, "6082f8ae-2fb2-4882-b521-cba7fed69e05", "chenriquez@cumbrescaracas.edu.ve", false, "Henríquez", false, null, "Carlos", "CHENRIQUEZ@CUMBRESCARACAS.EDU.VE", "CHENRIQUEZ", null, null, false, "cf11366d-a186-4309-8cd1-7859089cda92", false, "chenriquez" },
                    { "a5880a7b-2c1c-47cc-a3d6-c40510e683fa", 0, "281ae9d2-e354-4edb-9ba5-28bcb480c0a8", "ilugo@cumbrescaracas.edu.ve", false, "Lugo Caravallo", false, null, "Ismael José", "ILUGO@CUMBRESCARACAS.EDU.VE", "ILUGO", null, null, false, "2ec19cd4-8f19-4ff2-b552-8446eaa6ae30", false, "ilugo" },
                    { "a5cbf6c6-c0e5-4615-a92f-2b5fb0acc4d6", 0, "4e60229d-68fa-4549-882b-08735f1b3738", "syanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Simón", "SYANEZ@CUMBRESCARACAS.EDU.VE", "SYANEZ", null, null, false, "110c316c-fcd4-41e8-9589-b95bf4841ecd", false, "syanez" },
                    { "a6a21162-6d49-47e8-b200-61162a17cfc3", 0, "4c0de411-d74c-44c7-829e-1dd700166858", "mperezr@cumbrescaracas.edu.ve", false, "Pérez", false, null, "Mayela", "MPEREZR@CUMBRESCARACAS.EDU.VE", "MPEREZR", null, null, false, "893e65b4-a5af-468a-950c-c9e021798d81", false, "mperezr" },
                    { "a6d23456-b074-4610-b83e-a63206180ec6", 0, "55481d4e-cb71-40af-a4a3-11dac3238a65", "bperez@cumbrescaracas.edu.ve", false, "Perez", false, null, "Beatriz", "BPEREZ@CUMBRESCARACAS.EDU.VE", "BPEREZ", null, null, false, "aa61a2fd-0b92-4a30-8e24-770a58884136", false, "bperez" },
                    { "a83b71c8-7d77-4eaa-8dc9-b37fba5cd455", 0, "f0eb001f-28e3-4e26-9e89-87fbccefe4ec", "rsanchez@cumbrescaracas.edu.ve", false, "Sánchez", false, null, "Rosario", "RSANCHEZ@CUMBRESCARACAS.EDU.VE", "RSANCHEZ", null, null, false, "addfc9fa-9b7f-434a-a884-aec687ab14df", false, "rsanchez" },
                    { "ab58ba52-5e84-4d6a-b4dd-e96a8d95bf3e", 0, "785b0032-29f5-4a56-b9de-8b53f8347d05", "avivas@cumbrescaracas.edu.ve", false, "Vivas", false, null, "Alejandra", "AVIVAS@CUMBRESCARACAS.EDU.VE", "AVIVAS", null, null, false, "e63f974b-0ea8-4700-a851-9e9691b3401b", false, "avivas" },
                    { "b0d05b61-d6e6-4a4f-8758-52e3fd550eb4", 0, "d8eb8b80-3ebd-47a2-9956-9b2d317fdf0d", "mrivas@cumbrescaracas.edu.ve", false, "Rivas", false, null, "Mariana", "MRIVAS@CUMBRESCARACAS.EDU.VE", "MRIVAS", null, null, false, "d98c4f0e-6eba-47d6-808b-852edb5b4241", false, "mrivas" },
                    { "b2878b99-b78c-4d10-bceb-7070c590df4d", 0, "563786e6-ab12-47f7-8daa-7bad171f2993", "drodriguez@cumbrescaracas.edu.ve", false, "Rodríguez", false, null, "Daniella", "DRODRIGUEZ@CUMBRESCARACAS.EDU.VE", "DRODRIGUEZ", null, null, false, "5df70e53-17a7-433a-9cb8-b97c4bddb020", false, "drodriguez" },
                    { "b6c753fe-60d4-4933-b5ca-6f701540734e", 0, "18bdfd75-9247-4e4f-9869-5bf80f680525", "yoropeza@cumbrescaracas.edu.ve", false, "Oropeza", false, null, "Yndhira", "YOROPEZA@CUMBRESCARACAS.EDU.VE", "YOROPEZA", null, null, false, "be19fb38-8605-4e52-b76a-841290be9cce", false, "yoropeza" },
                    { "b6e130ea-a335-4558-a372-d6e2c0ab3338", 0, "64841498-81d8-4e23-b435-f25217b4541f", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", "NADORNO@CUMBRESCARACAS.EDU.VE", "NADORNO", null, null, false, "05c60dd3-7d73-4d3b-9a99-822bd22cf6fa", false, "nadorno" },
                    { "b8a5157d-815d-46fe-8300-b90eabdbd489", 0, "e04370d3-3a59-4d5a-9892-417963944734", "rpan@cumbrescaracas.edu.ve", false, "Dávila", false, null, "Rebeca", "RPAN@CUMBRESCARACAS.EDU.VE", "RPAN", null, null, false, "bb781f00-5883-44a1-a863-ed8235f18748", false, "rpan" },
                    { "bb7b1764-e687-4b50-9caa-fb19a7b83f1e", 0, "0b515bc0-b631-4eeb-9681-1c993cae1f54", "pparis@cumbrescaracas.edu.ve", false, "Paris", false, null, "Pedro", "PPARIS@CUMBRESCARACAS.EDU.VE", "PPARIS", null, null, false, "f7f38a36-ed0f-4a63-9bab-42d74665d26c", false, "pparis" },
                    { "bbd522c6-cc5c-41dd-ba8b-ba2aad19c761", 0, "3dce1b78-2a52-4ba6-8517-1daf427ce12c", "cquintana@cumbrescaracas.edu.ve", false, "Quintana", false, null, "Carla", "CQUINTANA@CUMBRESCARACAS.EDU.VE", "CQUINTANA", null, null, false, "1478a795-cdd5-4646-b8fd-f8a0ec4b68c2", false, "cquintana" },
                    { "be896722-79fc-431e-8bf1-1dd86fa3bfaa", 0, "9738f336-f337-41d3-b831-f0d9a3022d47", "drondon@cumbrescaracas.edu.ve", false, "Rondon", false, null, "Dayana", "DRONDON@CUMBRESCARACAS.EDU.VE", "DRONDON", null, null, false, "063be479-de0a-4546-a3a6-ac851639a2e5", false, "drondon" },
                    { "beabf550-aad1-4b6b-b3f0-3e3d0e88cd3c", 0, "493f20a2-8e4e-456a-9c32-955cf1792013", "pfernandez@cumbrescaracas.edu.ve", false, "Fernández", false, null, "Paula", "PFERNANDEZ@CUMBRESCARACAS.EDU.VE", "PFERNANDEZ", null, null, false, "9c50a5e2-4176-4e99-b0c6-e5abcd7a9381", false, "pfernandez" },
                    { "befeddf6-218a-4797-9e8d-a4d3ff3399cc", 0, "350a6d3a-9d83-438a-ac48-4532ec82059b", "mtortosa@cumbrescaracas.edu.ve", false, "Tortosa", false, null, "Maria Gabriela", "MTORTOSA@CUMBRESCARACAS.EDU.VE", "MTORTOSA", null, null, false, "4a1d4d1d-50fb-4d03-90b6-10d244732328", false, "mtortosa" },
                    { "c79f5d88-96db-4eb3-a7c4-1334e3eaf6dd", 0, "28f83f5c-d434-49ae-a54e-4823b4c59874", "pdaumy@losarcos.edu.ve", false, "Daumy", false, null, "Patricia", "PDAUMY@LOSARCOS.EDU.VE", "PDAUMY", null, null, false, "1bbb7c87-7927-40fe-ac0e-5f3565526c27", false, "pdaumy" },
                    { "c8fc09f1-cfcf-4de7-87c6-5a578ed0af85", 0, "0d01a28c-ca8c-42fc-8d80-4549a25317bd", "adipentima@cumbrescaracas.edu.ve", false, "Vona", false, null, "América", "ADIPENTIMA@CUMBRESCARACAS.EDU.VE", "ADIPENTIMA", null, null, false, "9b4bf522-a8e7-4d74-bec9-eda7e3ca7643", false, "adipentima" },
                    { "cb93ffa7-251d-4d93-a560-5a61074a0c9f", 0, "ceedc394-f01b-46ba-ba9a-9f7645e647cf", "larellano@legionaries.org", false, "Arellano", false, null, "Leonardo", "LARELLANO", "LARELLANO@LEGIONARIES.ORG", null, null, false, "369819bb-a3be-45e7-a531-163c494d304a", false, "larellano" },
                    { "cc3fe06e-54fb-4bb0-978d-cfc2972782c9", 0, "835bffcb-a8f7-40a0-b964-2ae1f9bb954e", "rangeli@cumbrescaracas.edu.ve", false, "Rene", false, null, "Angeli", "RANGELI@CUMBRESCARACAS.EDU.VE", "RANGELI", null, null, false, "3ad402fa-9782-4262-87d8-763d494a1751", false, "rangeli" },
                    { "cf06e528-95e4-4c85-b3ac-6aa7c1b6a5a4", 0, "44a0bb0e-3102-441d-b428-9d710135e91d", "mhernandez@cumbrescaracas.edu.ve", false, "Hernandez", false, null, "Monica", "MHERNANDEZ@CUMBRESCARACAS.EDU.VE", "MHERNANDEZ", null, null, false, "05688aa3-87d9-44c5-9536-b03f47ff3673", false, "mhernandez" },
                    { "cf0de1be-240b-4bac-b83a-d0f85921ed38", 0, "5a2e229c-e856-41fd-a57f-8c03f0eb6722", "cadiaz@arcol.org", false, "Díaz", false, null, "Carolina", "CADIAZ@ARCOL.ORG", "CADIAZ", null, null, false, "71e4f805-7e3d-4c4d-a7a6-7537e04c3610", false, "cadiaz" },
                    { "d0c4e9ad-f5d6-4234-bdca-510d47afc4f4", 0, "c86af9e6-1c11-49a6-82e6-a25e2a7cab3d", "gcardas@cumbrescaracas.edu.ve", false, "Cardas", false, null, "Gwen", "GCARDAS@CUMBRESCARACAS.EDU.VE", "GCARDAS", null, null, false, "e5296dd5-2977-45d3-8769-671d47282286", false, "gcardas" },
                    { "d30a2c4c-16f2-4f1b-8452-8f1e6107f265", 0, "6cd884e5-db7c-4b9b-a558-8d3292477bdf", "mrocha@cumbrescaracas.edu.ve", false, "Vizcarrondo", false, null, "Marisela", "MROCHA@CUMBRESCARACAS.EDU.VE", "MROCHA", null, null, false, "e369e4e5-4766-4f83-9070-5c2e05fea0b4", false, "mrocha" },
                    { "d326d79c-2e1c-4f4f-917e-144ae7775ddc", 0, "0b75fee8-cb7d-440c-b8bf-2568a889737a", "malcala@cumbrescaracas.edu.ve", false, "Alcala", false, null, "Melissa", "MALCALA@CUMBRESCARACAS.EDU.VE", "MALCALA", null, null, false, "dd8d3c0f-4f36-4a3a-bf22-702382391278", false, "malcala" },
                    { "d386838c-d65b-429d-b7fc-220330033bb2", 0, "ef32c647-5dcb-4673-bca8-474d988c7d7a", "aortuno@cumbrescaracas.edu.ve", false, "Ortuño", false, null, "Andreulys", "AORTUNO@CUMBRESCARACAS.EDU.VE", "AORTUNO", null, null, false, "a751dcc7-a669-48f3-ba1c-8e13c9fa7eae", false, "aortuno" },
                    { "d6e46350-c06e-47b2-af89-7a446608fc59", 0, "b505a9dd-beed-4062-ad37-7cd2adf736e1", "amarzucco@cumbrescaracas.edu.ve", false, "Marzucco", false, null, "Alberto", "AMARZUCCO@CUMBRESCARACAS.EDU.VE", "AMARZUCCO", null, null, false, "58c51164-74cc-43b2-8f93-6bc87c018ee7", false, "amarzucco" },
                    { "dad7355d-669a-4c61-a5b1-f871f60375e4", 0, "85c82e78-d9a3-4f26-ac3b-a5689760c414", "dmoreau@cumbrescaracas.edu.ve", false, "Moreau", false, null, "Desiree", "DMOREAU@CUMBRESCARACAS.EDU.VE", "DMOREAU", null, null, false, "5e689ea8-302e-41cb-96be-e42dbe3eb96f", false, "dmoreau" },
                    { "de577d5f-a611-4ea7-a830-efe16360d37a", 0, "6dacb095-5cda-4d9a-bf28-37d3416ed7d6", "kbrun@cumbrescaracas.edu.ve", false, "Brun", false, null, "Karina", "KBRUN@CUMBRESCARACAS.EDU.VE", "KBRUN", null, null, false, "33e18900-9bb3-4588-ad13-8bf42595cb13", false, "kbrun" },
                    { "df4f3dcf-bdcb-41e7-a8d3-59b5328eab85", 0, "a7dc4c12-e1d2-47e9-91d9-dd188e75362c", "ayepes@cumbrescaracas.edu.ve", false, "Machado", false, null, "Ana Teresa", "AYEPES@CUMBRESCARACAS.EDU.VE", "AYEPES", null, null, false, "1f77670d-f50d-4d7b-81ec-db4600079b89", false, "ayepes" },
                    { "e2bc029a-a28e-4945-b84a-2a4df59864b8", 0, "dce6b806-5f78-43c9-9b68-a2dbe2d7b22d", "alovera@cumbrescarcas.edu.ve", false, "Lovera", false, null, "Adriana", "ALOVERA@CUMBRESCARCAS.EDU.VE", "ALOVERA", null, null, false, "dcd36860-4e08-408f-9c0f-1abc71880ac8", false, "alovera" },
                    { "ea9abe53-b47d-4f55-b21e-b1881a562a60", 0, "9e612b5c-d72a-442d-b785-e61d8cc62dd2", "lperezcastilla@legionaries.org", false, "Perez Castilla", false, null, "Leonardo", "LPEREZCASTILLA@LEGIONARIES.ORG", "LPEREZCASTILLA", null, null, false, "5783b9da-9dec-4770-b265-de6ba8bd1a8d", false, "lperezcastilla" },
                    { "ece4a554-1c7f-4e3a-a05f-a66c03b3c24d", 0, "a8ed7568-c62d-4d69-b0c3-2c0acaf488b6", "mvelasquez@cumbrescaracas.edu.ve", false, "Velásquez", false, null, "Perla Marina", "MVELASQUEZ@CUMBRESCARACAS.EDU.VE", "MVELASQUEZ", null, null, false, "ec159b2a-5735-4566-b0cb-6a5c8999ab17", false, "mvelasquez" },
                    { "efff3869-61b4-4358-9d3c-7974534fd654", 0, "03bc6539-da84-4231-95d1-2811e1b317b6", "lduquem@cumbrescaracas.edu.ve", false, "Duque", false, null, "Lilibeth", "LDUQUEM@CUMBRESCARACAS.EDU.VE", "LDUQUEM", null, null, false, "afd69951-38fc-46e7-bf5b-33de65872574", false, "lduquem" },
                    { "f10be28f-95e1-4c65-bb7d-eae98a3fc113", 0, "521be0df-45f2-4ba7-b399-b8811d42e147", "acorton@cumbrescaracas.edu.ve", false, "Corton", false, null, "Andrea", "ACORTON@CUMBRESCARACAS.EDU.VE", "ACORTON", null, null, false, "434dc7b2-1174-4fb1-822a-990296098c5f", false, "acorton" },
                    { "f1b5f11c-d9a4-481c-ba2e-46d4a7b72297", 0, "8f99bf91-525c-424b-aa5b-a01e36278024", "dlucero@cumbrescaracas.edu.ve", false, "Lucero", false, null, "Deyvi", "DLUCERO@CUMBRESCARACAS.EDU.VE", "DLUCERO", null, null, false, "56705d66-08c2-4747-9979-eccdadb2fd0f", false, "dlucero" },
                    { "f201c6c2-f2cc-4b83-84c6-a47822adb8d4", 0, "4b8f0a1b-b516-47c6-b411-8665e40efd6e", "dmata@cumbrescaracas.edu.ve", false, "Mata", false, null, "David", "DMATA@CUMBRESCARACAS.EDU.VE", "DMATA", null, null, false, "e795fe8b-1bfb-48eb-a6f5-d2042e830b66", false, "dmata" },
                    { "f2ad7c23-509c-4b55-99f6-7a47b3e85267", 0, "b90a1670-bc7b-4a98-b601-6934451261a8", "dbrando@cumbrescaracas.edu.ve", false, "Brando", false, null, "Daniel", "DBRANDO@CUMBRESCARACAS.EDU.VE", "DBRANDO", null, null, false, "5da742d2-b0b3-4e1d-b126-8d87f6e26978", false, "dbrando" },
                    { "f419c03d-d888-4001-a534-e86bf831070c", 0, "d6612e4c-d79b-4845-aa40-c7985af49524", "mpenaranda@cumbrescaracas.edu.ve", false, "Peñaranda", false, null, "María Antonieta", "MPENARANDA@CUMBRESCARACAS.EDU.VE", "MPENARANDA", null, null, false, "6f1664b0-795e-479e-b54e-4504e721256d", false, "mpenaranda" },
                    { "f41cee07-670e-4a28-83f1-928d70ed7349", 0, "7a151d8b-90e5-496b-8e3a-997f2c4c1f08", "mrangel@cumbrescaracas.edu.ve", false, "Rangel", false, null, "Marco Aurelio", "MRANGEL@CUMBRESCARACAS.EDU.VE", "MRANGEL", null, null, false, "bb3150ff-a81f-435c-a564-5f67c4c4820b", false, "mrangel" },
                    { "f4a8deb1-22d6-48a3-aa12-e156e940e6f0", 0, "bdf4be49-9f83-44fb-aba4-586f71e862b9", "cdearmas@cumbrescaracas.edu.ve", false, "De Armas", false, null, "Cristina", "CDEARMAS@CUMBRESCARACAS.EDU.VE", "CDEARMAS", null, null, false, "293b35fb-e2fe-4dea-9d6a-8dd424e4cdf7", false, "cdearmas" },
                    { "f4ec9d69-414b-4368-8796-4edfb41d0aa4", 0, "42c41c75-9c0d-4952-ae30-23da67630228", "myanez@cumbrescaracas.edu.ve", false, "Yanez", false, null, "Miguel Angel", "MYANEZ@CUMBRESCARACAS.EDU.VE", "MYANEZ", null, null, false, "52cc8ba1-4053-40bd-afd6-094a67cd422e", false, "myanez" },
                    { "f6dbd4e1-bea8-4a7e-b1a0-924701cc3327", 0, "1c171db9-8c07-4bbf-b253-42a90d400c8e", "jcaraballo@cumbrescaracas.edu.ve", false, "Caraballo", false, null, "José", "JCARABALLO@CUMBRESCARACAS.EDU.VE", "JCARABALLO", null, null, false, "a1a9442c-859c-415f-923e-4efcff695557", false, "jcaraballo" },
                    { "f732d176-6cc0-4047-9300-1c729d510d23", 0, "f1861e4e-701e-4c95-bf69-84663b4bd29f", "mdjekki@cumbrescaracas.edu.ve", false, "Djekki", false, null, "Marianela", "MDJEKKI@CUMBRESCARACAS.EDU.VE", "MDJEKKI", null, null, false, "c74f6af3-a324-4b26-b5e0-81a1d942d3f5", false, "mdjekki" },
                    { "fa1955cb-54c0-49e3-b73d-2a2544118f52", 0, "e18a01f4-76cb-40fc-8695-a83609ead2c1", "yarrayago@cumbrescaracas.edu.ve", false, "Arrayago", false, null, "Yldith", "YARRAYAGO@CUMBRESCARACAS.EDU.VE", "YARRAYAGO", null, null, false, "6bec0944-d845-4ca8-9c13-19e07d3f00f3", false, "yarrayago" },
                    { "fa28951c-c930-4c63-98b4-810c4cc83f40", 0, "cb45de30-0c88-4599-a07c-f42fe72768db", "ltavares@cumbrescaracas.edu.ve", false, "Tavares Goncalves", false, null, "Lisette", "LTAVARES@CUMBRESCARACAS.EDU.VE", "LTAVARES", null, null, false, "8b2fd678-b91d-4fdf-b785-55bd23c34b73", false, "ltavares" },
                    { "fc51353a-4607-4e2b-b64e-3d5d67c5399c", 0, "20245ceb-67e4-4669-902c-f98563c55559", "gcarvajal@cumbrescaracas.edu.ve", false, "Carvajal", false, null, "Gabriela", "GCARVAJAL@CUMBRESCARACAS.EDU.VE", "GCARVAJAL", null, null, false, "19ba1811-b003-4d01-bca0-66cd259f526d", false, "gcarvajal" },
                    { "fcc7fa9b-8ed1-44a7-a2d7-40780dc3dd63", 0, "aae9a718-9bc4-4372-9ff2-e49032f65181", "cnoguera@cumbrescaracas.edu.ve", false, "Noguera", false, null, "Carlos", "CNOGUERA@CUMBRESCARACAS.EDU.VE", "CNOGUERA", null, null, false, "b50c6b8d-8197-4240-b2f6-3ed86102eb2a", false, "cnoguera" },
                    { "fe682188-8f77-45e4-b5e2-16037c73c16b", 0, "4d2c29ae-8153-49fc-aee9-ebce6a4b2385", "ecalvo@cumbrescaracas.edu.ve", false, "Calvo", false, null, "Esther", "ECALVO@CUMBRESCARACAS.EDU.VE", "ECALVO", null, null, false, "a99f20f5-5dab-4272-97da-d2508ab329e4", false, "ecalvo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00416244-55ab-48d8-9829-6a3c3bb6d064");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00697ab8-7d45-4464-9574-62013c44b1bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00ea3354-fc30-45bf-9197-f95c4e71f254");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01df7b95-b356-40b5-907a-1f0c1b5c1008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "021f70a7-ba61-4de3-8c5e-e0a31e9ec1c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038c0670-8df4-44e6-8e7a-61d88f492568");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0500a6de-c43d-4ceb-8fd2-929475c01afa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05cf0b7c-2c16-4158-8536-a8dfe286c4bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06bcae5e-46d1-4112-8279-02994854cc58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07c39199-d777-40b6-9555-8a7deb5f3743");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a0a19ab-8af9-4e82-b037-5678a8a02c9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ab79bb2-9546-4de8-b5ff-30956a28647a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dc96b63-c33b-4390-9944-d9e4b331757e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6ad9ee-1861-4eb8-bc35-361099d8cf8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10c8d3e1-8d41-4c6a-8338-d570ab7c6a35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13330bb8-75ce-4fb3-bf49-5e43e2047957");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "177232c0-f3d3-4ec7-a289-446f054e900f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "184475e3-13bb-45f3-8b51-1a84eb8758ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bc72a4a-e613-44e9-aa7a-1ffb4b15bd65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c02187f-2a56-4a81-a563-6a6b55895fe3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce7051d-af8c-48c2-9156-ba88b5e1c4fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d1d221d-41e0-4dce-afc9-c44e98c32271");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d8d0ef1-a441-4b6e-9b97-e901cd2b14fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1db3db7c-c0dc-4594-b2ff-824f0c660e3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e180c0c-11a0-48e3-ada2-9acf92e61ad4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e45412d-2dfb-4842-b5ba-07c79c3a434a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fb74c96-e859-4f1c-879c-2c2ee6148c02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fba167a-d1b4-4c2a-8b6e-077c178c81d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21a29030-90c5-4079-8607-7dcd7d22bf20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "220ed2a3-1121-4d7a-a1aa-698a542643c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2222771e-3efc-4fec-a62a-cd27a5b9abf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2457a878-0e96-4742-9459-ebc895b9425c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24669978-a9e1-4211-a131-93d053226444");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24ef5f9f-887e-4ed6-bafe-2ee72601cac6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2530c832-4536-4e79-806f-d84fa6c61522");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "257a3b42-bb8d-4c3e-ae73-ee9ff658b569");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28505776-12f6-4db2-a039-d8831bbbbb69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3fdf95-e1d2-47fd-9229-902c00b6ff85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bc262d2-44c6-40d6-b8b9-4390d8278a45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d758233-1ed3-4e99-be0c-ce5273879d37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d8b3966-f1a1-40b6-a35a-3545872ef7a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3158ff0d-6abb-4dfc-969f-1867234da27f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "323a44c3-007d-41f0-ac6f-2c60796155de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e9d00e-1c9e-4c0d-858c-6a5fcf7f8ba1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33a72360-dd95-4bc6-a50d-192208aed158");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37a9d8a1-47a1-463a-8fe0-ba34d7319296");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "398b15c9-185d-4461-8673-c7a00afa0b3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b63ab6a-38b9-4d65-ae3d-846c95d5258e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bbc1aee-c499-4b80-bd46-8aee4d315560");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c1d8736-421c-4f28-85c4-103e9a721b3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c5488fa-b52d-46fa-bc2d-2bb3ec3722a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404926a7-1148-4397-a297-1427b322b712");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43032c92-7ffc-4ca0-9686-b94699b97376");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43e6d9db-98ad-474a-8a4f-66b2da601b15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45799f44-48e3-46f3-9584-023e89fc21e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45b295d9-b56c-4a89-808e-15518cbf2ca4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46b31416-eae6-4e8d-949d-49ec268e7e49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48403e12-5a35-46c2-bc76-4730c17b77cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d023a76-4f43-4eed-b670-9c52359837e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e51517b-527f-43cc-9ad1-e028168dce4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f253fcc-cb7e-47ba-8d21-2d1756b5103d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f68d965-c55a-4402-8907-36a6372fdf6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50e68a1d-6a34-446c-aed7-08ca93cabfd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51e4b08d-291b-4819-903f-cb0da0cb9759");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52844a63-9cfb-43f1-8a7a-a62ac40fbf68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560e3072-ba4b-4139-baf2-139565f8c191");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "567f2e03-9c43-4945-8acf-9a68c2d77573");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58b42f0b-0f45-4df1-abe7-2acb8237c61c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ae69c0b-a06d-4643-b13b-9ccd4e6070d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dd9720d-7b93-42c1-8435-e4d3ccf000bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ef4fa7b-9c88-4df2-84cf-203153433989");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f93f0df-8157-4481-84aa-2b524c18b215");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "605417a9-4203-4ab4-b7b7-729f538f9bc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6095b88a-f123-4762-9bac-0f4cda81547a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "616b60dc-2f9e-413a-a0db-df1065f535b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "630acbc8-a625-41bd-8850-f5160a2641be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6340480a-4509-4118-b060-a67e09ad2532");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "661616ab-9254-4e8b-b5e9-5ad9ac7956f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66bf5dd8-71af-4e85-9fd8-03fc4fc4e004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6838711e-9918-427f-a4da-3c9c7e0edc02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c6f14b9-8f77-46aa-90d4-fcd99a199fea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c8866e5-f978-44c0-bae3-09186dc5dd2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d62dd18-d867-4466-9738-6637546fde60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d6b9b06-5fe2-42e1-9234-26cba935e12e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e2a27dc-0ec1-4980-ae9c-0c6ef873fc36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f5a57c7-fbbe-4261-9055-a388e82ba81e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "705f51da-7adb-4800-ab6a-2d04b5e578bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73c13401-2748-4b6e-a83b-3175a2401e3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "767eb7fa-a84b-480f-8d77-5f1c2fd1e61c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "768574c9-20ae-4c1e-9e28-457bae8966cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76b2e5ad-5333-4fb9-8a45-ebc415241462");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79d9c729-d091-4e90-a831-eae2a96d4280");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bc781c9-d7e0-4c51-b805-7efb0e12060c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c0bdcfa-1b3d-4b13-9b16-72ff3b677f1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dc19937-b837-434c-bbeb-8fb8050f44ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7df5b86b-d090-4dfc-8cfb-a1a3e4128496");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f9cbac5-0385-48d6-ad5c-1d524febd734");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e13729-051a-4fa7-8f7f-0f37b1048027");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84047cd2-4bfd-446d-8c19-f4e4a9e11621");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84c76d4b-94da-4f32-909f-ac11c8154431");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8677d8d4-7741-4c9e-8644-8f6f95380c1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8812d8d6-6c69-4d92-b816-0845838c6a6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ac92417-cd94-48f8-ab14-0336a55600de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d922462-6f40-4b72-97d2-d6bbd7989fd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb2d23a-bb49-46d4-81d2-f1c08a480982");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fb3b6f6-6997-46c7-803c-569d6c3113df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9048514b-f2af-4358-8718-34cfc3b7b127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91e33b8e-f796-464d-8858-d261ecc28096");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "921a6762-eeba-4c6e-b5f2-fd8098be5e42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "930c8226-c673-4ec3-9ef5-de42253daf79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a4c2ea-56ee-4b7b-9bbe-8955b9252974");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94d53b17-7b98-4afa-935c-bf06b38757be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fc31c4-6564-48c5-9ce7-b5b8ed0bd2ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9785ebd7-ce33-4cb5-9eca-82e54ab6d9e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e5d85a-37dd-4695-a602-62cc608d282b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "988828c9-a504-43dc-93dc-082f76ed78ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a215488-34cf-4d12-8622-8a6a9dcabc06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a593634-1b81-4501-8898-d62d41958830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bceea00-e3b9-4495-afe5-73790de9d63d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bebc920-3442-456a-be89-71072d111baa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d5262e8-e2b1-4c17-a9d9-2f637873ce65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e3629ca-29a9-4dec-9ebc-947a0a855c8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a00460d7-c7a0-49c7-acf2-d66031e92ca3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3989650-9e58-4da5-90a7-3e0088bfbc1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5880a7b-2c1c-47cc-a3d6-c40510e683fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5cbf6c6-c0e5-4615-a92f-2b5fb0acc4d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6a21162-6d49-47e8-b200-61162a17cfc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6d23456-b074-4610-b83e-a63206180ec6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a83b71c8-7d77-4eaa-8dc9-b37fba5cd455");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab58ba52-5e84-4d6a-b4dd-e96a8d95bf3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0d05b61-d6e6-4a4f-8758-52e3fd550eb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2878b99-b78c-4d10-bceb-7070c590df4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c753fe-60d4-4933-b5ca-6f701540734e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6e130ea-a335-4558-a372-d6e2c0ab3338");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8a5157d-815d-46fe-8300-b90eabdbd489");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb7b1764-e687-4b50-9caa-fb19a7b83f1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbd522c6-cc5c-41dd-ba8b-ba2aad19c761");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be896722-79fc-431e-8bf1-1dd86fa3bfaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "beabf550-aad1-4b6b-b3f0-3e3d0e88cd3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "befeddf6-218a-4797-9e8d-a4d3ff3399cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c79f5d88-96db-4eb3-a7c4-1334e3eaf6dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8fc09f1-cfcf-4de7-87c6-5a578ed0af85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb93ffa7-251d-4d93-a560-5a61074a0c9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3fe06e-54fb-4bb0-978d-cfc2972782c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf06e528-95e4-4c85-b3ac-6aa7c1b6a5a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf0de1be-240b-4bac-b83a-d0f85921ed38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0c4e9ad-f5d6-4234-bdca-510d47afc4f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d30a2c4c-16f2-4f1b-8452-8f1e6107f265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d326d79c-2e1c-4f4f-917e-144ae7775ddc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d386838c-d65b-429d-b7fc-220330033bb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6e46350-c06e-47b2-af89-7a446608fc59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad7355d-669a-4c61-a5b1-f871f60375e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de577d5f-a611-4ea7-a830-efe16360d37a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4f3dcf-bdcb-41e7-a8d3-59b5328eab85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2bc029a-a28e-4945-b84a-2a4df59864b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea9abe53-b47d-4f55-b21e-b1881a562a60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece4a554-1c7f-4e3a-a05f-a66c03b3c24d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efff3869-61b4-4358-9d3c-7974534fd654");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f10be28f-95e1-4c65-bb7d-eae98a3fc113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1b5f11c-d9a4-481c-ba2e-46d4a7b72297");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f201c6c2-f2cc-4b83-84c6-a47822adb8d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2ad7c23-509c-4b55-99f6-7a47b3e85267");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f419c03d-d888-4001-a534-e86bf831070c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f41cee07-670e-4a28-83f1-928d70ed7349");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4a8deb1-22d6-48a3-aa12-e156e940e6f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ec9d69-414b-4368-8796-4edfb41d0aa4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6dbd4e1-bea8-4a7e-b1a0-924701cc3327");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f732d176-6cc0-4047-9300-1c729d510d23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa1955cb-54c0-49e3-b73d-2a2544118f52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa28951c-c930-4c63-98b4-810c4cc83f40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc51353a-4607-4e2b-b64e-3d5d67c5399c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcc7fa9b-8ed1-44a7-a2d7-40780dc3dd63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe682188-8f77-45e4-b5e2-16037c73c16b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastNames", "LockoutEnabled", "LockoutEnd", "Names", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a288e6a4-2f61-4dbf-ad97-d6d21b564002", 0, "fd3d87cb-4915-4867-9308-1a21d86706cb", "nadorno@cumbrescaracas.edu.ve", false, "Adorno", false, null, "Nayi", "NADORNO@CUMBRESCARACAS.EDU.VE", "NADORNO", null, null, false, "47a76f0c-86cb-431e-a396-60f124c064d2", 0, false, "nadorno" });
        }
    }
}
