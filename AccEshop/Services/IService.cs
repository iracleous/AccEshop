using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Services;
 

public interface IService<Trequest, Tresponse, K>
{
    Tresponse Create(Trequest t);
    Tresponse? Read(K id);
    List<Tresponse> Read();
    Tresponse? Update(K id, Trequest t);
    bool Delete(K id);
}
