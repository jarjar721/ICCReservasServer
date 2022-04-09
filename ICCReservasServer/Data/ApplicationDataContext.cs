using ICCReservasServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Data;

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
    }

    public DbSet<ICCReservasServer.Models.Instalaciones> Instalaciones { get; set; }

    public DbSet<ICCReservasServer.Models.Dispositivos> Dispositivos { get; set; }
}
