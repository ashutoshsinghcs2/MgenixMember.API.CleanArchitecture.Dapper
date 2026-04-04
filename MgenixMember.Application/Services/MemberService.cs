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
using MgenixMember.Domain.Entities.Member.Resonse;
using MgenixMember.Domain.Interfaces;

namespace MgenixMember.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repo;
        private readonly IMapper _mapper;
        private readonly IJwtTokenService _jwtService;

        public MemberService(IMemberRepository repo, IMapper mapper, IJwtTokenService jwtService)
        {
            _repo = repo;
            _mapper = mapper;
            _jwtService = jwtService;
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
        public async Task<LoginResponseDto> Login(LoginRequestDto dto)
        {
            //var result = await _repo.Login(dto);

            var userEntity = _mapper.Map<LoginRequest>(dto);
            var result = await _repo.Login(userEntity);
            var response = _mapper.Map<LoginResponseDto>(result);

            if (response != null && response.StatusCode == "1")
            {
                var token = _jwtService.GenerateToken(response.UserId, response.EmailId);
                response.Token = token;
            }

            return response;
        }
        //public string Login(string userId, string email)
        //{
        //    // Validate user from DB (skip for now)

        //    var token = _jwtService.GenerateToken(userId, email);
        //    return token;
        //}
    }
}
