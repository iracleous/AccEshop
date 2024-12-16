using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Models;

namespace AccEshop.AsyncDemo;

public interface  IOrder
{

    Task InspectAsync(Product product);
    Task<decimal> BuyAsync(Product product);
    Task<List<Product>> DeliverAsync(AccEshop.Models.Order order);

}
