using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Dtos.Response.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicyById
{
    public record GetPoliciesByIdQueryRequest(GetPolicyRequestDto GetPolicy) : IQueryRequest<PolicyResponseDto>
    {
    }
}
