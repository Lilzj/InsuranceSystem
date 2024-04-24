using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Api.Controllers;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaims;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Controller.UnitTest.Claims
{
    public class ClaimsControllerUnitTests
    {
        private readonly Mock<IMediator> _mediator = new();
        public ClaimsControllerUnitTests()
        {
        }

        [Fact]
        public async Task GetClaims_ReturnsCorrectResult()
        {
            // Arrange
            var sut = new ClaimsController(_mediator.Object);

            var expected = new BaseResponse
            {
                StatusCode = 200,
                Success = true,
                Message = "Claims retrieved",
                Data = new ClaimsResponseDto()
            };

            _mediator.Setup(m => m.Send(It.IsAny<GetClaimsQueryRequest>(), default))
                .ReturnsAsync(expected);

            // Act
            var result = await sut.GetClaims();

            // Assert
            var response = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(expected, response.Value);
        }
    }
}
