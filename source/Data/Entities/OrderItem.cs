namespace Data;

public sealed record OrderItem
{
    public int Id { get; set; }

    public Order Order { get; set; }

    public Product Product { get; set; }

    public int Quantity { get; set; }
}
