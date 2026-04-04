using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MgenixMember.Domain.Entities.MemberPortal.Response;
using MgenixMember.Domain.Interfaces;
using MgenixMember.Infrastructure.Data;

namespace MgenixMember.Infrastructure.Repositories
{
    public class MemberPortalRepository:IMemberPortalRepository
    {
        private readonly DapperHelper _dapper;

        public MemberPortalRepository(DapperHelper dapper)
        {
            _dapper = dapper;
        }
        public async Task<ProfileResponse> GetProfile(int clientId)
        {
            var param = new DynamicParameters();
            param.Add("@ActionMode", "GetProfile");
            param.Add("@ClientId", clientId);

            var result = await _dapper.GetAsync<ProfileResponse>(
                "USP_UpdateProfile",
                param
            );

            return result;
        }
    }
}
