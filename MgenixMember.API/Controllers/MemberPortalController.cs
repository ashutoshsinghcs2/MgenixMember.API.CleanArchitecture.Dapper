using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MgenixMember.Application.Interfaces;

namespace MgenixMember.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] 
public class MemberPortalController : ControllerBase
{
    private readonly IMemberPortalService _service;

    public MemberPortalController(IMemberPortalService service)
    {
        _service = service;
    }

    [HttpGet("profile")]
    public async Task<IActionResult> GetProfile()
    {
        //  Get UserId from JWT Token
        var userIdClaim = User.FindFirst("UserId")?.Value;

        if (string.IsNullOrEmpty(userIdClaim))
        {
            return Unauthorized(new
            {
                Status = false,
                Message = "Invalid token"
            });
        }

        int clientId = Convert.ToInt32(userIdClaim);

        var result = await _service.GetProfile(clientId);

        return Ok(new
        {
            Status = true,
            Data = result
        });
    }
}