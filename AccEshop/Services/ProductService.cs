using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;
using AccEshop.Models;
using System.Xml.Linq;
using AccEshop.Repositories;

namespace AccEshop.Services;

public class ProductService
{
    private readonly IRepository<Product, string> productRepository;

    public ProductService(IRepository<Product, string> productRepository)
    {
        this.productRepository = productRepository;
    }

    public ProductResponse Create(ProductRequest product)
    {
        var productInList = new Product()
        {
            Id = Guid.NewGuid().ToString(),
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            ProductionTimeStamp = DateTime.Now,
        };
        productRepository.Create(productInList);
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
       
        return productRepository.Delete(id);
    }

    public List<ProductResponse> Read()
    {
        List<ProductResponse> productResponses = [];
        List<Product> products = productRepository.Read();
        products.ForEach(prodx =>
        {
            productResponses.Add(new ProductResponse
            {
                Id = prodx.Id,
                Name = prodx.Name,
                Description = prodx.Description,
                Price = prodx.Price,
                ProductionTimeStamp = prodx.ProductionTimeStamp,
            }
            );
        }
        );
        return productResponses;
    }

    public ProductResponse? Read(string id)
    {
        Product? prodx = productRepository.Read(id);
        if (prodx == null) return null;
        return new ProductResponse
        {
            Id = prodx.Id,
            Name = prodx.Name,
            Description = prodx.Description,
            Price = prodx.Price,
            ProductionTimeStamp = prodx.ProductionTimeStamp,
        };
    }

    public ProductResponse? Update(string id, ProductRequest product)
    {
        Product? prodx = productRepository.Read(id);
        if (prodx == null) return null;

        prodx.Price = product.Price;
        prodx.Name = product.Name;
        prodx.Description = product.Description;

        return new ProductResponse
        {
            Id = prodx.Id,
            Name = prodx.Name,
            Description = prodx.Description,
            Price = prodx.Price,
            ProductionTimeStamp = prodx.ProductionTimeStamp,
        };
    }
}
