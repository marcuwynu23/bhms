namespace BHMS.Models;

public class Room
{
    public int RoomId { get; set; }
    public string RoomNumber { get; set; }
    public string RoomType { get; set; }
    public string Description { get; set; }
    public string Amenities { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
}
