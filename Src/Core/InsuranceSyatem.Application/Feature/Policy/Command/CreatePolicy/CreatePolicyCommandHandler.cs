using AutoMapper;
using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Response;
using InsuranceSystem.Application.Helper;
using InsuranceSystem.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using InsuranceSystem.Application.Dtos.Response.Policy;
using PolicyModel =  InsuranceSystem.Domain.Policy;

namespace InsuranceSystem.Application.Feature.Policy.Command.CreatePolicy
{
    public class CreatePolicyCommandHandler : ICommandHandler<CreatePolicyCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePolicyCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(CreatePolicyCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var policy = _mapper.Map<PolicyModel>(request.PolicyRequest);
                _unitOfWork.Policy.AddPolicy(policy);

                await _unitOfWork.SaveAsync();

                var result = _mapper.Map<PolicyResponseDto>(policy);
                return ExecuteResponse<PolicyResponseDto>.Response((int)HttpStatusCode.Created, true, $"Policy created successfully", result);
            }
            catch (Exception)
            {
                //log error
                return ExecuteResponse<PolicyResponseDto>.Response((int)HttpStatusCode.UnprocessableEntity, false, $"Error occus while creating policy, try again", null);
            }
        }
    }
}
