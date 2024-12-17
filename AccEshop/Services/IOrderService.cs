using AccEshop.Dtos;
using AccEshop.Models;

namespace AccEshop.Services
{
    public interface IOrderService
    {
        //Order CreateOrder(Customer customer, Product product);
        //Order? GetOrder();
        //string GetOrderDetails();
       
        ///////////////////////////
        
        ResponseApi<OrderResponse> CreateOrder();
        ResponseApi<OrderResponse> GetOrder(long orderId);
        ResponseApi<OrderResponse> AssignCustomerToOrder
                (CustomerDto customer);

        ResponseApi<OrderResponse> AddProductToOrder
                (ProductResponse product);

        ResponseApi<OrderResponse> FinalizeOrder(long orderId);

    }
}