using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MgenixMember.Application.Interfaces;

namespace MgenixMember.Application.Services
{
    public class AuthService
    {
        private readonly IJwtTokenService _jwtService;

        public AuthService(IJwtTokenService jwtService)
        {
            _jwtService = jwtService;
        }

        public string Login(string userId, string email)
        {
            // Validate user from DB (skip for now)

            var token = _jwtService.GenerateToken(userId, email);
            return token;
        }
    }
}
