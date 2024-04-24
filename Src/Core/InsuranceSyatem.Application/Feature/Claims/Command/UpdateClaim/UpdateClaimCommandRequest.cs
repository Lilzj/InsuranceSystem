using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;

namespace InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim
{
    public record UpdateClaimCommandRequest(UpdateClaimsRequestDto updateClaim) : ICommandRequest<BaseResponse>
    {
    }
}
