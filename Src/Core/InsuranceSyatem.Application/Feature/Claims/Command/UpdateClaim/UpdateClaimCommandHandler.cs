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
    public class UpdateClaimCommandHandler : ICommandHandler<UpdateClaimCommandRequest, BaseResponse>
    {
        public Task<BaseResponse> Handle(UpdateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
