using AccEshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Repositories;

public class DbCustomerRepository : IRepository<Customer, long>
{

    private EshopDbContext _dbContext;

    public DbCustomerRepository(EshopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Customer Create(Customer t)
    {
        _dbContext.Customers.Add(t);
        _dbContext.SaveChanges();
        return t;
    }

    public bool Delete(long id)
    {
        Customer? customer = Read(id);
        if (customer == null)
        {
            return false;
        }
        _dbContext.Customers.Remove(customer);
        _dbContext.SaveChanges(true);
        return true;
    }

    public Customer? Read(long id)
    {
       return _dbContext.Customers.FirstOrDefault(x => x.Id == id);
    }

    public List<Customer> Read()
    {
        return [.. _dbContext.Customers];
    }

    public Customer? Update(long id, Customer t)
    {
        Customer? customer = Read(id);
        if (customer == null)
        {
            return customer;
        }
        customer.Phone = t.Phone;
        _dbContext.SaveChanges(true);
        return customer;
    }
}
