using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Application.DTOs.Member.Request
{
    public class RegisterRequestDto
    {
        public string SponsorUserName { get; set; }
        public string FirstName { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
    }
}
