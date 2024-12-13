using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Models;

namespace AccEshop.Validators;

public static class ProductValidator
{
    public static bool IsProductEmpty(Product product)
    {
        return product == null;
    } 
}
