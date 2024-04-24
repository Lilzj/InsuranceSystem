using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim
{
    public record CreateClaimCommandRequest(CreateClaimsRequestDto ClaimRequest) : ICommandRequest<BaseResponse>
    {
    }
}
