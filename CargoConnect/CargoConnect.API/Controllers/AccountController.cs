using CargoConnect.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AccountController : ControllerBase
    {
        IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register-User")]
        public async Task<IActionResult> RegisterUser(UserCreateDTO userCreateDto)
        {
            if(ModelState.IsValid)
            {
                bool status = await _userService.CreateAsync(userCreateDto);
                if (status)
                {
                    return Created("",userCreateDto);
                }
                return BadRequest();
            }
            return BadRequest();
        }
    }
}
