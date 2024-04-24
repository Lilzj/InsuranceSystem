using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response.Policy;
using InsuranceSystem.Application.Persistence;
using System.Net;

namespace InsuranceSystem.Application.Feature.Policy.Query.GetPolicyById
{
    public class GetPoliciesByIdQueryHandler : IQueryHandler<GetPoliciesByIdQueryRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetPoliciesByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(GetPoliciesByIdQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var policy = await _unitOfWork.Policy.GetPolicyById(request.Id);
                if (policy == null) return ExecuteResponse<PolicyResponseDto>.Response((int)HttpStatusCode.NotFound, false, $"Policy with id {request.Id} does not exist", null);

                var policyToReturn = _mapper.Map<PolicyResponseDto>(policy);

                return ExecuteResponse<PolicyResponseDto>.Response((int)HttpStatusCode.OK, true, $"Policy retrieved successfully", policyToReturn);
            }
            catch (Exception)
            {
                return ExecuteResponse<PolicyResponseDto>.Response((int)HttpStatusCode.ServiceUnavailable, false, $"Error retriving claim", null);
            }
        }
    }
}
