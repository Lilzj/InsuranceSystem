using InsuranceSyatem.Application.Abstractions;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaimById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.TrackClaim
{
    public class TrackClaimQueryHandler : IQueryHandler<TrackClaimQueryRequest, ClaimsResponseDto>
    {
        public Task<ClaimsResponseDto> Handle(TrackClaimQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
