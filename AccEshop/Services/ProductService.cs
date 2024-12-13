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
using AccEshop.Validators;
using System.Linq.Expressions;

namespace AccEshop.Services;

public class ProductService:IService<ProductRequest, ProductResponse, string>
{
    private readonly IRepository<Product, string> _productRepository;
    private MapperUtility _mapper = new();

    public ProductService(IRepository<Product, string> productRepository)
    {
        _productRepository = productRepository;
    }

    public ResponseApi<ProductResponse> Create(ProductRequest productRequest)
    {
        var product = _mapper.GetModel(productRequest);

        if (ProductValidator.IsProductEmpty(product))
        {
            return new ResponseApi<ProductResponse>
            {
                StatusCode = 13,
                 Description = "given product is null"
            };

        }

        product.Id = Guid.NewGuid().ToString();
        product.ProductionTimeStamp = DateTime.Now;
        _productRepository.Create(product);
        return
            new ResponseApi<ProductResponse>
            {
                 Value = _mapper.GetDto(product)
            };
       
    }

    public ResponseApi<bool> Delete(string id)
    {
        Product? product1 = _productRepository.Read(id);
        if (product1?.Description != null)
        {
            return new ResponseApi<bool>
            {
                StatusCode = 14,
                Description = "product not found",
                Value = false
            };
        }
        bool result = _productRepository.Delete(id);
        return new ResponseApi<bool>
        {
            Value = result
        };
    }

    public ResponseApi<List<ProductResponse>> Read()
    {
        List<ProductResponse> productResponses = [];
        List<Product> products = _productRepository.Read();
        products.ForEach(product =>
        {
            productResponses.Add( _mapper.GetDto(product));
        }
        );

        return
            new ResponseApi<List<ProductResponse>>
            {
                Value = productResponses
            };
    }

    public ResponseApi<ProductResponse> Read(string id)
    {
        Product? product = _productRepository.Read(id);
        if (product == null)
            return new ResponseApi<ProductResponse>
            {
                StatusCode = 17,
                Description = " product not found"
            };


        ProductResponse productResponse = _mapper.GetDto(product);
        return
           new ResponseApi<ProductResponse>
           {
               Value = productResponse
           };

    }

    public ResponseApi<ProductResponse> Update(string id, ProductRequest productRequest)
    {
        Product? product = _productRepository.Read(id);
        if (product == null)
            return new ResponseApi<ProductResponse>
            {
                StatusCode = 17,
                Description = " product not found"
            };

        product.Price = productRequest.Price;
        product.Name = productRequest.Name;
        product.Description = productRequest.Description;

        ProductResponse productResponse = _mapper.GetDto(product);
        return
           new ResponseApi<ProductResponse>
           {
               Value = productResponse
           };
    }
}
