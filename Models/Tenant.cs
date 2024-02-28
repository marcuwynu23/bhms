namespace BHMS.Models;

public class Tenant
{
    public int TenantId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string EmergencyContactName { get; set; }
    public string EmergencyContactNumber { get; set; }
    public DateTime LeaseStartDate { get; set; }
    public DateTime LeaseEndDate { get; set; }
    public decimal RentAmount { get; set; }
    public decimal SecurityDeposit { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
}
