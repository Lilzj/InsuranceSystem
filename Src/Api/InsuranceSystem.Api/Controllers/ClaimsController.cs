using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaimById;
using InsuranceSystem.Application.Feature.Claims.Query.GetClaims;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : BaseController
    {
        private readonly IMediator _mediator;
        public ClaimsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public async Task<IActionResult> GetClaims()
        {
            var response = await _mediator.Send(new GetClaimsQueryRequest());
            return ResolveActionResult(response);
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpGet("id")]
        public async Task<IActionResult> GetClaimById(string id)
        {
            var response = await _mediator.Send(new GetClaimByIdQueryRequest(id));
            return ResolveActionResult(response);
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public async Task<IActionResult> AddClaim(CreateClaimsRequestDto request)
        {
            var response = await _mediator.Send(new CreateClaimCommandRequest(request));
            return ResolveActionResult(response);
        }

    }
}
