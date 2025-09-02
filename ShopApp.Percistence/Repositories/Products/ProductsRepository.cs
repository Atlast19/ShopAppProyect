using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Product;
using ShopApp.Domain.Models.Products;

namespace ShopApp.Percistence.Repositories.Products
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ProductsRepository> _logger;
        private readonly string _connectionString;
        public ProductsRepository(IConfiguration configuration, ILogger<ProductsRepository> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _connectionString = _configuration.GetConnectionString("StringConection");
        }
        public async Task<OperationResult<ProductsCreateModel>> CreateOrderDetailsAsync(ProductsCreateModel model)
        {
            OperationResult<ProductsCreateModel> result = new OperationResult<ProductsCreateModel>();

            try
            {
                _logger.LogInformation($"Creando un producto");

                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("SP_AgregarProducts", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@productname", model.productname);
                        command.Parameters.AddWithValue("@supplierid", model.supplierid);
                        command.Parameters.AddWithValue("@categoryid", model.categoryid);
                        command.Parameters.AddWithValue("@unitprice", model.unitprice);
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
                            _logger.LogInformation($"Producto agregado satisfactoriamente: {resultMessage} ");
                            var ProductsCreateModel = new ProductsCreateModel
                            {
                                productname = model.productname,
                                supplierid = model.supplierid,
                                categoryid = model.categoryid,
                                unitprice = model.unitprice,
                                creation_user = model.creation_user,
                            };
                            result = OperationResult<ProductsCreateModel>.Succes("Producto creado correctamente", ProductsCreateModel);
                        }
                        else
                        {
                            _logger.LogInformation($"No se ha podido crear el producto: {resultMessage}");
                            result = OperationResult<ProductsCreateModel>.Failure("no se ha podido crear el producto");

                        }
                        return result;
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error creando el producto");
                result = OperationResult<ProductsCreateModel>.Failure($"Error Creando el producto {ex.Message}");
            }
            return result;
        }

        public async Task<OperationResult<ProductsDeleteModel>> DeleteOrderDetailsByIdAsync(int id, int delete_user)
        {
            OperationResult<ProductsDeleteModel> result = new OperationResult<ProductsDeleteModel>();

            try
            {
                _logger.LogInformation("Procesando desactivacion del producto");

                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("SP_EliminarProducts", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@productid", id);
                        command.Parameters.AddWithValue("@delete_user", delete_user);



                        SqlParameter v_result = new SqlParameter("@result", System.Data.SqlDbType.VarChar)
                        {
                            Size = 1000,
                            Direction = System.Data.ParameterDirection.Output
                        };
                        command.Parameters.Add(v_result);

                        await connection.OpenAsync();


                        var rowsAffected = await command.ExecuteNonQueryAsync();
                        var resultMessage = v_result.Value.ToString();


                        if (rowsAffected > 0)
                        {

                            _logger.LogInformation($"Producto desactivado con exito");

                            var ProductsDelete = new ProductsDeleteModel
                            {
                                categoryid = id,
                                delete_user = delete_user
                            };

                            result = OperationResult<ProductsDeleteModel>.Succes("Producto desactivado correctamente", ProductsDelete);
                        }
                        else
                        {

                            _logger.LogWarning($"Error al desactivar el producto");
                            result = OperationResult<ProductsDeleteModel>.Failure("Error al desactivar el producto");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Error al desactivar el producto");
                result = OperationResult<ProductsDeleteModel>.Failure($"Erro {ex.Message}");
            }
            return result;
        }

        public Task<OperationResult<List<ProductsGetModel>>> GetAllOrderDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<ProductsGetModel>> GetOrderDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<ProductsUpdateModel>> UpdateOrderDetails(ProductsUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
