using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccEshop.Dtos;
using AccEshop.Models;

namespace AccEshop.Repositories;

public interface IProductRepository
{
    ProductResponse CreateProduct(ProductRequest product);
    ProductResponse ReadProduct(string id);
    List<ProductResponse> Read();
    ProductResponse Update(string productId, ProductRequest product);
    bool Delete(string id);
}
