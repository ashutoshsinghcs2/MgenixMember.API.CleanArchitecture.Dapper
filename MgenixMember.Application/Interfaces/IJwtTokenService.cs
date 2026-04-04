using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Application.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateToken(string userId, string email);
    }
}
