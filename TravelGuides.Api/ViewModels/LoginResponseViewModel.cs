namespace TravelGuides.Api.ViewModels;

public class LoginResponseViewModel
{
    public string AccessToken { get; set; } = "";
    public DateTime ExpiresAtUtc { get; set; }
    public string Email { get; set; } = "";
    public List<string> Roles { get; set; } = [];
}