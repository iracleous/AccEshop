﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Dtos;

public class ResponseApi<T>
{
    public T? Value { get; set; }
    public int StatusCode { get; set; } 
    public string? Description { get; set; }
 }
