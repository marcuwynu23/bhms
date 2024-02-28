using System.Text.Json;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class AccountController : Controller
{
    // GET: AccountController
    public ActionResult Index()
    {
        var user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("User"));
        if (user == null)
        {           
            return RedirectToAction("Login", "Authentication");
        }
        ViewBag.User = user;
        return View();
    }
}
