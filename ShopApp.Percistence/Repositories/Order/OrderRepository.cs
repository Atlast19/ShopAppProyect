
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Entity;
using ShopApp.Domain.Interface;
using ShopApp.Domain.Models.Order.OrderBaseModel;

namespace ShopApp.Percistence.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        public Task<OperationResult<OrderModel>> CreateOrderAsync(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> DeleteOrderByIdAsync(int id, int delete_user)
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
