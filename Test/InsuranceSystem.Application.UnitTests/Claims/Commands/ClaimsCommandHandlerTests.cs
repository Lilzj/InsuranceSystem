using AutoMapper;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Application.Profiles;
using InsuranceSystem.Application.UnitTests.Mocks;
using Moq;
using Shouldly;

namespace InsuranceSystem.Application.UnitTests.Claims.Commands
{
    public class ClaimsCommandHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _unitOfWork = new();
        private readonly Mock<IClaimsRepository> _claimRepo;
        private readonly CreateClaimsRequestDto _addClaim;
        private readonly CreateClaimCommandHandler _handler;

        public ClaimsCommandHandlerTests()
        {
            _claimRepo = MockClaimRepository.ClaimsRepository();
            var mapConfig = new MapperConfiguration(_ =>
            {
                _.AddProfile<MappingProfile>();
            });

            _mapper = mapConfig.CreateMapper();
            _unitOfWork.Setup(_ => _.Claims).Returns(_claimRepo.Object);
            _handler = new CreateClaimCommandHandler(_unitOfWork.Object, _mapper);

            _addClaim = new CreateClaimsRequestDto()
            {
                NationalId = "NGN001",
                Expenses = new List<ExpenseDto>
                {
                    new ExpenseDto
                    {
                        ExpenseType = "Prescription",
                        Description = "",
                        Amount = 5000
                    },
                    new ExpenseDto
                    {
                        ExpenseType = "Prescription",
                        Description = "",
                        Amount = 5000
                    }
                }

            };
        }

        [Fact]
        public async Task AddClaimsTest_Claims_ReturnsClaims()
        {
            var result = await _handler.Handle(new CreateClaimCommandRequest(_addClaim), CancellationToken.None);

            var claims = await _claimRepo.Object.GetAllClaims();

            result.ShouldBeOfType<BaseResponse>();
            claims.Count().ShouldBe(1);

        }
    }
}
