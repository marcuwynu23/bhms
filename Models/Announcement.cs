namespace BHMS.Models;

public class Announcement
{
    public int AnnouncementId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
}
