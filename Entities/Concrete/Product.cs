using Core.Entities;

namespace Entities.Concrete;

public class Product : IEntity
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public double KGsInStock { get; set; }
    public double KGPrice { get; set; }
}
