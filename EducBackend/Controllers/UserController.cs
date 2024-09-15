using Domain.Entidades;
using Domain.Interfaces.Services;
using Domain.Mapping;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _userService.GetAllUsers();

            return Ok(response);
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<IActionResult> GetId(int id)
        {
            var response = await _userService.GetUserByID(id);

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Post(UserModel user) 
        {
            try
            {                
                await _userService.CreateUser(user);

                return Created();

            }catch (Exception ex)            
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut]
        public async Task<IActionResult> Put(User user) 
        {
            try
            {
                await _userService.UpdateUser(user);

                return Ok();

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            try
            {
                _userService.DeleteUser(id);

                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
