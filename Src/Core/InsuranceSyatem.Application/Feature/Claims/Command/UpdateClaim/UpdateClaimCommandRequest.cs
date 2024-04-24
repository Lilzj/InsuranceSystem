using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim
{
    public record UpdateClaimCommandRequest(UpdateClaimsRequestDto updateClaim) : ICommandRequest<BaseResponse>
    {
    }
}
