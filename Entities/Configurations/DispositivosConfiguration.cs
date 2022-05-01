using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configurations
{
    internal class DispositivosConfiguration : IEntityTypeConfiguration<Dispositivos>
    {
        public void Configure(EntityTypeBuilder<Dispositivos> builder)
        {
            builder.ToTable("Dispositivos");

            builder.HasData(
                //DUMMY DATA
                new Dispositivos { ID = 1, Tipo = "Laptop", Serial = "345VEG", Marca = "DELL", Modelo = "X1", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1},
                new Dispositivos { ID = 2, Tipo = "Laptop", Serial = "NFG456", Marca = "ACER", Modelo = "T3", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1},
                new Dispositivos { ID = 3, Tipo = "Laptop", Serial = "BRI456", Marca = "ASUS", Modelo = "D4", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 4, Tipo = "Laptop", Serial = "NWO203", Marca = "HP", Modelo = "S6", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 5, Tipo = "Tablet", Serial = "0K7B6F", Marca = "SAMSUNG", Modelo = "S3", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 6, Tipo = "Tablet", Serial = "1K2J3H", Marca = "SAMSUNG", Modelo = "S2", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 7, Tipo = "Tablet", Serial = "4J8FC7", Marca = "HUAWEI", Modelo = "TRX3", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 8, Tipo = "Tablet", Serial = "2MN3B4", Marca = "HUAWEI", Modelo = "34RF", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 9, Tipo = "Cable", Serial = "PLO094", Marca = "KINGSTON", Modelo = "CVT4", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                new Dispositivos { ID = 10, Tipo = "Cable", Serial = "CYD837", Marca = "KINGSTON", Modelo = "GTR3", Observacion = "TEST DEVICE", Uso = "TEST USO", Ubicacion = "TEST UBICACIÓN", Status = 1 },
                
                //PROYECTORES
                new Dispositivos {
                    ID = 11, Tipo = "Proyector", Serial = "TVAK4904105", Marca = "Epson",
                    Modelo = "PowerLite S18+", Observacion = "Buenas condiciones. Moderno (HDMI USB)",
                    Uso = "Móvil", Ubicacion = "Depósito", Status = 1
                },
                new Dispositivos {
                    ID = 12, Tipo = "Proyector", Serial = "PSPK2407501", Marca = "Epson",
                    Modelo = "PowerLite S12+", Observacion = "Buenas condiciones. Lámpara con potencia 64 H",
                    Uso = "Móvil", Ubicacion = "Depósito", Status = 1
                },
                new Dispositivos {
                    ID = 13, Tipo = "Proyector", Serial = "PSPK2412010", Marca = "Epson",
                    Modelo = "PowerLite S12+", Observacion = "Buenas condiciones. Lámpara con potencia 344 H",
                    Uso = "Móvil", Ubicacion = "Oficina José Rivas", Status = 1
                },
                new Dispositivos {
                    ID = 14, Tipo = "Proyector", Serial = "AVFC73900421", Marca = "InFocus",
                    Modelo = "IN26+", Observacion = "Regular condiciones. Lámpara con baja potencia 2850 H",
                    Uso = "Fijo", Ubicacion = "Sala Didáctica de Primaria (Lab. Computación)", Status = 1
                },
                new Dispositivos {
                    ID = 15, Tipo = "Proyector", Serial = "BMYB44404905", Marca = "InFocus",
                    Modelo = "IN112A", Observacion = "Regular condiciones. Lámpara con potencia 1051H",
                    Uso = "Fijo", Ubicacion = "Sala Didáctica de Bachillerato (Lab. Computación)", Status = 1
                },
                new Dispositivos {
                    ID = 16, Tipo = "Proyector", Serial = "DESCONOCIDO", Marca = "InFocus",
                    Modelo = "DESCONOCIDO", Observacion = "Regular condiciones. Lámpara con baja potencia 2850 H",
                    Uso = "Móvil", Ubicacion = "Oficina José Alemán", Status = 1
                },
                new Dispositivos {
                    ID = 17, Tipo = "Proyector", Serial = "00062667LE", Marca = "Epson",
                    Modelo = "DESCONOCIDO", Observacion = "Regular condiciones. Lámpara con potencia 899 H",
                    Uso = "Fijo", Ubicacion = "Sala Multimedia al lado Sala Didáctica de Primaria (Lab. Computación)", Status = 1
                },
                new Dispositivos {
                    ID = 18, Tipo = "Proyector", Serial = "IN112A", Marca = "InFocus",
                    Modelo = "DESCONOCIDO", Observacion = "Regular condiciones. Lámpara con baja potencia 2553 H",
                    Uso = "Fijo", Ubicacion = "Auditorio", Status = 1
                }
            );
        }
    }
}
