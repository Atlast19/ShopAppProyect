using ShopApp.Application.Interface.Order;
using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Order.OrderBaseModel;

namespace ShopApp.Application.Service.OrderService
{
    public class OrderService : IOrderService
    {
        public Task<OperationResult<OrderModel>> CreateOrderAsync(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> DeleteOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<OrderModel>>> GetAllOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> GetOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> UpdateOrder(OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
