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
                // HIGH SCHOOL
                new Horarios { ID = 1, Nivel = "HS", Nombre = "Primera Hora", HoraInicio = "07:30:00", HoraFin = "08:15:00"},
                new Horarios { ID = 2, Nivel = "HS", Nombre = "Segunda Hora", HoraInicio = "08:15:00", HoraFin = "09:00:00" },
                new Horarios { ID = 3, Nivel = "HS", Nombre = "Tercera Hora", HoraInicio = "09:45:00", HoraFin = "10:30:00" },
                new Horarios { ID = 4, Nivel = "HS", Nombre = "Cuarta Hora", HoraInicio = "10:30:00", HoraFin = "11:15:00" },
                new Horarios { ID = 5, Nivel = "HS", Nombre = "Quinta Hora", HoraInicio = "11:15:00", HoraFin = "12:00:00" },
                new Horarios { ID = 6, Nivel = "HS", Nombre = "Sexta Hora", HoraInicio = "12:30:00", HoraFin = "13:15:00" },
                new Horarios { ID = 7, Nivel = "HS", Nombre = "Séptima Hora", HoraInicio = "13:15:00", HoraFin = "14:00:00" },

                // MIDDLE SCHOOL
                new Horarios { ID = 8, Nivel = "MS", Nombre = "Primera Hora", HoraInicio = "08:15:00", HoraFin = "09:00:00" },
                new Horarios { ID = 9, Nivel = "MS", Nombre = "Segunda Hora", HoraInicio = "09:00:00", HoraFin = "09:45:00" },
                new Horarios { ID = 10, Nivel = "MS", Nombre = "Tercera Hora", HoraInicio = "10:30:00", HoraFin = "11:15:00" },
                new Horarios { ID = 11, Nivel = "MS", Nombre = "Cuarta Hora", HoraInicio = "11:15:00", HoraFin = "12:00:00" },
                new Horarios { ID = 12, Nivel = "MS", Nombre = "Quinta Hora", HoraInicio = "12:10:00", HoraFin = "12:55:00" },
                new Horarios { ID = 13, Nivel = "MS", Nombre = "Sexta Hora", HoraInicio = "12:55:00", HoraFin = "13:40:00" },

                // UPPER ELEMENTARY
                new Horarios { ID = 14, Nivel = "UE", Nombre = "Primera Hora", HoraInicio = "08:50:00", HoraFin = "09:40:00" },
                new Horarios { ID = 15, Nivel = "UE", Nombre = "Segunda Hora", HoraInicio = "09:40:00", HoraFin = "10:30:00" },
                new Horarios { ID = 16, Nivel = "UE", Nombre = "Tercera Hora", HoraInicio = "11:15:00", HoraFin = "12:00:00" },
                new Horarios { ID = 17, Nivel = "UE", Nombre = "Cuarta Hora", HoraInicio = "12:00:00", HoraFin = "12:45:00" },
                new Horarios { ID = 18, Nivel = "UE", Nombre = "Quinta Hora", HoraInicio = "13:05:00", HoraFin = "13:50:00" },
                new Horarios { ID = 19, Nivel = "UE", Nombre = "Sexta Hora", HoraInicio = "13:50:00", HoraFin = "14:35:00" },

                //LOWER ELEMENTARY
                new Horarios { ID = 20, Nivel = "LE", Nombre = "Primera Hora", HoraInicio = "08:50:00", HoraFin = "09:40:00" },
                new Horarios { ID = 21, Nivel = "LE", Nombre = "Segunda Hora", HoraInicio = "09:40:00", HoraFin = "10:30:00" },
                new Horarios { ID = 22, Nivel = "LE", Nombre = "Tercera Hora", HoraInicio = "10:30:00", HoraFin = "11:15:00" },
                new Horarios { ID = 23, Nivel = "LE", Nombre = "Cuarta Hora", HoraInicio = "12:00:00", HoraFin = "12:45:00" },
                new Horarios { ID = 24, Nivel = "LE", Nombre = "Quinta Hora", HoraInicio = "12:45:00", HoraFin = "13:30:00" },
                new Horarios { ID = 25, Nivel = "LE", Nombre = "Sexta Hora", HoraInicio = "13:50:00", HoraFin = "14:35:00" }
            );
        }
    }
}
