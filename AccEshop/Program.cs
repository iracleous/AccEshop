using AccEshop.Dtos;
using AccEshop.Models;
using AccEshop.Repositories;
using AccEshop.Services;

// instance, reference, object, variable

var product = new Product()
{
    Name = "chips",
    Price = 1.20m,
    ProductionTimeStamp = DateTime.Now,
    Description = "Fresh snack"
};

Customer customer = new()
{
    Id = 1,
    Address = "Sliman 3",
    City = "Athens",
    Country = "Greece",
    Name = "George",
};

OrderService orderService = new();

Order order = orderService.CreateOrder(customer, product);
string message = orderService.GetOrderDetails();
Console.WriteLine(message);


var productRequest = new ProductRequest
{
    Name = "cafes",
    Description = "beverage",
    Price = 1.2m
};

ProductRepository productRepository = new ProductRepository();
ProductResponse productResponse = 
    productRepository.CreateProduct(productRequest);

Console.WriteLine(productResponse.Id);