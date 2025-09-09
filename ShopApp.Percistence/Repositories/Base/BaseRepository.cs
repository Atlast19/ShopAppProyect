using Microsoft.EntityFrameworkCore;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Base;


namespace ShopApp.Percistence.Repositories.Base
{
    public class BaseRepository<TEntity, TModel> : IBaseRepository<TEntity, TModel> where TModel : class
    {
        private readonly DbContext context;
        //DbSet<TModel> _DbSet;
        public BaseRepository(DbContext context)
        {
            this.context = context;
            //_DbSet = context.Set<TModel>();
        }

        public Task AddAsync(TModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, int delete_user)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<List<TModel>>> GetAllAsync()
        {
            var data = await context.Set<TModel>().ToListAsync();
            return new OperationResult<List<TModel>>(true,"Success",data);
        }

        public Task<TModel?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
