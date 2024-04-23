using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Policy.Command.CreatePolicy
{
    public class CreatePolicyCommandHandler : ICommandHandler<CreatePolicyCommandRequest, BaseResponse>
    {
        public Task<BaseResponse> Handle(CreatePolicyCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
