using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Application.DTOs.Member.Request
{
    public class LoginRequestDto
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
