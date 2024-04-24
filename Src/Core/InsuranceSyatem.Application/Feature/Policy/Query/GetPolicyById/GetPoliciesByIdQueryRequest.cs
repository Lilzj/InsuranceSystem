using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicyById
{
    public record GetPoliciesByIdQueryRequest(string Id) : IQueryRequest<BaseResponse>
    {
    }
}
