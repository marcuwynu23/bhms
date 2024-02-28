using System.Diagnostics;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using BHMS.Database;
using BHMS.Models;      
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers.Auth;

public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("login")]
    [HttpGet("auth")]
    [HttpGet("auth/login")]
    public IActionResult Get()
    {
        return View("~/Views/Auth/Login/Index.cshtml");
    }

    [HttpPost("auth/login")]
    public IActionResult Post(LoginViewModel model)
    {
        var user = _context.Users.FirstOrDefault(u =>
            u.Username == model.Username && u.Password == model.Password
        );
        if (user != null)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                // Add other claims as needed
            };
            var claimsIdentity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );
            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity)
            );
            // set the user model in session convert to json
            HttpContext.Session.SetString("User", JsonSerializer.Serialize(user));

            return RedirectToAction("Index", "Dashboard");
        }
        return View("~/Views/Auth/Login/Index.cshtml");
    }

    [HttpGet("auth/logout")]
    public IActionResult Logout()
    {
        // Sign out the user
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        // Redirect to the login page or any other page after logout
        return RedirectToAction("Get", "Login"); // Redirect to home page after logout
    }
}
