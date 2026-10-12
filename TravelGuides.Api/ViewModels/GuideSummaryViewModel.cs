namespace TravelGuides.Api.ViewModels;

public class GuideSummaryViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public int NumberOfDays { get; set; }
}