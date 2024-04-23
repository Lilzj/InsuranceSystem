using InsuranceSyatem.Application.Abstractions;
using InsuranceSystem.Application.Dtos.Response.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaimById
{
    public class GetClaimByIdQueryHandler : IQueryHandler<GetClaimByIdQueryRequest, ClaimsResponseDto>
    {
        public Task<ClaimsResponseDto> Handle(GetClaimByIdQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
