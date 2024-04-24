using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaims
{
    public record GetClaimsQueryRequest() : IQueryRequest<BaseResponse>
    {
    }
}
