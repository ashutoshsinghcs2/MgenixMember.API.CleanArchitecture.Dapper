using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MgenixMember.Domain.Entities.Member.Request;
using MgenixMember.Domain.Entities.Member.Resonse;

namespace MgenixMember.Domain.Interfaces
{
    public interface IMemberRepository
    {
        Task<RegisterResponse> Register(RegisterRequest dto);
        Task<LoginResponse> Login(LoginRequest dto);
    }
}
