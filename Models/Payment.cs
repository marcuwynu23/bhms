namespace BHMS.Models;

public class Payment
{
    public int PaymentId { get; set; }
    public int TenantId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
}
