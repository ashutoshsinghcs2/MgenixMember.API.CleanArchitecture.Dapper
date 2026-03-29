using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MgenixMember.Application.DTOs.Member.Request;
using MgenixMember.Application.DTOs.Member.Response;
using MgenixMember.Domain.Entities.Member.Request;
using MgenixMember.Domain.Entities.Member.Resonse;
using MgenixMember.Domain.Interfaces;
using MgenixMember.Infrastructure.Data;

namespace MgenixMember.Infrastructure.Repositories
{
   
    public class MemberRepository : IMemberRepository
    {
        private readonly DapperHelper _dapper;

        public MemberRepository(DapperHelper dapper)
        {
            _dapper = dapper;
        }

        public async Task<RegisterResponse> Register(RegisterRequest dto)
        {
            var param = new DynamicParameters();

            param.Add("@SponsorUserName", dto.SponsorUserName);
            param.Add("@FirstName", dto.FirstName);
            param.Add("@MobileNo", dto.MobileNo);
            param.Add("@Password", dto.Password);
            param.Add("@EmailId", dto.EmailId);
            param.Add("@ActionMode", "Insert");

            var result = await _dapper.QueryAsync<RegisterResponse>(
                "USP_MemberRegistration",
                param
            );

            return result.FirstOrDefault();
        }
    }
}
