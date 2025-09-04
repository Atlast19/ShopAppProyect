using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Suppliers;

namespace ShopApp.Domain.Interface.Suppliers
{
    public interface ISuppliersRepository
    {
        Task<OperationResult<SuppliersCreateModel>> CreateShippersAsync(SuppliersCreateModel model);
        Task<OperationResult<List<SuppliersGetModel>>> GetAllShippersAsync();
        Task<OperationResult<SuppliersGetModel>> GetShippersByIdAsync(int id);
        Task<OperationResult<SuppliersDeleteModel>> DeleteShippersByIdAsync(int id, int modify_user);
        Task<OperationResult<SuppliersUpdateModel>> UpdateShippers(SuppliersUpdateModel model);
    }
}
