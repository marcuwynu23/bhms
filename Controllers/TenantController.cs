using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class TenantController : Controller
{
    private readonly ILogger<TenantController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public TenantController(ILogger<TenantController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var tenants = new List<Tenant>
        {
            new Tenant
            {
                TenantId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@example.com",
                PhoneNumber = "123-456-7890",
                EmergencyContactName = "Jane Doe",
                EmergencyContactNumber = "987-654-3210",
                LeaseStartDate = DateTime.Now,
                LeaseEndDate = DateTime.Now.AddMonths(12),
                RentAmount = 1000,
                SecurityDeposit = 500,
                PaymentMethod = "Credit Card",
                Status = "Active"
            },
            new Tenant
            {
                TenantId = 2,
                FirstName = "Alice",
                LastName = "Smith",
                Email = "alice@example.com",
                PhoneNumber = "111-222-3333",
                EmergencyContactName = "Bob Smith",
                EmergencyContactNumber = "333-222-1111",
                LeaseStartDate = DateTime.Now.AddMonths(-1),
                LeaseEndDate = DateTime.Now.AddMonths(11),
                RentAmount = 1200,
                SecurityDeposit = 600,
                PaymentMethod = "Bank Transfer",
                Status = "Active"
            },
            // Add more sample data as needed
        };

        // Pass the list of tenants to the view using ViewBag
        ViewBag.Tenants = tenants;
        return View();
    }
}
