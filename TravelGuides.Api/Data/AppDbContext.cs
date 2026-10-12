using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TravelGuides.Api.Models;

namespace TravelGuides.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TravelGuide> Guides => Set<TravelGuide>();
    public DbSet<GuideActivity> Activities => Set<GuideActivity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TravelGuide>(entity =>
        {
            entity.Property(g => g.Title)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(g => g.Description).IsRequired();

            entity.Property(g => g.Mobility).HasMaxLength(50);
            entity.Property(g => g.Season).HasMaxLength(50);
            entity.Property(g => g.Audience).HasMaxLength(50);

            entity.HasMany(g => g.Activities)
                .WithOne(a => a.TravelGuide)
                .HasForeignKey(a => a.TravelGuideId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<GuideActivity>(entity =>
        {
            entity.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(a => a.Category)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(a => a.Address).HasMaxLength(500);
            entity.Property(a => a.Phone).HasMaxLength(50);
            entity.Property(a => a.OpeningHours).HasMaxLength(500);
            entity.Property(a => a.Website).HasMaxLength(1000);

            entity.HasIndex(a => new
            {
                a.TravelGuideId,
                a.Day,
                a.VisitOrder
            }).IsUnique();
        });

        modelBuilder.Entity<TravelGuide>().HasData(
            new TravelGuide
            {
                Id = 1,
                Title = "Week-end à Paris",
                Description = "Musées et promenades au cœur de Paris.",
                NumberOfDays = 2,
                Mobility = "À pied",
                Season = "Printemps",
                Audience = "Entre amis"
            },
            new TravelGuide
            {
                Id = 2,
                Title = "Les châteaux de la Loire",
                Description = "Trois jours de découverte des châteaux.",
                NumberOfDays = 3,
                Mobility = "Voiture",
                Season = "Été",
                Audience = "Famille"
            }
        );

        modelBuilder.Entity<GuideActivity>().HasData(
            new GuideActivity
            {
                Id = 1,
                TravelGuideId = 1,
                Day = 1,
                VisitOrder = 1,
                Title = "Musée du Louvre",
                Description = "Découverte des collections.",
                Category = "musée",
                Address = "Adresse de démonstration",
                Phone = "Non renseigné",
                OpeningHours = "Horaires de démonstration",
                Website = "https://www.louvre.fr"
            },
            new GuideActivity
            {
                Id = 2,
                TravelGuideId = 1,
                Day = 1,
                VisitOrder = 2,
                Title = "Jardin des Tuileries",
                Description = "Promenade dans les jardins.",
                Category = "parc"
            },
            new GuideActivity
            {
                Id = 3,
                TravelGuideId = 1,
                Day = 2,
                VisitOrder = 1,
                Title = "Montmartre",
                Description = "Balade dans le quartier.",
                Category = "activité"
            },
            new GuideActivity
            {
                Id = 4,
                TravelGuideId = 2,
                Day = 1,
                VisitOrder = 1,
                Title = "Château de Chambord",
                Description = "Visite du château.",
                Category = "château"
            },
            new GuideActivity
            {
                Id = 5,
                TravelGuideId = 2,
                Day = 2,
                VisitOrder = 1,
                Title = "Château de Chenonceau",
                Description = "Découverte du château et des jardins.",
                Category = "château"
            },
            new GuideActivity
            {
                Id = 6,
                TravelGuideId = 2,
                Day = 3,
                VisitOrder = 1,
                Title = "Château d’Amboise",
                Description = "Visite du château royal.",
                Category = "château"
            }
        );
    }
}
