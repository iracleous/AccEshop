using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;
using AccEshop.Models;

namespace AccEshop.Repositories;

public class ProductRepository : IProductRepository
{
    private List<Product> products = [];
    public ProductResponse CreateProduct(ProductRequest product)
    {
        var productInList  = new Product ()
        {
            Id = Guid.NewGuid().ToString(),
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            ProductionTimeStamp = DateTime.Now,
        };
        products.Add (productInList);
        return new ProductResponse()
        {
            Id = productInList.Id,
            Name = productInList.Name,
            Price = productInList.Price,
            Description = productInList.Description,
            ProductionTimeStamp = productInList.ProductionTimeStamp
        };

    }

    public bool Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<ProductResponse> Read()
    {
        throw new NotImplementedException();
    }

    public ProductResponse ReadProduct(string id)
    {
        throw new NotImplementedException();
    }

    public ProductResponse Update(string productId, ProductRequest product)
    {
        throw new NotImplementedException();
    }
}
