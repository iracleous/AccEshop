using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

public class Product
{ 
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    public string ProductId { get; set; } = Guid.NewGuid().ToString();
    public DateTime ProductionTimeStamp { get; set; }
}
