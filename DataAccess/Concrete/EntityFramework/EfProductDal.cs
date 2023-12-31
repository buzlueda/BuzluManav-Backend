using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;
public class EfProductDal : EfEntityRepositoryBase<Product, BuzluManavContext>, IProductDal
{
    public List<ProductDetailDto> GetProductDetails()
    {
        using (BuzluManavContext context = new BuzluManavContext())
        {
            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDetailDto
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName,
                             UnitPrice = p.UnitPrice
                         };
            return result.ToList();
        }
    }
}