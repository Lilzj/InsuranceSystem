using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaims
{
    public class GetClaimsQueryHandler : IQueryHandler<GetClaimsQueryRequest, BaseResponse>
    {
        public Task<BaseResponse> Handle(GetClaimsQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
