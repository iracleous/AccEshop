using System.Reflection.Metadata.Ecma335;
using AccEshop.Models;
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
        Country ="Greece",
        Name = "George",
};

OrderService orderService = new();

Order order = orderService.CreateOrder(customer, product);
string message = orderService.GetOrderDetails();
Console.WriteLine(message);