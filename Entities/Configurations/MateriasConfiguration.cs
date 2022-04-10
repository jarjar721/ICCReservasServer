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
    internal class MateriasConfiguration : IEntityTypeConfiguration<Materias>
    {
        public void Configure(EntityTypeBuilder<Materias> builder)
        {
            builder.ToTable("Materias");

            builder.HasData(
                // HS - 3ER AÑO
                new Materias { ID = 1, Codigo = "HS-9-1", Nivel = "HS", Grado = "9", Nombre = "Química", Descripcion = "Descripción de Química", Status = 1 },
                new Materias { ID = 2, Codigo = "HS-9-2", Nivel = "HS", Grado = "9", Nombre = "Geografía de Venezuela", Descripcion = "Descripción de Geografía de Venezuela", Status = 1 },
                new Materias { ID = 3, Codigo = "HS-9-3", Nivel = "HS", Grado = "9", Nombre = "Oratoria", Descripcion = "Descripción de Oratoria", Status = 1 },
                new Materias { ID = 4, Codigo = "HS-9-4", Nivel = "HS", Grado = "9", Nombre = "Informática", Descripcion = "Descripción de Informática", Status = 1 },
                new Materias { ID = 5, Codigo = "HS-9-5", Nivel = "HS", Grado = "9", Nombre = "Inglés", Descripcion = "Descripción de Inglés", Status = 1 },
                new Materias { ID = 6, Codigo = "HS-9-6", Nivel = "HS", Grado = "9", Nombre = "Biología", Descripcion = "Descripción de Biología", Status = 1 },
                new Materias { ID = 7, Codigo = "HS-9-7", Nivel = "HS", Grado = "9", Nombre = "Formación Católica", Descripcion = "Descripción de Formación Católica", Status = 1 },
                new Materias { ID = 8, Codigo = "HS-9-8", Nivel = "HS", Grado = "9", Nombre = "Change Maker", Descripcion = "Descripción de Change Maker", Status = 1 },
                new Materias { ID = 9, Codigo = "HS-9-9", Nivel = "HS", Grado = "9", Nombre = "Tutoría", Descripcion = "Descripción de Tutoría", Status = 1 },
                new Materias { ID = 10, Codigo = "HS-9-10", Nivel = "HS", Grado = "9", Nombre = "Matemática", Descripcion = "Descripción de Matemática", Status = 1 },
                new Materias { ID = 11, Codigo = "HS-9-11", Nivel = "HS", Grado = "9", Nombre = "Física", Descripcion = "Descripción de Física", Status = 1 },
                new Materias { ID = 12, Codigo = "HS-9-12", Nivel = "HS", Grado = "9", Nombre = "Castellano", Descripcion = "Descripción de Castellano", Status = 1 },
                new Materias { ID = 13, Codigo = "HS-9-13", Nivel = "HS", Grado = "9", Nombre = "Educación Física", Descripcion = "Descripción de Educación Física", Status = 1 },
                new Materias { ID = 14, Codigo = "HS-9-14", Nivel = "HS", Grado = "9", Nombre = "Electiva", Descripcion = "Descripción de Electiva", Status = 1 }
            );
        }
    }
}
