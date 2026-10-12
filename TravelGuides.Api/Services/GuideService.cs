using Microsoft.EntityFrameworkCore;
using TravelGuides.Api.Data;
using TravelGuides.Api.ViewModels;

namespace TravelGuides.Api.Services;

public class GuideService
{
    private readonly AppDbContext _db;

    public GuideService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<GuideSummaryViewModel>> GetAllAsync(
        CancellationToken cancellationToken = default)
    {
        return await _db.Guides
            .AsNoTracking()
            .OrderBy(g => g.Title)
            .Select(g => new GuideSummaryViewModel
            {
                Id = g.Id,
                Title = g.Title,
                Description = g.Description,
                NumberOfDays = g.NumberOfDays
            })
            .ToListAsync(cancellationToken);
    }

    public async Task<GuideDetailsViewModel?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken = default)
    {
        var guide = await _db.Guides
            .AsNoTracking()
            .Include(g => g.Activities)
            .SingleOrDefaultAsync(
                g => g.Id == id,
                cancellationToken);

        if (guide is null)
        {
            return null;
        }

        return new GuideDetailsViewModel
        {
            Id = guide.Id,
            Title = guide.Title,
            Description = guide.Description,
            NumberOfDays = guide.NumberOfDays,
            Mobility = guide.Mobility,
            Season = guide.Season,
            Audience = guide.Audience,

            Activities = guide.Activities
                .OrderBy(a => a.Day)
                .ThenBy(a => a.VisitOrder)
                .Select(a => new ActivityViewModel
                {
                    Id = a.Id,
                    Day = a.Day,
                    VisitOrder = a.VisitOrder,
                    Title = a.Title,
                    Description = a.Description,
                    Category = a.Category,
                    Address = a.Address,
                    Phone = a.Phone,
                    OpeningHours = a.OpeningHours,
                    Website = a.Website
                })
                .ToList()
        };
    }
}