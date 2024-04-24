using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicies
{
    public record GetPoliciesQueryRequest() : IQueryRequest<BaseResponse>
    {
    }
}
