using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Domain.Entities.Member.Request
{
    public class RegisterRequest
    {
        public string SponsorUserName { get; set; }
        public string FirstName { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
    }
}
