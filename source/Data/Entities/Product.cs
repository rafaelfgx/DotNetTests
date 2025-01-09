namespace Data;

public sealed record Product
{
    public string Description { get; set; }

    public int Id { get; set; }

    public string Name { get; set; }

    public float Price { get; set; }
}
