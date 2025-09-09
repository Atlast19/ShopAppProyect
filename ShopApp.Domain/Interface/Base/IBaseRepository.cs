using ShopApp.Domain.Base;

namespace ShopApp.Domain.Interface.Base
{
    public interface IBaseRepository<TEntity, TModel> where TModel : class
    {
        Task<OperationResult<List<TModel>>> GetAllAsync();
        Task<TModel?> GetByIdAsync(int id);
        Task AddAsync(TModel entity);
        Task UpdateAsync(TModel entity);
        Task DeleteAsync(int id, int delete_user);
    }
}
