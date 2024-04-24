using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Api.Controllers;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Controller.UnitTest.Admin
{
    public class AdminControllerUnitTests
    {
        private readonly Mock<IMediator> _mediator = new();
        public AdminControllerUnitTests()
        {
        }

        [Fact]
        public async Task UpdateClaims_ReturnsCorrectResult()
        {
            // Arrange
            var sut = new AdminController(_mediator.Object);

            var expected = new BaseResponse
            {
                StatusCode = 200,
                Success = true,
                Message = "Claims retrieved",
                Data = new ClaimsResponseDto()
            };

            _mediator.Setup(m => m.Send(It.IsAny<UpdateClaimCommandRequest>(), default))
                .ReturnsAsync(expected);

            // Act
            var result = await sut.UpdateClaim(It.IsAny<UpdateClaimsRequestDto>());

            // Assert
            var response = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(expected, response.Value);
        }
    }
}
