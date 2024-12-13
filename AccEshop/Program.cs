using AccEshop.Dtos;
using AccEshop.Models;
using AccEshop.Repositories;
using AccEshop.Services;

// instance, reference, object, variable
 

var productRequest = new ProductRequest
{
    
};

var productRepository = new Repository<Product, string>();
var productService = new ProductService(productRepository);

ProductResponse productResponse =
    productService.Create(productRequest);

Console.WriteLine(productResponse.Id);