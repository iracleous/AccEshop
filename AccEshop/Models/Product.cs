namespace AccEshop.Models;

public class Product:IEntity<string>
{
    public string Id { get; set; } = Guid.NewGuid().ToString();  
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; } 
    public string? Description { get; set; } 
    public ProductCategory Category { get; set; }
    public DateTime ProductionTimeStamp { get; set; }
    public List<OrderProduct> OrderProducts { get; set; } = [];
}