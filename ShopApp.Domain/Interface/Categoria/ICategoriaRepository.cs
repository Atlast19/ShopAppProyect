using ShopApp.Domain.Base;
using ShopApp.Domain.Models.Categoria;

namespace ShopApp.Domain.Interface.Categoria
{
    public interface ICategoriaRepository
    {
        Task<OperationResult<CategoriaCreateModel>> CreateCategoriaAsync(CategoriaCreateModel model);
    }
}
