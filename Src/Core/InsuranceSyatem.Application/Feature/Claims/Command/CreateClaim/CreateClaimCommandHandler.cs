using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim
{
    public class CreateClaimCommandHandler : ICommandHandler<CreateClaimCommandRequest, BaseResponse>
    {
        public Task<BaseResponse> Handle(CreateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
