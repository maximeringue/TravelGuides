using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelGuides.Api.Services;
using TravelGuides.Api.ViewModels;

namespace TravelGuides.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<ActionResult<LoginResponseViewModel>> Login(
        LoginViewModel model)
    {
        var response = await _authService.LoginAsync(model);

        if (response is null)
        {
            return Unauthorized(new
            {
                message = "Email ou mot de passe incorrect."
            });
        }

        return Ok(response);
    }

    [Authorize]
    [HttpGet("me")]
    public IActionResult Me()
    {
        return Ok(new
        {
            id = User.FindFirstValue(ClaimTypes.NameIdentifier),
            email = User.FindFirstValue(ClaimTypes.Email),
            roles = User.FindAll(ClaimTypes.Role)
                .Select(claim => claim.Value)
                .ToList()
        });
    }
}