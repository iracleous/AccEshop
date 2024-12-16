using System.Diagnostics;
using AccEshop.AsyncDemo;
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

ResponseApi<ProductResponse> productResponse =
    productService.Create(productRequest);

Console.WriteLine($"""
    product Id ={productResponse.Value?.Id}
    product name = {productResponse.Value?.Name}
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


//////////////////////////////////////////////////////
///
IOrder order = new AccEshop.AsyncDemo.Order();

Stopwatch sw = new Stopwatch();
sw.Start();
Task task1 = order.InspectAsync(null);
Task task2 = order.InspectAsync(null);
Task task3 = order.InspectAsync(null);
Task task4 = order.InspectAsync(null);

await Task.WhenAll(task1, task2, task3, task4);

sw.Stop();
Console.WriteLine($"Time Taken-->{sw.ElapsedMilliseconds}");

