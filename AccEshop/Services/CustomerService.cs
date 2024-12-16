using AccEshop.Dtos;
using AccEshop.Models;
using AccEshop.Repositories;

namespace AccEshop.Services;

/// <summary>
/// 
/// </summary>
public class CustomerService : IService<Customer, Customer, long>
{
    private readonly IRepository<Customer, long> _repository;

    public CustomerService(IRepository<Customer, long> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
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

    ResponseApi<Customer> IService<Customer, Customer, long>.Create(Customer t)
    {
        throw new NotImplementedException();
    }

    ResponseApi<bool> IService<Customer, Customer, long>.Delete(long id)
    {
        throw new NotImplementedException();
    }

    ResponseApi<Customer> IService<Customer, Customer, long>.Read(long id)
    {
        throw new NotImplementedException();
    }

    ResponseApi<List<Customer>> IService<Customer, Customer, long>.Read()
    {
        throw new NotImplementedException();
    }

    ResponseApi<Customer> IService<Customer, Customer, long>.Update(long id, Customer t)
    {
        throw new NotImplementedException();
    }
}
