using MgenixMember.Application.Common;
using Microsoft.AspNetCore.Mvc;

namespace MgenixMember.API.Services
{
    public class BaseController : ControllerBase
    {
        protected IActionResult Success<T>(T data, string message = "Success")
        {
            return Ok(ResponseHelper.Success(data, message));
        }

        protected IActionResult Failure<T>(string message)
        {
            return BadRequest(ResponseHelper.Failure<T>(message));
        }
        protected IActionResult UnauthorizedResponse(string message)
        {
            return Unauthorized(ResponseHelper.Failure<string>(message, 401));
        }
    }
}
