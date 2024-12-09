using System.Reflection.Metadata.Ecma335;
using AccEshop.Models;

var product = new Product()
{
 Name = "chips",
 Price = 1.20m,
 ProductionTimeStamp = DateTime.Now,
 Description = "Fresh snack"
};
 
Console.WriteLine(
    $"""
        the product id is {product.Id} 
        the product name is {product.Name} 
        the product name is {product.Price}
    """);

// instance, reference, object, variable

Customer customer = new()
{
     Id = 1,
      Address = "Sliman 3",
       City = "Athens",
        Country ="Greece",
        Name = null,
};

Order order = new()
{
    Id = 2,
    Customer = customer,
     Product = product,
};

Console.WriteLine($"""
    Name of the customer in the current order is 
    {order?.Customer?.Name?.Length}
    price is {order?.Product.Price}
  """);

 //{order.Customer!=null?order.Customer.Name: null}
