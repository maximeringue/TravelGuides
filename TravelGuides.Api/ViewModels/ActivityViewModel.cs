namespace TravelGuides.Api.ViewModels;

public class ActivityViewModel
{
    public int Id { get; set; }
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