using AutoMapper;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Feature.Policy.Query.GetPolicies;
using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Application.Profiles;
using InsuranceSystem.Application.UnitTests.Mocks;
using Moq;
using Shouldly;

namespace InsuranceSystem.Application.UnitTests.Policies.Queries
{
    public class PolicyQueriesHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _unitOfWork = new();
        private readonly Mock<IPolicyRepository> _policyRepo;

        public PolicyQueriesHandlerTests()
        {
            _policyRepo = MockPolicyRepository.PolicyRepository();
            var mapConfig = new MapperConfiguration(_ =>
            {
                _.AddProfile<MappingProfile>();
            });

            _mapper = mapConfig.CreateMapper();
            _unitOfWork.Setup(_ => _.Policy).Returns(_policyRepo.Object);
        }

        [Fact]
        public async Task GetClaimsTest_ClaimsExist_ReturnsClaims()
        {
            var handler = new GetPoliciesQueryHandler(_unitOfWork.Object, _mapper);

            var result = await handler.Handle(new GetPoliciesQueryRequest(), CancellationToken.None);

            result.ShouldBeOfType<BaseResponse>();

        }
    }
}
