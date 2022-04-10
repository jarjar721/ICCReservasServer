using Entities.Configurations;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entities.Data;

public class ApplicationDataContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new InstalacionesConfiguration());
        builder.ApplyConfiguration(new StatusConfiguration());
        builder.ApplyConfiguration(new HorariosConfiguration());
        builder.ApplyConfiguration(new MateriasConfiguration());
        builder.ApplyConfiguration(new DispositivosConfiguration());

    }

    public DbSet<Instalaciones> Instalaciones { get; set; }

    public DbSet<Dispositivos> Dispositivos { get; set; }

    public DbSet<Horarios> Horarios { get; set; }

    public DbSet<Materias> Materias { get; set; }

    public DbSet<Clases> Clases { get; set; }
}
