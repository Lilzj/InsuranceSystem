using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaimById
{
    public record GetClaimByIdQueryRequest(string Id) : IQueryRequest<BaseResponse>
    {
    }
}
