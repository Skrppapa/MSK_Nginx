using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var customers = new[] {
new Customer { Id = 1, FullName = "Alice" },
new Customer { Id = 2, FullName = "Bob" },
new Customer { Id = 3, FullName = "Max" },
new Customer { Id = 4, FullName = "Susan" },
new Customer { Id = 5, FullName = "Kevin" }
};
            return Ok(customers);
        }
    }
}