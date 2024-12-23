using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

public class EshopDbContext:DbContext
{
    public DbSet<Product> Products{ get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<Order> Orders{ get; set; }
    public DbSet<OrderProduct> OrderProducts{ get; set; }

    public EshopDbContext(DbContextOptions<EshopDbContext> options): base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Set up your connection string and other configuration here
        optionsBuilder.UseSqlServer("Server=localhost; " +
            "Initial Catalog = Accenture_EF; " +
            "User Id=sa;password=Passw0rd!@#;" +
            "TrustServerCertificate=true");
       


        // Enable sensitive data logging (only in development)
        optionsBuilder.EnableSensitiveDataLogging();

        // Additional configurations as needed
    }


}
