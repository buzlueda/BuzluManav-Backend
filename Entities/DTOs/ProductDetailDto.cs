using Core.Entities;

namespace Entities.DTOs;

public class ProductDetailDto : IDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string? CategoryName { get; set; }
    public double KGsInStock { get; set; }
}