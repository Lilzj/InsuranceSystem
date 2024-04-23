using InsuranceSyatem.Application.Abstractions;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Dtos.Response.Policy;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaimById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicyById
{
    public class GetPoliciesByIdQueryHandler : IQueryHandler<GetPoliciesByIdQueryRequest, PolicyResponseDto>
    {
        public Task<PolicyResponseDto> Handle(GetPoliciesByIdQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
