using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Application.DTOs.Member.Response
{
    public class LoginResponseDto
    {
        public string? StatusCode { get; set; }
        public string? Msg { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? EmailId { get; set; }
        public string? Token { get; set; } 
    }
}
