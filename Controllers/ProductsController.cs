using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[] {
new Product { Id = 1, Name = "BMW" },
new Product { Id = 2, Name = "Porshe" },
new Product { Id = 3, Name = "Audi" },
new Product { Id = 4, Name = "Volvo" },
new Product { Id = 5, Name = "Mersedes" }
};
            return Ok(products);
        }
    }
}
