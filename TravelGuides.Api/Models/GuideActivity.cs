namespace TravelGuides.Api.Models;

public class GuideActivity
{
    public int Id { get; set; }

    public int TravelGuideId { get; set; }
    public TravelGuide TravelGuide { get; set; } = null!;

    public int Day { get; set; }
    public int VisitOrder { get; set; }

    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";

    public string Address { get; set; } = "";
    public string Phone { get; set; } = "";
    public string OpeningHours { get; set; } = "";
    public string Website { get; set; } = "";
}