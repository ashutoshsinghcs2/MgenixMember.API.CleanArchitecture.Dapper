using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MgenixMember.Domain.Entities.MemberPortal.Response;

namespace MgenixMember.Domain.Interfaces
{
    public interface IMemberPortalRepository
    {
        Task<ProfileResponse> GetProfile(int clientId);
    }
}
