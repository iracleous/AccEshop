using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

public class Customer
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty; 
    public string PostalCode { get; set; } = string.Empty; 
    public string Country { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;   
    public string Fax { get; set; } = string.Empty;
    public string FaxNumber { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string FaxCode { get; set;} = string.Empty;  
 }
