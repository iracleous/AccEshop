using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Models;

namespace AccEshop.Services;

public class OrderService
{
    private long _id;
    private Order? _order;

    /// <summary>
    /// no exceptions
    /// </summary>
    /// <param name="customer"></param>
    /// <param name="product"></param>
    /// <returns></returns>
    public Order CreateOrder(Customer customer, Product product)
    {
        _id++;
        _order = new Order()
        {
            Customer = customer,
            Products = [],
            Date = DateTime.Now,
            Id = _id
        };
        return _order;
    }

    public Order? GetOrder() {
        return _order;
    }

    public string GetOrderDetails()
    {
        return $"""
            order id {_order?.Id}
            customer name {_order?.Customer?.Name}
            product name {_order?.Products}
            price {_order?.Products}
            """;
    }
}
