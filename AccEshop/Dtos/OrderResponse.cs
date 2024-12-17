using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Dtos;

public class OrderResponse
{
    public long Id { get; set; }
    public string? CustomerName { get; set; }
    public long CustomerId { get; set; }
    public DateTime OrderDate   { get; set; }
    public List<ProductResponse> Products { get; set; } = [];

}
