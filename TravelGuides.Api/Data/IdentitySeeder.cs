using Microsoft.AspNetCore.Identity;
using TravelGuides.Api.Models;

namespace TravelGuides.Api.Data;

public static class IdentitySeeder
{
    public static async Task SeedAsync(IServiceProvider services)
    {
        var roleManager =
            services.GetRequiredService<RoleManager<IdentityRole>>();

        var userManager =
            services.GetRequiredService<UserManager<ApplicationUser>>();

        foreach (var role in new[] { "Admin", "User" })
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                var result = await roleManager.CreateAsync(
                    new IdentityRole(role));

                CheckResult(result);
            }
        }

        await CreateUserAsync(
            userManager,
            "admin@example.com",
            "DemoAdmin123!",
            "Admin");

        await CreateUserAsync(
            userManager,
            "user@example.com",
            "DemoUser123!",
            "User");
    }

    private static async Task CreateUserAsync(
        UserManager<ApplicationUser> userManager,
        string email,
        string password,
        string role)
    {
        var user = await userManager.FindByEmailAsync(email);

        if (user is null)
        {
            user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };

            var creationResult =
                await userManager.CreateAsync(user, password);

            CheckResult(creationResult);
        }

        if (!await userManager.IsInRoleAsync(user, role))
        {
            var roleResult =
                await userManager.AddToRoleAsync(user, role);

            CheckResult(roleResult);
        }
    }

    private static void CheckResult(IdentityResult result)
    {
        if (!result.Succeeded)
        {
            var errors = string.Join(
                "; ",
                result.Errors.Select(error => error.Description));

            throw new InvalidOperationException(errors);
        }
    }
}