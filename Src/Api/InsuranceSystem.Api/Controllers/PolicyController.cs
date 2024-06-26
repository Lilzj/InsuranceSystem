﻿using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Feature.Policy.Command.CreatePolicy;
using InsuranceSystem.Application.Feature.Policy.Query.GetPolicies;
using InsuranceSystem.Application.Feature.Policy.Query.GetPolicyById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : BaseController
    {
        private readonly IMediator _mediator;
        public PolicyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpGet("id")]
        public async Task<IActionResult> GetPolicy(string id)
        {
            var response = await _mediator.Send(new GetPoliciesByIdQueryRequest(id)); 
            return ResolveActionResult(response);
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public async Task<IActionResult> GetPolicies()
        {

            var response = await _mediator.Send(new GetPoliciesQueryRequest());
            return ResolveActionResult(response);
        }

        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseResponse), StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public async Task<IActionResult> CreatePolicy(CreatePolicyRequestDto request)
        {
            var response = await _mediator.Send(new CreatePolicyCommandRequest(request));
            return ResolveActionResult(response);
        }
    }
}
