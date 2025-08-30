

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Categoria;
using ShopApp.Domain.Models.Categoria;

namespace ShopApp.Percistence.Repositories.Categoria
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<CategoriaRepository> _logger;
        private readonly string _connectionString;


        public CategoriaRepository(IConfiguration configuration, ILogger<CategoriaRepository> logger)
        {
            _configuration = configuration;
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


                using (var connection = new SqlConnection(_connectionString)) 
                {
                    using (var command = new SqlCommand("SP_AgregarCategoria", connection)) 
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@categoryname",model.categoryname);
                        command.Parameters.AddWithValue("@description", model.description);
                        command.Parameters.AddWithValue("@creation_user", model.creation_user);

                        SqlParameter v_result = new SqlParameter("@result", System.Data.SqlDbType.VarChar)
                        {
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Output

                        };

                        command.Parameters.Add(v_result);

                        await connection.OpenAsync();

                        var RowAffected = await command.ExecuteNonQueryAsync();
                        var resultMessage = v_result.Value.ToString();

                        if (RowAffected > 0)
                        {
                            _logger.LogInformation($"Categoria {model.categoryname} creada satisfactoriamente. Resultado:{resultMessage} ");
                            var CategoriaCreateModel = new CategoriaCreateModel
                            {
                                categoryname = model.categoryname,
                                description = model.description,
                                creation_user = model.creation_user
                            };
                            result = OperationResult<CategoriaCreateModel>.Succes("Categoria creada", CategoriaCreateModel);
                        }
                        else 
                        {
                            _logger.LogInformation($"No se ha podido crear la categoria {model.categoryname}. Resultado{resultMessage}");
                            result = OperationResult<CategoriaCreateModel>.Failure("no se ha podido crear la categoria");

                        }
                    }

                }
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
