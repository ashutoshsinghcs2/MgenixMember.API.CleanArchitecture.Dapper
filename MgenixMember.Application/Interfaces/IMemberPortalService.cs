using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MgenixMember.Application.DTOs.MemberPortal.Response;
using MgenixMember.Domain.Entities.MemberPortal.Response;

namespace MgenixMember.Application.Interfaces
{
    public interface IMemberPortalService
    {
        Task<ProfileResponse> GetProfile(int clientId);
    }
}
