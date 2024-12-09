using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

public class Order
{
    public long Id { get; set; }
    public Customer? Customer { get; set; } 
    public DateTime Date { get; set; }
    public Product? Product { get; set; }      
}
