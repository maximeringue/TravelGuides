using Microsoft.EntityFrameworkCore;
using TravelGuides.Api.Data;
using TravelGuides.Api.Services;
using Microsoft.AspNetCore.Identity;
using TravelGuides.Api.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException(
        "La connexion DefaultConnection est manquante.");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<GuideService>();

builder.Services
    .AddIdentityCore<ApplicationUser>(options =>
    {
        options.User.RequireUniqueEmail = true;

        options.Password.RequiredLength = 8;
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = true;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();

    await IdentitySeeder.SeedAsync(scope.ServiceProvider);

    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();