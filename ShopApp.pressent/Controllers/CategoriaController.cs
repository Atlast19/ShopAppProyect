using Microsoft.AspNetCore.Mvc;
using ShopApp.Application.Interface;
using ShopApp.Domain.Models.Categoria;

namespace ShopApp.pressent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        // GET: api/<CategoriaController>
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var result = await _categoriaService.GetAllCategoriaAsync();

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);

        }

        // GET api/<CategoriaController>/5
        [HttpGet("GetByID")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _categoriaService.GetCategoriaByIdAsync(id);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // POST api/<CategoriaController>
        [HttpPost("PostCategoria")]
        public async Task<IActionResult> Post([FromBody] CategoriaCreateModel CreationModel)
        {
            var result = await _categoriaService.CreateCategoriaAsync(CreationModel);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("PutCategoria")]
        public async Task<IActionResult> Put([FromBody] CategoriaUpdateModel UpdateModel)
        {
            var result = await _categoriaService.UpdateCategoria(UpdateModel);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("DeleteCategoria")]
        public async Task<IActionResult> Delete(int id, int delete_user)
        {
            var result = await _categoriaService.DeleteCategoriaByIdAsync(id,delete_user);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }
    }
}
