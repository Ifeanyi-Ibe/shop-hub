namespace ShopHub.Domain.Entities;

public record Sku
{
    private const int DefaultLength = 8;
    
    private Sku(string value) => Value = value;

    public string Value { get; set; }

    public static Sku? Create(string value)
    {
        if(string.IsNullOrEmpty(value))
        {
            return null;
        }

        if(value.Length != DefaultLength)
        {
            return null;
        }

        return new Sku(value);
    }
}