namespace BHMS.Models;

public class MaintenanceRequest
{
    public int RequestId { get; set; }
    public int TenantId { get; set; }
    public int RoomId { get; set; }
    public DateTime RequestDate { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}
