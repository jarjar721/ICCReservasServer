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
                new Dispositivos { ID = 1, Tipo = "Laptop", Serial = "345VEG", Marca = "DELL", Modelo = "X1", Descripcion = "TEST DEVICE", Status = 1},
                new Dispositivos { ID = 2, Tipo = "Laptop", Serial = "NFG456", Marca = "ACER", Modelo = "T3", Descripcion = "TEST DEVICE", Status = 1},
                new Dispositivos { ID = 3, Tipo = "Laptop", Serial = "BRI456", Marca = "ASUS", Modelo = "D4", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 4, Tipo = "Laptop", Serial = "NWO203", Marca = "HP", Modelo = "S6", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 5, Tipo = "Proyector", Serial = "298CCV", Marca = "EPSON", Modelo = "VXA", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 6, Tipo = "Proyector", Serial = "HNY4RT", Marca = "EPSON", Modelo = "A4E", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 7, Tipo = "Proyector", Serial = "3F5H6J", Marca = "HP", Modelo = "WER2", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 8, Tipo = "Tablet", Serial = "0K7B6F", Marca = "SAMSUNG", Modelo = "S3", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 9, Tipo = "Tablet", Serial = "1K2J3H", Marca = "SAMSUNG", Modelo = "S2", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 10, Tipo = "Tablet", Serial = "4J8FC7", Marca = "HUAWEI", Modelo = "TRX3", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 11, Tipo = "Tablet", Serial = "2MN3B4", Marca = "HUAWEI", Modelo = "34RF", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 12, Tipo = "Cable", Serial = "PLO094", Marca = "KINGSTON", Modelo = "CVT4", Descripcion = "TEST DEVICE", Status = 1 },
                new Dispositivos { ID = 13, Tipo = "Cable", Serial = "CYD837", Marca = "KINGSTON", Modelo = "GTR3", Descripcion = "TEST DEVICE", Status = 1 }
            );
        }
    }
}
