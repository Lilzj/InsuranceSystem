using InsuranceSyatem.Application.Abstractions;
using InsuranceSystem.Application.Dtos.Request.Claims;
using InsuranceSystem.Application.Dtos.Response.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.TrackClaim
{
    public record TrackClaimQueryRequest(GetClaimRequestDto TrackClaim) : IQueryRequest<ClaimsResponseDto>
    {
    }
}
