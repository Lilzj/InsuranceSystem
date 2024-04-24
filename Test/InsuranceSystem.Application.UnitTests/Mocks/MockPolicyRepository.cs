using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using Moq;

namespace InsuranceSystem.Application.UnitTests.Mocks
{
    public static class MockPolicyRepository
    {
        public static Mock<IPolicyRepository> PolicyRepository()
        {
            var policies = new List<Policy>
            {
               new Policy
               {
                 Name = "Test",
                 Surname = "Test",
                 DOB = new DateTime(1995, 03, 25)
               }
            };

            var policy = new Policy
            {
                Name = "Test2",
                Surname = "Test2",
                DOB = new DateTime(1997, 03, 25)
            };

            var mockRepo = new Mock<IPolicyRepository>();
            mockRepo.Setup(_ => _.GetPolicies()).ReturnsAsync(policies);

            mockRepo.Setup(_ => _.GetPolicyById(It.IsAny<string>())).ReturnsAsync(policy);

            mockRepo.Setup(_ => _.GetPoliciesByNationalID(It.IsAny<string>())).ReturnsAsync(policies);

            mockRepo.Setup(_ => _.AddPolicy(It.IsAny<Policy>())).Verifiable(Times.AtLeastOnce);



            return mockRepo;
        }
    }
}
