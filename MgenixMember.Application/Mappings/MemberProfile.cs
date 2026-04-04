using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MgenixMember.Application.DTOs.Member.Request;
using MgenixMember.Application.DTOs.Member.Response;
using MgenixMember.Application.DTOs.MemberPortal.Response;
using MgenixMember.Domain.Entities.Member.Request;
using MgenixMember.Domain.Entities.Member.Resonse;
using MgenixMember.Domain.Entities.MemberPortal.Response;

namespace MgenixMember.Application.Mappings
{
    public class MemberProfile:Profile
    {
        public MemberProfile()
        {
            CreateMap<RegisterRequestDto, RegisterRequest>();
            CreateMap<RegisterResponse, RegisterResponseDto>();
            CreateMap<LoginRequestDto, LoginRequest>();
            CreateMap<LoginResponse, LoginResponseDto>();
            CreateMap<ProfileResponse, ProfileResponseDto>();
        }
    }
}
