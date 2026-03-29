using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MgenixMember.Application.DTOs.Member.Request;
using MgenixMember.Application.DTOs.Member.Response;
using MgenixMember.Application.Interfaces;
using MgenixMember.Domain.Entities.Member.Request;
using MgenixMember.Domain.Interfaces;

namespace MgenixMember.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repo;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<RegisterResponseDto> Register(RegisterRequestDto dto)
        {
            var userEntity = _mapper.Map<RegisterRequest>(dto);
            var result = await _repo.Register(userEntity);
            var response = _mapper.Map<RegisterResponseDto>(result);

            if (response != null && response.StatusCode == 1)
            {
                try
                {
                    // call email service here
                }
                catch
                {
                    // ignore or log
                }
            }

            return response;
        }
    }
}
