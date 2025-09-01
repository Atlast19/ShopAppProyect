
using ShopApp.Domain.Entity;
using ShopApp.Domain.Interface.Base;
using ShopApp.Domain.Models.Order.OrderBaseModel;

namespace ShopApp.Domain.Interface
{
    public interface IOrderRepository : IBaseRepository<Order,OrderModel>
    {
    }
}
