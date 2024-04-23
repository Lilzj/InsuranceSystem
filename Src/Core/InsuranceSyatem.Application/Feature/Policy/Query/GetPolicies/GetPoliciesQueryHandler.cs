using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicies
{
    public class GetPoliciesQueryHandler : IQueryHandler<GetPoliciesQueryRequest, BaseResponse>
    {
        public Task<BaseResponse> Handle(GetPoliciesQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
