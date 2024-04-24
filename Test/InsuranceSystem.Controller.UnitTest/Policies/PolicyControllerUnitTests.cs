using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Api.Controllers;
using InsuranceSystem.Application.Dtos.Response.Policy;
using InsuranceSystem.Application.Feature.Policy.Query.GetPolicies;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace InsuranceSystem.Controller.UnitTest.Policies
{
    public class PolicyControllerUnitTests
    {
        private readonly Mock<IMediator> _mediator = new();
        public PolicyControllerUnitTests()
        {
        }

        [Fact]
        public async Task GetPolicies_ReturnsCorrectResult()
        {
            // Arrange
            var sut = new PolicyController(_mediator.Object);

            var expected = new BaseResponse
            {
                StatusCode = 200,
                Success = true,
                Message = "Policies retrieved",
                Data = new PolicyResponseDto()
            };

            _mediator.Setup(m => m.Send(It.IsAny<GetPoliciesQueryRequest>(), default))
                .ReturnsAsync(expected);

            // Act
            var result = await sut.GetPolicies();

            // Assert
            var response = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(expected, response.Value);
        }
    }
}
