using AccEshop.Dtos;
using AccEshop.Models;
using AccEshop.Repositories;
using AccEshop.Services;

// instance, reference, object, variable

var productRequest = new ProductRequest
{
    Description = "",
     Name = "Name",
      Price = 0.4m
};

var productRepository = new Repository<Product, string>();
var productService = new ProductService(productRepository);

ProductResponse productResponse =
    productService.Create(productRequest);

Console.WriteLine($"""
    product Id ={productResponse.Id}
    product name = {productResponse.Name}
    """);

//////////////////////////////////////////////////////
Customer customer = new Customer()
{
    Name = "Ioanna Lena",
    Fax = "seree"
};


var  customerRepository = new Repository<Customer, long>();
var customerService = new CustomerService(customerRepository);
Customer customerDb = customerService.Create(customer);

Console.WriteLine($"""
    customerDb Id ={customerDb.Id}
    customerDb name = {customerDb.Name}
    """);
