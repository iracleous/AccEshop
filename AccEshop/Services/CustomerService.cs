using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Models;
using AccEshop.Repositories;

namespace AccEshop.Services;

public class CustomerService : IService<Customer, Customer, long>
{
    private readonly IRepository<Customer, long> _repository;

    public CustomerService(IRepository<Customer, long> repository)
    {
        _repository = repository;
    }

    public Customer Create(Customer t)
    {
        return _repository.Create(t);
    }

    public bool Delete(long id)
    {
        return _repository.Delete(id);
    }

    public Customer? Read(long id)
    {
       return  _repository.Read(id);
    }

    public List<Customer> Read()
    {
        return _repository.Read();
    }

    public Customer? Update(long id, Customer t)
    {
        return _repository.Update(id, t);
    }
}
