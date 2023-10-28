using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpg.Dtos;

namespace rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(RegisterUserDto newUser)
        {
            var response = await _authRepository.Register(
                new User { Username = newUser.Username }, newUser.Password);

            if (!response.Success)
                return BadRequest(response);
            return Ok(response);
        }
    }
}