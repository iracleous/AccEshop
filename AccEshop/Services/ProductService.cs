using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;
using AccEshop.Models;
using System.Xml.Linq;
using AccEshop.Repositories;
using AccEshop.Mappers;

namespace AccEshop.Services;

public class ProductService:IService<ProductRequest, ProductResponse, string>
{
    private readonly IRepository<Product, string> _productRepository;
    private MapperUtility _mapper = new();

    public ProductService(IRepository<Product, string> productRepository)
    {
        _productRepository = productRepository;
    }

    public ProductResponse Create(ProductRequest productRequest)
    {
        var product = _mapper.GetModel(productRequest);
        product.Id = Guid.NewGuid().ToString();
        product.ProductionTimeStamp = DateTime.Now;
        _productRepository.Create(product);
        return _mapper.GetDto(product);
    }

    public bool Delete(string id)
    {
        Product? product1 = _productRepository.Read(id);
        if (product1?.Description != null)
        {
            return false;
        }
        return _productRepository.Delete(id);
    }

    public List<ProductResponse> Read()
    {
        List<ProductResponse> productResponses = [];
        List<Product> products = _productRepository.Read();
        products.ForEach(product =>
        {
            productResponses.Add( _mapper.GetDto(product));
        }
        );
        return productResponses;
    }

    public ProductResponse? Read(string id)
    {
        Product? product = _productRepository.Read(id);
        if (product == null) return null;
        return _mapper.GetDto(product);
    }

    public ProductResponse? Update(string id, ProductRequest productRequest)
    {
        Product? product = _productRepository.Read(id);
        if (product == null) return null;

        product.Price = productRequest.Price;
        product.Name = productRequest.Name;
        product.Description = productRequest.Description;

        return _mapper.GetDto(product);
    }
}
