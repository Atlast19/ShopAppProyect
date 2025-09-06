
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
        public Task<OperationResult<OrderModel>> CreateCategoriaAsync(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> DeleteCategoriaByIdAsync(int id, int delete_user)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<OrderModel>>> GetAllCategoriaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> GetCategoriaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<OrderModel>> UpdateCategoria(OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
