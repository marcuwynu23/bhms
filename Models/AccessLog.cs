namespace BHMS.Models;

public class AccessLog
{
    public int LogId { get; set; }
    public int TenantId { get; set; }
    public int RoomId { get; set; }
    public DateTime AccessDate { get; set; }
    public TimeSpan AccessTime { get; set; }
    public string AccessType { get; set; }
}
