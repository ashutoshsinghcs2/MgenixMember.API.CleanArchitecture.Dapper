using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MgenixMember.Application.DTOs.Member.Response;
using MgenixMember.Application.DTOs.MemberPortal.Response;
using MgenixMember.Application.Interfaces;
using MgenixMember.Domain.Entities.MemberPortal.Response;
using MgenixMember.Domain.Interfaces;

namespace MgenixMember.Application.Services
{
    public class MemberPortalService:IMemberPortalService
    {
        private readonly IMemberPortalRepository _repo;
        private readonly IMapper _mapper;
        public MemberPortalService(IMemberPortalRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ProfileResponse> GetProfile(int clientId)
        {
            var result = await _repo.GetProfile(clientId);
            var response = _mapper.Map<ProfileResponse>(result);
            if (response == null)
                throw new Exception("Profile not found");

            return response;
        }
    }
}
