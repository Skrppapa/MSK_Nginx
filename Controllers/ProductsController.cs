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
new Product { Id = 1, Name = "Apple" },
new Product { Id = 2, Name = "Banana" },
new Product { Id = 3, Name = "Kiwi" },
new Product { Id = 4, Name = "Pineapple" },
new Product { Id = 5, Name = "Orange" }
};
            return Ok(products);
        }
    }
}
