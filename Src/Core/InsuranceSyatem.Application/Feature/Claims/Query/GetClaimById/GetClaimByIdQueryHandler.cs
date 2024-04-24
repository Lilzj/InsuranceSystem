using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Helper;
using InsuranceSystem.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaimById
{
    public class GetClaimByIdQueryHandler : IQueryHandler<GetClaimByIdQueryRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetClaimByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(GetClaimByIdQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var claim = await _unitOfWork.Claims.GetClaimById(request.Id);
                if (claim == null) return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.NotFound, false, $"Claim with id {request.Id} does not exist", null);

                var claimToReturn = _mapper.Map<ClaimsResponseDto>(claim);
                claimToReturn.TotalAmountToClaim = Utilities.GetTotalAmout(claimToReturn.Expenses.Select(_ => _.Amount));
                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.OK, true, $"Claim retrieved successfully", claimToReturn);
            }
            catch (Exception)
            {
                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.ServiceUnavailable, false, $"Error retriving claim", null);
            }
        }
    }
}
