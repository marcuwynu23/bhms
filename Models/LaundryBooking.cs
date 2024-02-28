namespace BHMS.Models;

public class LaundryBooking
{
    public int BookingId { get; set; }
    public int TenantId { get; set; }
    public DateTime Date { get; set; }
    public string TimeSlot { get; set; }
    public string Status { get; set; }
}
