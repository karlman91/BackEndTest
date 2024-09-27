using Backend.Test.Model.Domain;
using Backend.Test.Services.Contracts;
using Backend.Test.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoriasService _categoriasService;
        public CategoriaController(ICategoriasService categoriasService) { 
            _categoriasService = categoriasService;
        }

        [HttpGet]
        public ActionResult<IList<ProductoDomain>> GetAll()
        {
            var result = _categoriasService.GetAll();
            if (result.Count() > 0)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }

        }

        [HttpGet("{id}")]
        public ActionResult<ProductoDomain> GetById(int id)
        {
            var result = _categoriasService.FindById(id);
            if (result != null)
            {
                return Ok(_categoriasService.FindById(id));
            }
            else
            {
                return NoContent();
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _categoriasService.Remove(id) == true ? Ok(true) : NoContent();
        }

        [HttpPost("{obj}")]
        public ActionResult<bool> Add([FromBody] CategoriaDomain obj)
        {
            return _categoriasService.Save(obj) == true ? Ok(true) : NoContent();
        }
    }
}
