using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;

namespace AccEshop.Repositories;

public  interface IRepository<T, K>
{
    T Create(T t);
    T? Read(K id);
    List<T> Read();
    T? Update(K id, T t);
    bool Delete(K id);
}
