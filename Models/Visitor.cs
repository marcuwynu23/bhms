namespace BHMS.Models;

public class Visitor
{
    public int VisitorId { get; set; }
    public int TenantId { get; set; }
    public string VisitorName { get; set; }
    public string VisitorContact { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
}
