using Domain.Entidades.Dtos.Login;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EducBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LoginRequest data)
        {
            await _loginService.Login(data);
            return Ok();
        }
        
    }
}
