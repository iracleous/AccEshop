using AccEshop.Dtos;
using AccEshop.Models;

namespace AccEshop.Mappers;

public interface IMapperProductUtility
{
    ProductResponse GetProductDto(Product product);
    Product GetProductModel(ProductRequest productRequest);
}