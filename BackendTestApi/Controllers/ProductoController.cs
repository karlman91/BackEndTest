using Backend.Test.Model.Domain;
using Backend.Test.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IProductoService _productoService;
        public ProductoController(IProductoService productoService) {
            _productoService = productoService;
        }

        [HttpGet]
        public ActionResult<IList<ProductoDomain>> GetAll()
        {
            var result = _productoService.GetAll();
            if (result.Count() > 0)
            {
                return Ok(result);
            }
            else
            { 
                return NoContent();
            }
            
        }

        [HttpGet]
        public ActionResult<ProductoDomain> GetById([FromQuery] int id)
        {
            var result = _productoService.FindById(id);
            if (result != null)
            {
                return Ok(_productoService.FindById(id));
            }
            else {
                return NoContent();
            }

        }

        [HttpDelete]
        public ActionResult<bool> Delete([FromBody] int id) {
            return _productoService.Remove(id) == true ? Ok(true) : NoContent();
        }


        [HttpPost]
        public ActionResult<bool> Add([FromBody] ProductoDomain obj) {
            return _productoService.Save(obj) == true ? Ok(true) : NoContent();
        }
    }
}
