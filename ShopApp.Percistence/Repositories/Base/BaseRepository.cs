using Microsoft.EntityFrameworkCore;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Base;
using System.Linq.Expressions;

namespace ShopApp.Percistence.Repositories.Base
{
    public class BaseRepository<TEntity, TModel> : IBaseRepository<TEntity, TModel> where TEntity : class
    {
        private readonly DbContext context;
        DbSet<TEntity> _DbSet;
        public BaseRepository(DbContext context)
        {
            this.context = context;
            _DbSet = context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _DbSet.ToListAsync();
            await context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<TModel>> GetAllAsync()
        {
            var result = await _DbSet.ToListAsync();
            return new OperationResult<TModel>(true,"Datos Cargados correctamente",result);
        }

        public async Task<TModel?> GetByIdAsync(int id)
        {

            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
