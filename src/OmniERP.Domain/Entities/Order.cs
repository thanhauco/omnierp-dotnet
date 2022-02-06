namespace OmniERP.Domain.Entities;

public class Order {
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalAmount { get; set; }
}
