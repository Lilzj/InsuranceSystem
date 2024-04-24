using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Persistence;
using System.Net;
using InsuranceSystem.Application.Dtos.Response.Policy;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicies
{
    public class GetPoliciesQueryHandler : IQueryHandler<GetPoliciesQueryRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetPoliciesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(GetPoliciesQueryRequest request, CancellationToken cancellationToken)
        {

            try
            {
                var policies = await _unitOfWork.Policy.GetPolicies();

                var policiestoReturn = _mapper.Map<List<PolicyResponseDto>>(policies);
                return ExecuteResponse<List<PolicyResponseDto>>.Response((int)HttpStatusCode.OK, true, $"Policies retrived successfully", policiestoReturn);
            }
            catch (Exception)
            {
                return ExecuteResponse<List<PolicyResponseDto>>.Response((int)HttpStatusCode.ServiceUnavailable, false, $"Error retriving policies", null);
            }
        }
    }
}
