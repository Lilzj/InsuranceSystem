using AutoMapper;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSystem.Application.Dtos.Request.Claims;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Claims
            CreateMap<Claim, GetClaimRequestDto>().ReverseMap();
            CreateMap<Expense, ExpenseDto>().ReverseMap();
            CreateMap<Claim, ClaimsResponseDto>().ReverseMap();
        }
    }
}
