using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Persistence;
using System.Net;
using InsuranceSystem.Application.Helper;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaims
{
    public class GetClaimsQueryHandler : IQueryHandler<GetClaimsQueryRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetClaimsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(GetClaimsQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var claim = await _unitOfWork.Claims.GetAllClaims();

                var clainToReturn = _mapper.Map<List<ClaimsResponseDto>>(claim);

                foreach (var item in clainToReturn)
                {
                    item.TotalAmountToClaim = Utilities.GetTotalAmout(item.Expenses.Select(_ => _.Amount));
                }
                return ExecuteResponse<List<ClaimsResponseDto>>.Response((int)HttpStatusCode.OK, true, $"Claims retrived successfully", clainToReturn);
            }
            catch (Exception)
            {
                return ExecuteResponse<ClaimsResponseDto>.Response((int)HttpStatusCode.ServiceUnavailable, false, $"Error retriving claims", null);
            }
        }
    }
}
