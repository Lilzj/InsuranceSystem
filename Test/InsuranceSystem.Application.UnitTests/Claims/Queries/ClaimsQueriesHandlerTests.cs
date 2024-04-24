using AutoMapper;
using InsuranceSystem.Application.Persistence;
using Moq;
using InsuranceSystem.Application.UnitTests.Mocks;
using InsuranceSystem.Application.Profiles;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaims;
using Shouldly;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.UnitTests.Claims.Queries
{
    public class ClaimsQueriesHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _unitOfWork = new();
        private readonly Mock<IClaimsRepository> _claimRepo;

        public ClaimsQueriesHandlerTests()
        {
            _claimRepo = MockClaimRepository.ClaimsRepository();
            var mapConfig = new MapperConfiguration(_ =>
            {
                _.AddProfile<MappingProfile>();
            });

            _mapper = mapConfig.CreateMapper();
            _unitOfWork.Setup(_ => _.Claims).Returns(_claimRepo.Object);
        }

        [Fact]
        public async Task GetClaimsTest_ClaimsExist_ReturnsClaims()
        {
            var handler = new GetClaimsQueryHandler(_unitOfWork.Object, _mapper);

            var result = await handler.Handle(new GetClaimsQueryRequest(), CancellationToken.None);

            result.ShouldBeOfType<BaseResponse>();

        }
    }
}
