using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface;
using ShopApp.Domain.Models.Order.OrderBaseModel;

namespace ShopApp.Percistence.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<OrderRepository> _logger;
        private readonly string _connectinoString;
        public OrderRepository(IConfiguration configuration, ILogger<OrderRepository> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _connectinoString = _configuration.GetConnectionString("StringConection");
       
        }
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
