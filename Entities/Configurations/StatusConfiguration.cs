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
    internal class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");

            builder.HasData(
                new Status { ID = 1, Codigo = 1, Tipo = "Pendiente", Descripcion = "El requerimiento ha sido creado y espera ser procesado."},
                new Status { ID = 2, Codigo = 2, Tipo = "En proceso", Descripcion = "El requerimiento ha sido tomado y se encuentra en proceso de ser gestionado."},
                new Status { ID = 3, Codigo = 3, Tipo = "Completado", Descripcion = "El requerimiento ha sido procesado y completado."}
            );
        }
    }
}
