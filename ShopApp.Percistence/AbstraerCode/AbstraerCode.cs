

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Categoria;
using ShopApp.Domain.Models.Categoria;
using ShopApp.Percistence.Repositories.Categoria;

namespace ShopApp.Percistence.AbstraerCode
{
    internal class AbstraerCode : IAbstraerCode
    {
        private readonly ILogger<CategoriaRepository> _logger;

        public AbstraerCode(ILogger<CategoriaRepository> logger)
        {
            _logger = logger;

        }
        //public async Task<OperationResult<CategoriaCreateModel>> AbstractCodeModel(string conectionString,CategoriaCreateModel model)
        //{
        //    OperationResult<CategoriaCreateModel> result = new OperationResult<CategoriaCreateModel>();
        //    using (var connection = new SqlConnection(conectionString))
        //    {
        //        using (var command = new SqlCommand("SP_AgregarCategoria", connection))
        //        {
        //            command.CommandType = System.Data.CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@categoryname", model.categoryname);
        //            command.Parameters.AddWithValue("@description", model.description);
        //            command.Parameters.AddWithValue("@creation_user", model.creation_user);

        //            SqlParameter v_result = new SqlParameter("@result", System.Data.SqlDbType.VarChar)
        //            {
        //                Size = 100,
        //                Direction = System.Data.ParameterDirection.Output

        //            };

        //            command.Parameters.Add(v_result);

        //            await connection.OpenAsync();

        //            var RowAffected = await command.ExecuteNonQueryAsync();
        //            var resultMessage = v_result.Value.ToString();

        //            if (RowAffected > 0)
        //            {
        //                _logger.LogInformation($"Categoria {model.categoryname} creada satisfactoriamente. Resultado:{resultMessage} ");
        //                var CategoriaCreateModel = new CategoriaCreateModel
        //                {
        //                    categoryname = model.categoryname,
        //                    description = model.description,
        //                    creation_user = model.creation_user
        //                };
        //                result = OperationResult<CategoriaCreateModel>.Succes("Categoria creada", CategoriaCreateModel);
        //            }
        //            else
        //            {
        //                _logger.LogInformation($"No se ha podido crear la categoria {model.categoryname}. Resultado{resultMessage}");
        //                result = OperationResult<CategoriaCreateModel>.Failure("no se ha podido crear la categoria");

        //            }
        //            return result;
        //        }
        //    }
        //}
    }
}
