using System.ComponentModel.DataAnnotations;

namespace TravelGuides.Api.ViewModels;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public string Password { get; set; } = "";
}