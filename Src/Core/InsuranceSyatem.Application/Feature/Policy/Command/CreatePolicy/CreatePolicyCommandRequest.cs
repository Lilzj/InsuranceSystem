using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;

namespace InsuranceSystem.Application.Feature.Policy.Command.CreatePolicy
{
    public record CreatePolicyCommandRequest(CreatePolicyRequestDto PolicyRequest) : ICommandRequest<BaseResponse>
    {
    }
}
