using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;
using AccEshop.Models;

namespace AccEshop.Mappers;

public class MapperUtility
{

    public Product GetModel(ProductRequest productRequest)
    {
        return new Product() {
            Name = productRequest.Name,
            Price = productRequest.Price,
            Description = productRequest.Description,
        };
    }

    public ProductResponse GetDto(Product product)
    {
        return new ProductResponse() {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            ProductionTimeStamp = product.ProductionTimeStamp
        };
    }
}
