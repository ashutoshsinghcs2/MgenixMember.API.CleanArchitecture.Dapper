using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Domain.Entities.Member.Resonse
{
    public class RegisterResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
    }
}
