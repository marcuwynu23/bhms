using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class MaintenanceController : Controller
{
    private List<MaintenanceRequest> GetMaintenanceRequests()
    {
        return new List<MaintenanceRequest>
        {
            new MaintenanceRequest
            {
                RequestId = 1,
                TenantId = 1,
                RoomId = 101,
                RequestDate = DateTime.Now,
                Description = "Broken faucet in the bathroom",
                Status = "Pending"
            },
            new MaintenanceRequest
            {
                RequestId = 2,
                TenantId = 2,
                RoomId = 102,
                RequestDate = DateTime.Now.AddDays(-1),
                Description = "Light bulb needs replacement",
                Status = "In Progress"
            },
            // Add more maintenance requests here
        };
    }

    public IActionResult Index()
    {
        var maintenanceRequests = GetMaintenanceRequests();
        ViewBag.MaintenanceRequests = maintenanceRequests;
        return View();
    }
}
