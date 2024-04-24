using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Helper;
using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using System.Net;

namespace InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim
{
    public class CreateClaimCommandHandler : ICommandHandler<CreateClaimCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CreateClaimCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseResponse> Handle(CreateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var claim = _mapper.Map<Claim>(request.ClaimRequest);
                _unitOfWork.Claims.AddClaim(claim);

                await _unitOfWork.SaveAsync();

                var result = _mapper.Map<ClaimsResponseDto>(claim);
                result.TotalAmountToClaim = Utilities.GetTotalAmout(result.Expenses.Select(_ => _.Amount));
                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.Created, true, $"Claim successfully submitted, you can track the status of your claim using {result?.Id} or {result?.NationalID}", result);
            }
            catch (Exception)
            {
                //log error
                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.UnprocessableEntity, false, $"Error occus while submitting your claims, try again", null);
            }
        }
    }
}
