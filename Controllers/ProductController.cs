using AdventureWork_CAAC.Data;
using AdventureWork_CAAC.Interface;
using AdventureWork_CAAC.Model;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWork_CAAC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductModelRepository _repository;
        public ProductController(IProductModelRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            var productModel = await _repository.GetProductModelAsync();
            return Ok(productModel);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

    }
}
