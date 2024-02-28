using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers.Auth;

public class RegisterController : Controller
{
    private readonly AppDbContext _context;

    public RegisterController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("register")]
    [HttpGet("auth/register")]
    public IActionResult Index()
    {
        return View("~/Views/Auth/Register/Index.cshtml");
    }

    [HttpPost("auth/register")]
    public IActionResult Register(RegisterViewModel model)
    {
        Console.WriteLine("Registering user...");
        Console.WriteLine(model.FirstName);
        Console.WriteLine(model.LastName);
        Console.WriteLine(model.Email);
        Console.WriteLine(model.Username);
        Console.WriteLine(model.Password);
        Console.WriteLine(model.ConfirmPassword);

        // Check if the model is valid
        if (!ModelState.IsValid)
        {
            // If not valid, return the view with validation errors
            return View("~/Views/Auth/Register/Index.cshtml", model);
        }

        // Check if the password matches the confirmation password
        if (model.Password != model.ConfirmPassword)
        {
            ModelState.AddModelError(
                "Password",
                "The password and confirmation password do not match."
            );
            return View("~/Views/Auth/Register/Index.cshtml", model);
        }

        // Create a new user from the RegisterViewModel
        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Username = model.Username,
            Password = model.Password,
            // Set other properties as needed
        };

        // Add the new user to the database context and save changes
        // _context.Users.Add(user);
        // _context.SaveChanges();

        // Redirect to the login page after successful registration
        return RedirectToAction("Index", "Login");
    }
}
