namespace BHMS.Models;

public class User
{
    public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string EmergencyContactName { get; set; }
		public string EmergencyContactNumber { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string Status { get; set; }
}
