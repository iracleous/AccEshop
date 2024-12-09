﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();  
    public string Name { get; set; } = string.Empty;    
    public decimal Price { get; set; }  
    public string? Description { get; set; } 
    public DateTime ProductionTimeStamp { get; set; }  
}