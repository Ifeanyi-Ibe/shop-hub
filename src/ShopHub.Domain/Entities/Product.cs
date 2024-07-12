namespace ShopHub.Domain.Entities;

public class Product 
{
    public BaseId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public Money Price { get; private set; } 
    public Sku Sku { get; private set; }
}