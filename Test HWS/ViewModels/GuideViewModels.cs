namespace Test_HWS.ViewModels;

public class GuideSummaryViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public int NumberOfDays { get; set; }
}

public class GuideDetailsViewModel : GuideSummaryViewModel
{
    public string Mobility { get; set; } = "";
    public string Season { get; set; } = "";
    public string Audience { get; set; } = "";

    public List<ActivityViewModel> Activities { get; set; } = [];
}

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