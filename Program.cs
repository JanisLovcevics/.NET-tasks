public class InventoryItem
{
    public Guid Id {get; set;} = new Guid();
    public string Name {get; set;} = string.Empty;
    public string Category {get; set;} = string.Empty;
    public int Quantity {get; set;}
    public decimal PriceEur {get; set;}
    public DateTime? ExpirationDate {get; set;}
}

public interface IInvetoryRepository
{
    Task<List<InventoryItem>> LoadAsync();
    Task<List<InventoryItem>> SaveAsync(List<InventoryItem> items);
}