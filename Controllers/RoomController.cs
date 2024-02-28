using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class RoomController : Controller
{
    private readonly ILogger<RoomController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public RoomController(ILogger<RoomController> logger)
    {
        _logger = logger;
    }

    private List<Room> GetRooms()
    {
        return new List<Room>
        {
            new Room
            {
                RoomId = 1,
                RoomNumber = "101",
                RoomType = "Standard",
                Description = "Standard room with basic amenities",
                Amenities = "WiFi, TV, AC",
                Price = 100.00m,
                Status = "Available"
            },
            new Room
            {
                RoomId = 2,
                RoomNumber = "102",
                RoomType = "Suite",
                Description = "Luxurious suite with premium amenities",
                Amenities = "WiFi, TV, AC, Mini-bar",
                Price = 200.00m,
                Status = "Booked"
            },
            // Add more rooms here
        };
    }

    public IActionResult Index()
    {
        var rooms = GetRooms();
        ViewBag.Rooms = rooms;
        return View();
    }
}
