namespace Data;

public sealed record Order
{
    public Customer Customer { get; set; }

    public DateTime Date { get; set; }

    public int Id { get; set; }

    public IList<OrderItem> Items { get; set; }
}
