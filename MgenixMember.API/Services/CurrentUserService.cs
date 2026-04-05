using System.Security.Claims;
using MgenixMember.Application.Common;

namespace MgenixMember.API.Services
{
   
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId =>
            _httpContextAccessor.HttpContext?.User?.FindFirst("UserId")?.Value;

        public string Email =>
            _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Email)?.Value;
    }
}
