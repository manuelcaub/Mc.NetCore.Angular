namespace Mc.NetCore.Angular.Controllers
{
    using Mc.NetCore.Angular.Model;
    using Mc.NetCore.Angular.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userService.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _userService.Save(user);
            return Created($"{Request.Path.Value}/{user.Id}", user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _userService.Update(user);
            return Ok(user);
        }
    }
}
