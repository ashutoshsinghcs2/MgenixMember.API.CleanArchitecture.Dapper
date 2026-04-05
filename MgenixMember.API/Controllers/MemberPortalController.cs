using MgenixMember.API.Services;
using MgenixMember.Application.Common;
using MgenixMember.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MgenixMember.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] 
public class MemberPortalController : BaseController
{
    private readonly IMemberPortalService _service;
    private readonly ICurrentUserService _currentUser;
    public MemberPortalController(IMemberPortalService service, ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    [HttpGet("profile")]
    public async Task<IActionResult> GetProfile()
    {
        // Get UserId from JWT
        var userIdClaim = _currentUser.UserId;

        if (string.IsNullOrEmpty(userIdClaim))
            return UnauthorizedResponse("Invalid token");

        int clientId = Convert.ToInt32(userIdClaim);

        var result = await _service.GetProfile(clientId);

        if (result == null)
            return Failure<string>("Profile not found");

        return Success(result, "Profile fetched successfully");
    }
}