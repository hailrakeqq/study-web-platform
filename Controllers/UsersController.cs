using System.Net;
using Microsoft.AspNetCore.Mvc;
using study_web_platform.Helpers;
using study_web_platform.Models;
using study_web_platform.Services;

namespace study_web_platform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var responce = _userService.Authenticate(model);

            if (responce == null)
                return BadRequest(new { message = "Username or password is incorrect." });

            return Ok(responce);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserModel userModel)
        {
            var responce = await _userService.Register(userModel);

            if (responce == null)
                return BadRequest(new { message = "Didn`t register" });

            return Ok(responce);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
