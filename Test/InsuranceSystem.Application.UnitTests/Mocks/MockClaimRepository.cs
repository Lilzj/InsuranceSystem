using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using InsuranceSystem.Domain.Enum;
using Moq;

namespace InsuranceSystem.Application.UnitTests.Mocks
{
    public static class MockClaimRepository
    {
        public static Mock<IClaimsRepository> ClaimsRepository()
        {
            var claims = new List<Claim>
            {
               new Claim
               {
                    NationalID = "NGN001",
                    Expenses = new List<Expense>
                    {
                        new Expense
                        {
                            ExpenseType = ExpenseType.Procedure,
                            Description = "",
                            Amount = 5000
                        },
                        new Expense
                        {
                            ExpenseType = ExpenseType.Procedure,
                            Description = "",
                            Amount = 5000
                        }
                    }
               }
            };

            var claim = new Claim
            {
                NationalID = "NGN001",
                Expenses = new List<Expense>
                {
                    new Expense
                    {
                        ExpenseType = ExpenseType.Procedure,
                        Description = "",
                        Amount = 5000
                    },
                    new Expense
                    {
                        ExpenseType = ExpenseType.Procedure,
                        Description = "",
                        Amount = 5000
                    }
                }
            };

            var mockRepo = new Mock<IClaimsRepository>();
            mockRepo.Setup(_ => _.GetAllClaims()).ReturnsAsync(claims);

            mockRepo.Setup(_ => _.GetClaimById(It.IsAny<string>())).ReturnsAsync(claim);

            mockRepo.Setup(_ => _.GetClaimsByNationalId(It.IsAny<string>())).ReturnsAsync(claims);

            mockRepo.Setup(_ => _.AddClaim(It.IsAny<Claim>())).Verifiable(Times.AtLeastOnce);



            return mockRepo;
        }
    }
}
