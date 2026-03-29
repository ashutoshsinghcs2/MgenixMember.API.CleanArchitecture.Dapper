using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MgenixMember.Application.DTOs.Member.Request;
using MgenixMember.Application.DTOs.Member.Response;
using MgenixMember.Domain.Entities.Member.Request;
using MgenixMember.Domain.Entities.Member.Resonse;

namespace MgenixMember.Application.Mappings
{
    public class MemberProfile:Profile
    {
        public MemberProfile()
        {
            CreateMap<RegisterRequestDto, RegisterRequest>();
            CreateMap<RegisterResponse, RegisterResponseDto>();
        }
    }
}
