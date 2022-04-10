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
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("AspNetUsers");
            builder.Property(property => property.Status).HasDefaultValue(1);

            builder.HasData(
                new ApplicationUser { 
                    Names = "Nayi", LastNames = "Adorno", Email = "nadorno@cumbrescaracas.edu.ve", UserName = "nadorno",
                    NormalizedUserName = "NADORNO", NormalizedEmail = "NADORNO@CUMBRESCARACAS.EDU.VE"
                }    
            );

        }
    }
}
