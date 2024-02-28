using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class PaymentController : Controller
{
    private List<Payment> GetPayments()
    {
        return new List<Payment>
        {
            new Payment
            {
                PaymentId = 1,
                TenantId = 1,
                Amount = 1000.00m,
                PaymentDate = DateTime.Now.AddDays(-5),
                PaymentMethod = "Credit Card",
                Status = "Paid"
            },
            new Payment
            {
                PaymentId = 2,
                TenantId = 2,
                Amount = 1500.00m,
                PaymentDate = DateTime.Now.AddDays(-3),
                PaymentMethod = "Cash",
                Status = "Paid"
            },
            // Add more payments here
        };
    }

    public IActionResult Index()
    {
        var payments = GetPayments();
        ViewBag.Payments = payments;
        return View();
    }
}
