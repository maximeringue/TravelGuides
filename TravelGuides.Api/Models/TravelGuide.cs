namespace TravelGuides.Api.Models;

public class TravelGuide
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public int NumberOfDays { get; set; }

    public string Mobility { get; set; } = "";
    public string Season { get; set; } = "";
    public string Audience { get; set; } = "";

    public List<GuideActivity> Activities { get; set; } = [];
}