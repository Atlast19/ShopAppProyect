

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Categoria;
using ShopApp.Domain.Models.Categoria;

namespace ShopApp.Percistence.Repositories.Categoria
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IAbstraerCode _abstraerCode;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CategoriaRepository> _logger;
        private readonly string _connectionString;


        public CategoriaRepository(IConfiguration configuration,IAbstraerCode abstraerCode, ILogger<CategoriaRepository> logger)
        {
            _configuration = configuration;
            _abstraerCode = abstraerCode;
            _logger = logger;
            _connectionString = _configuration.GetConnectionString("StringConection");
        }

        public async Task<OperationResult<CategoriaCreateModel>> CreateCategoriaAsync(CategoriaCreateModel model)
        {

            OperationResult<CategoriaCreateModel> result = new OperationResult<CategoriaCreateModel>();

            try
            {
                // abstraer las respectivas validaciones
                _logger.LogInformation($"Creando una Categoria: {model.categoryname}");
               return await _abstraerCode.AbstractCodeModel(_connectionString, model);
            }
            catch (Exception ex) 
            {
                _logger.LogInformation($"Error creando la categoria: {model.categoryname}");
                result = OperationResult<CategoriaCreateModel>.Failure($"Error Creando la Categoria {ex.Message}");
            }
            return result;
        }

        public Task<OperationResult<CategoriaDeleteModel>> DeleteCategoriaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<CategoriaGetModel>> GetAllCategoriaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<CategoriaGetModel>> GetCategoriaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
