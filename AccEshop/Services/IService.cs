using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;

namespace AccEshop.Services;
 

public interface IService<Trequest, Tresponse, K>
{
    ResponseApi<Tresponse> Create(Trequest t);
    ResponseApi<Tresponse> Read(K id);
    ResponseApi<List<Tresponse>> Read();
    ResponseApi<Tresponse> Update(K id, Trequest t);
    ResponseApi<bool> Delete(K id);
}
