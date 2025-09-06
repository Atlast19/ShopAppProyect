using Microsoft.AspNetCore.Mvc;
using ShopApp.Application.Interface.Shippers;
using ShopApp.Domain.Models.Shippers;

namespace ShopApp.pressent.Controllers.ShippersController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippersController : ControllerBase
    {
        private readonly IShippersService _shippersService;

        public ShippersController(IShippersService shippersService)
        {
            _shippersService = shippersService;
        }
        // GET: api/<ShippersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _shippersService.GetAllShippersAsync();

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // GET api/<ShippersController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _shippersService.GetShippersByIdAsync(id);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // POST api/<ShippersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShippersCreateModel model)
        {
            var result = await _shippersService.CreateShippersAsync(model);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // PUT api/<ShippersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] ShippersUpdateModel model)
        {
            var result = await _shippersService.UpdateShippers(model);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }

        // DELETE api/<ShippersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id,int delete_user)
        {
            var result = await _shippersService.DeleteShippersByIdAsync(id, delete_user);

            if (!result.IsSucces)
                return BadRequest(result);


            return Ok(result);
        }
    }
}
