namespace BHMS.Models;

public class RoomBooking
{
    public int BookingId { get; set; }
    public int TenantId { get; set; }
    public int RoomId { get; set; }
    public DateTime BookingDate { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string Status { get; set; }
}
