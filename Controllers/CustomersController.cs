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
new Customer { Id = 1, FullName = "Иван" },
new Customer { Id = 2, FullName = "Михаил" },
new Customer { Id = 3, FullName = "Виктор" },
new Customer { Id = 4, FullName = "Павел" },
new Customer { Id = 5, FullName = "Николай" }
};
            return Ok(customers);
        }
    }
}