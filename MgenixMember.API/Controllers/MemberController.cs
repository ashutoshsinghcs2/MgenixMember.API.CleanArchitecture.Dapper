using MgenixMember.API.Services;
using MgenixMember.Application.Common;
using MgenixMember.Application.DTOs.Member.Request;
using MgenixMember.Application.Interfaces;
using MgenixMember.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MgenixMember.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IMemberService _service;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IMemberService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestDto dto)
        {
            var result = await _service.Register(dto);
            if (result == null)
                return Failure<string>("Registration failed");

            return Success(result, "User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto dto)
        {
            _logger.LogInformation("GetProfile API called");
            var result = await _service.Login(dto);

            if (result == null)
                return Failure<string>("Invalid credentials");

            return Success(result, "Login successful");
        }
    }
}
