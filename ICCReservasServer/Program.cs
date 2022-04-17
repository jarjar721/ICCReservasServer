using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Entities.Data;
using Entities.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ICCReservasServer.DTOs;
using ICCReservasServer.Repos;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDataContextConnection");

builder.Services.AddDbContext<ApplicationDataContext>(options =>
    options.UseNpgsql(connectionString, options => options.MigrationsAssembly("ICCReservasServer")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDataContext>();
// Add services to the container.

// Inject appsettings
builder.Services.Configure<ApplicationSettings>(builder.Configuration.GetSection("ApplicationSettings"));

builder.Services.Configure<IdentityOptions>(options =>
    {
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 3;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;

        options.User.RequireUniqueEmail = true;

        options.SignIn.RequireConfirmedEmail = true;

        options.Lockout.AllowedForNewUsers = false;
    });

builder.Services.AddCors();
builder.Services.AddScoped<IDispositivosRepository, DispositivosRepository>();

//JWT Authentication
var JWT_Secret = builder.Configuration.GetSection("ApplicationSettings:JWT_Secret").Value;
var Client_URL = builder.Configuration.GetSection("ApplicationSettings:Client_URL").Value;

var key = Encoding.UTF8.GetBytes(JWT_Secret);

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = false;
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key), // AQUI VA key
            ValidateIssuer = false,
            ValidateAudience = false,
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors(builder =>
    {
        builder.WithOrigins(Client_URL) // ALL ORIGINS --> "*"
        .AllowAnyHeader()
        .AllowAnyMethod();
    }
);

app.MapControllers();

app.Run();
