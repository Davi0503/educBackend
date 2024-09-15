using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EducBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly IConfiguration _configuration;
        public LoginController(ILoginService loginService, IConfiguration configuration)
        {
            _loginService = loginService;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Post()
            {
            await _loginService.teste();
            return Ok();
        }
        
    }
}
