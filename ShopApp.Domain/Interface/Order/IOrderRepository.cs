using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Order.OrderBaseModel;

namespace ShopApp.Domain.Interface
{
    public interface IOrderRepository 
    {
        Task<OperationResult<OrderModel>> CreateCategoriaAsync(OrderModel model);
        Task<OperationResult<List<OrderModel>>> GetAllCategoriaAsync();
        Task<OperationResult<OrderModel>> GetCategoriaByIdAsync(int id);
        Task<OperationResult<OrderModel>> DeleteCategoriaByIdAsync(int id, int delete_user);
        Task<OperationResult<OrderModel>> UpdateCategoria(OrderModel model);
    }
}
