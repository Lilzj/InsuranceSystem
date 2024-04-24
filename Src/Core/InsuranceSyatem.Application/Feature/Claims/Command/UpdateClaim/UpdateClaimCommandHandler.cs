using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using InsuranceSystem.Application.Helper;
using InsuranceSystem.Domain.Enum;

namespace InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim
{
    public class UpdateClaimCommandHandler : ICommandHandler<UpdateClaimCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateClaimCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(UpdateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var claim = await _unitOfWork.Claims.GetClaimById(request.updateClaim.Id);
                if (claim == null) return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.NotFound, false, $"Claim with id {request.updateClaim.Id} does not exist", null);

                var status = (ClaimStatus)Enum.Parse(typeof(ClaimStatus), request.updateClaim.ClaimsStatus);
                claim.ClaimsStatus = status;

                _unitOfWork.Admin.UpdateClaim(claim);
                await _unitOfWork.SaveAsync();
                var result = _mapper.Map<ClaimsResponseDto>(claim);
                result.TotalAmountToClaim = Utilities.GetTotalAmout(result.Expenses.Select(_ => _.Amount));
                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.OK, true, $"Claim updated successfully with status {request.updateClaim.ClaimsStatus} ", result);
            }
            catch (Exception)
            {

                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.UnprocessableContent, false, $"Error occus while updating claims, try again", null);
            }
        }
    }
    
}
