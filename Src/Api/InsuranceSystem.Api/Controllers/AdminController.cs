using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : BaseController
    {
        private readonly IMediator _mediator;
        public string Token = string.Empty;
        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpPut("Claim")]
        public async Task<IActionResult> UpdateClaim(UpdateClaimsRequestDto request)
        {
            //Get the token from the request header: Token = Request.Headers["Token"]

            if (string.IsNullOrWhiteSpace(Token) || (!string.IsNullOrWhiteSpace(Token) && (Token != "Admin")))
                return Unauthorized();
            var response = await _mediator.Send(new UpdateClaimCommandRequest(request));
            return ResolveActionResult(response);
        }
    }
}
