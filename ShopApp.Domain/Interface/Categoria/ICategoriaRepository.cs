using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Categoria;

namespace ShopApp.Domain.Interface.Categoria
{
    public interface ICategoriaRepository
    {
        Task<OperationResult<CategoriaCreateModel>> CreateCategoriaAsync(CategoriaCreateModel model);
        Task<OperationResult<CategoriaGetModel>> GetAllCategoriaAsync();
        Task<OperationResult<CategoriaGetModel>> GetCategoriaByIdAsync(int id);
        Task<OperationResult<CategoriaDeleteModel>> DeleteCategoriaByIdAsync(int id);
    }
}
