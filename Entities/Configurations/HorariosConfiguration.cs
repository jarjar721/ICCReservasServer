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
    internal class HorariosConfiguration : IEntityTypeConfiguration<Horarios>
    {
        public void Configure(EntityTypeBuilder<Horarios> builder)
        {
            builder.ToTable("Horarios");

            builder.HasData(
                new Horarios { ID = 1, Nivel = "HS", Numero = 1, HoraInicio = "07:30:00", HoraFin = "08:15:00"},
                new Horarios { ID = 2, Nivel = "HS", Numero = 2, HoraInicio = "08:15:00", HoraFin = "09:00:00" },
                new Horarios { ID = 3, Nivel = "HS", Numero = 3, HoraInicio = "09:45:00", HoraFin = "10:30:00" },
                new Horarios { ID = 4, Nivel = "HS", Numero = 4, HoraInicio = "10:30:00", HoraFin = "11:15:00" },
                new Horarios { ID = 5, Nivel = "HS", Numero = 5, HoraInicio = "11:15:00", HoraFin = "12:00:00" },
                new Horarios { ID = 6, Nivel = "HS", Numero = 6, HoraInicio = "12:30:00", HoraFin = "13:15:00" },
                new Horarios { ID = 7, Nivel = "HS", Numero = 7, HoraInicio = "13:15:00", HoraFin = "14:00:00" }
            );
        }
    }
}
