using MgenixMember.Application.DTOs.Member.Request;
using MgenixMember.Application.Interfaces;
using MgenixMember.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MgenixMember.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMemberService _service;

        public UserController(IMemberService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestDto dto)
        {
            var result = await _service.Register(dto);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto dto)
        {
            var result = await _service.Login(dto);

            if (result == null)
                return BadRequest("Something went wrong");

            return Ok(result);
        }
    }
}
