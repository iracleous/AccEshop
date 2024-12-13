using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;
using AccEshop.Models;

namespace AccEshop.Repositories;


public class Repository<T, K>: IRepository<T, K> 
    where T : IEntity<K> where K :class
{
    private List<T> _ts = [];
    public T Create(T t)
    {
        _ts.Add(t);
        return t;
    }

    public bool Delete(K id)
    {
        T? t = _ts.FirstOrDefault(t => t.Id.Equals( id));
        if (t == null) return false;
        _ts.Remove(t);
        return true;
    }

    public List<T> Read()
    {
        return _ts;
    }

    public T? Read(K id)
    {
        return _ts.FirstOrDefault(t => t.Id.Equals(id));
    }

    public T? Update(K id, T product)
    {
        T? t = _ts.FirstOrDefault(t => t.Id == id);
        if (t == null) return default;
        //update
        return t;
    }
 
}
