using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Models;

namespace AccEshop.AsyncDemo;

public class Order : IOrder
{
    public async Task<decimal> BuyAsync(Product product)
    {
        //simulates a network delay
        await Task.Delay(1000);
        return 0.0m;
    }

    public async Task<List<Product>> DeliverAsync(Models.Order order)
    {
        //simulates a network delay
        await Task.Delay(1000);
        return new List<Product>();
    }

    public async Task InspectAsync(Product product)
    {
        //simulates a network delay
       await   Task.Delay(1000);

    }
}
