
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Entity;
using ShopApp.Domain.Interface;
using ShopApp.Domain.Models.Order.OrderBaseModel;
using System.Linq.Expressions;

namespace ShopApp.Percistence.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDbAppContext _context;
        private readonly ILogger<OrderRepository> _logger;

        public OrderRepository(ShopDbAppContext context, ILogger<OrderRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task AddAsync(Domain.Entity.Order entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(Expression<Func<Domain.Entity.Order, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<OrderModel>> GetAllAsync()
        {
            _logger.LogInformation("Cargando todas las ordenes");
            var order = await _context.Orders.ToListAsync();
            if (order is null)
            {
                return OperationResult<OrderModel>.Failure("No se encuentran datos en la tabla");
            }
            else
            {
            return OperationResult<OrderModel>.Succes("Datos cargados",order);
            }
        }

        public async Task<OrderModel?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Domain.Entity.Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
