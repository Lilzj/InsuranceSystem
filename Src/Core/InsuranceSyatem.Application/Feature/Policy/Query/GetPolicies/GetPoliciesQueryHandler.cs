using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaims;
using InsuranceSystem.Application.Helper;
using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
