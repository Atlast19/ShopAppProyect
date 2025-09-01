

using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Customers;

namespace ShopApp.Application.Interface.Customers
{
    public interface ICustomerService
    {
        Task<OperationResult<CustomersCreateModel>> CreateCategoriaAsync(CustomersCreateModel model);
        Task<OperationResult<List<CustomersGetModel>>> GetAllCategoriaAsync();
        Task<OperationResult<CustomersGetModel>> GetCategoriaByIdAsync(int id);
        Task<OperationResult<CustomersDeleteModel>> DeleteCategoriaByIdAsync(int id, int delete_user);
        Task<OperationResult<CustomersUpdateModel>> UpdateCategoria(CustomersUpdateModel model);
    }
}
