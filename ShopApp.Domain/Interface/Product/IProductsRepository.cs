using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Products;


namespace ShopApp.Domain.Interface.Product
{
    public interface IProductsRepository
    {
        Task<OperationResult<ProductsCreateModel>> CreateOrderDetailsAsync(ProductsCreateModel model);
        Task<OperationResult<List<ProductsGetModel>>> GetAllOrderDetailsAsync();
        Task<OperationResult<ProductsGetModel>> GetOrderDetailsByIdAsync(int id);
        Task<OperationResult<ProductsDeleteModel>> DeleteOrderDetailsByIdAsync(int id, int modify_user);
        Task<OperationResult<ProductsUpdateModel>> UpdateOrderDetails(ProductsUpdateModel model);
    }
}
