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
    internal class InstalacionesConfiguration : IEntityTypeConfiguration<Instalaciones>
    {
        public void Configure(EntityTypeBuilder<Instalaciones> builder)
        {
            builder.ToTable("Instalaciones");

            builder.HasData(
                //SOTANO
                //Deposito 1
                new Instalaciones
                {
                    ID = 1, Codigo = "HS-S-1", Nombre = "Deposito 1", Tipo = "Deposito", Descripcion = "Deposito 1 en el sotano.",
                    Capacidad = 0, Edificio = "HS", Piso = "S", Status = 0
                },
                //Ciencias de la Tierra
                new Instalaciones
                {
                    ID = 2,
                    Codigo = "HS-S-2", Nombre = "Ciencias de la Tierra", Tipo = "Aula", Descripcion = "Salón de Ciencias de la Tierra",
                    Capacidad = 15, Edificio = "HS", Piso = "S", Status = 1
                },
                //Dibujo Técnico
                new Instalaciones
                {
                    ID = 3,
                    Codigo = "HS-S-3", Nombre = "Dibujo Técnico", Tipo = "Aula", Descripcion = "Salón de Dibujo Técnico",
                    Capacidad = 15, Edificio = "HS", Piso = "S", Status = 1
                },
                //Deposito 2
                new Instalaciones
                {
                    ID = 4,
                    Codigo = "HS-S-4", Nombre = "Deposito 2", Tipo = "Deposito", Descripcion = "Deposito 2 en el sotano.",
                    Capacidad = 0, Edificio = "HS", Piso = "S", Status = 0
                },
                //Laboratorio de Biología (Salón 2)
                new Instalaciones
                {
                    ID = 5,
                    Codigo = "HS-S-5", Nombre = "Laboratorio de Biología (Salón 2)", Tipo = "Laboratorio", Descripcion = "Laboratorio de Biología (Salón 2)",
                    Capacidad = 20, Edificio = "HS", Piso = "S", Status = 1
                },
                //Laboratorio de Física (Salón 2)
                new Instalaciones
                {
                    ID = 6,
                    Codigo = "HS-S-6", Nombre = "Laboratorio de Física", Tipo = "Laboratorio", Descripcion = "Laboratorio de Física (Salón 2)",
                    Capacidad = 20, Edificio = "HS", Piso = "S", Status = 1
                },
                //Laboratorio de Química (Salón 2)
                new Instalaciones
                {
                    ID = 7,
                    Codigo = "HS-S-7", Nombre = "Laboratorio de Química", Tipo = "Laboratorio", Descripcion = "Laboratorio de Química (Salón 2)",
                    Capacidad = 20, Edificio = "HS", Piso = "S", Status = 1
                },
                //Laboratorio de Biología (Salón 1)
                new Instalaciones
                {
                    ID = 8,
                    Codigo = "HS-S-8", Nombre = "Laboratorio de Biología (Salón 1)", Tipo = "Laboratorio", Descripcion = "Laboratorio de Biología (Salón 1)",
                    Capacidad = 20, Edificio = "HS", Piso = "S", Status = 1
                },

                //PISO 1
                //Humanidades/Tutoría Salón 2
                new Instalaciones {
                    ID = 9,
                    Codigo = "HS-1-1", Nombre = "Humanidades/Tutoría Salón 2", Tipo = "Aula", Descripcion = "Salón 2 de Humanidades/Tutoría",
                    Capacidad = 20, Edificio = "HS", Piso = "1", Status = 1
                },
                //Humanidades/Tutoría Salón 1
                new Instalaciones
                {
                    ID = 10,
                    Codigo = "HS-1-2", Nombre = "Humanidades/Tutoría Salón 1", Tipo = "Aula", Descripcion = "Salón 1 de Humanidades/Tutoría",
                    Capacidad = 25, Edificio = "HS", Piso = "1", Status = 1
                },
                //Study Hall
                new Instalaciones
                {
                    ID = 11,
                    Codigo = "HS-1-3", Nombre = "Study Hall", Tipo = "Aula", Descripcion = "Sala de estudios",
                    Capacidad = 20, Edificio = "HS", Piso = "1", Status = 1
                },
                //Ciencias Sociales
                new Instalaciones
                {
                    ID = 12,
                    Codigo = "HS-1-4", Nombre = "Ciencias Sociales", Tipo = "Aula", Descripcion = "Salón de Ciencias Sociales",
                    Capacidad = 25, Edificio = "HS", Piso = "1", Status = 1
                },
                //Química Salon 1
                new Instalaciones
                {
                    ID = 13,
                    Codigo = "HS-1-5", Nombre = "Química Salon 1", Tipo = "Aula", Descripcion = "Salón 1 de Química",
                    Capacidad = 25, Edificio = "HS", Piso = "1", Status = 1
                },
                //Catholic Leadership Change Makers
                new Instalaciones
                {
                    ID = 14,
                    Codigo = "HS-1-6", Nombre = "Catholic Leadership Change Makers", Tipo = "Aula", Descripcion = "Salón de Catholic Leadership Change Makers",
                    Capacidad = 25, Edificio = "HS", Piso = "1", Status = 1
                },
                //Oficina Directiva 1
                new Instalaciones
                {
                    ID = 15,
                    Codigo = "HS-1-7", Nombre = "Oficina Directiva 1", Tipo = "Oficina", Descripcion = "Oficina Directiva 1",
                    Capacidad = 3, Edificio = "HS", Piso = "1", Status = 1
                }

                );
        }
    }
}
