using AutoMapper;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Feature.Policy.Command.CreatePolicy;
using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Application.Profiles;
using InsuranceSystem.Application.UnitTests.Mocks;
using InsuranceSystem.Domain;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.UnitTests.Policies.Commands
{
    public class PolicyCommandHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _unitOfWork = new();
        private readonly Mock<IPolicyRepository> _policyRepo;
        private readonly CreatePolicyRequestDto _addPolicy;
        private readonly CreatePolicyCommandHandler _handler;

        public PolicyCommandHandlerTests()
        {
            _policyRepo = MockPolicyRepository.PolicyRepository();
            var mapConfig = new MapperConfiguration(_ =>
            {
                _.AddProfile<MappingProfile>();
            });

            _mapper = mapConfig.CreateMapper();
            _unitOfWork.Setup(_ => _.Policy).Returns(_policyRepo.Object);
            _handler = new CreatePolicyCommandHandler(_unitOfWork.Object, _mapper);

            _addPolicy  = new CreatePolicyRequestDto
            {
                Name = "Test2",
                Surname = "Test2",
                DOB = new DateTime(1997, 03, 25)
            };
        }

        [Fact]
        public async Task GetClaimsTest_ClaimsExist_ReturnsClaims()
        {
            var result = await _handler.Handle(new CreatePolicyCommandRequest(_addPolicy), CancellationToken.None);

            var policy = await _policyRepo.Object.GetPolicies();

            result.ShouldBeOfType<BaseResponse>();
            policy.Count().ShouldBe(1);

        }
    }
}
