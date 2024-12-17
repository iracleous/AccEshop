using AccEshop.Dtos;
using AccEshop.Models;
using AccEshop.Repositories;

namespace AccEshop.Services;

public class OrderService : IOrderService
{
     

    private readonly IRepository<Order, long> _orderRepository;
   // private readonly IMapperOrder _orderMapper;

    public OrderService(IRepository<Order, long> orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public ResponseApi<OrderResponse> AddProductToOrder(ProductResponse product)
    {
        throw new NotImplementedException();
    }

    public ResponseApi<OrderResponse> AssignCustomerToOrder(CustomerDto customer)
    {
        throw new NotImplementedException();
    }

     

    public ResponseApi<OrderResponse> CreateOrder()
    {
        Order order = _orderRepository.Create(new Order());
        return new ResponseApi<OrderResponse>()
        {
            Value = new OrderResponse()
            {
                Id = order.Id, 
                OrderDate =   DateTime.Now,
            }
        };
    }

    public ResponseApi<OrderResponse> FinalizeOrder(long orderId)
    {
        throw new NotImplementedException();
    }

   
    public ResponseApi<OrderResponse> GetOrder(long orderId)
    {
        throw new NotImplementedException();
    }

     
}
