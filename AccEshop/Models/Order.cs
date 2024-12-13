using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

public class Order : IEntity<long>
{
    public long Id { get; set; }
    public Customer? Customer { get; set; } 
    public DateTime Date { get; set; }
    public List<Product> Products { get; set; } = [];  
}
