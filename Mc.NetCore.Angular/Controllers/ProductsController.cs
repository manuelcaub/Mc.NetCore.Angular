namespace Mc_NetCore_Angular.Controllers
{
    using System.Linq;
    using Mc.NetCore.Angular.Model;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Enumerable.Range(1, 5).Select(index => new Product
            {
                Name = $"Product{index}",
                Description = $"Lorem ipsum dolor sit amet {index}",
                Category = Category.Electronics
            }));
        }
    }
}
