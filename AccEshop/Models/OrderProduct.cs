using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models
{
    public class OrderProduct
    {
        public long Id { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitDiscount { get; set; }
        public decimal VatRate { get; set; }
        public decimal TotalPrice => (UnitPrice-UnitDiscount)*Quantity*(1+VatRate);
    }
}
