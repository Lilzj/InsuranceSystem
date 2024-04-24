using InsuranceSyatem.Application.Dtos.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace InsuranceSystem.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        private IConfiguration? _config;
        private ISender? _mediator;

        protected ActionResult ResolveActionResult(BaseResponse response)
        {
            var result = response.StatusCode switch
            {
                (int)HttpStatusCode.OK => Ok(response),
                (int)HttpStatusCode.Created => StatusCode(StatusCodes.Status201Created, response),
                (int)HttpStatusCode.Accepted => StatusCode(StatusCodes.Status202Accepted, response),
                (int)HttpStatusCode.NoContent => StatusCode(StatusCodes.Status204NoContent, response),
                (int)HttpStatusCode.BadRequest => BadRequest(response),
                (int)HttpStatusCode.Unauthorized => StatusCode(StatusCodes.Status401Unauthorized, response),
                (int)HttpStatusCode.NotFound => StatusCode(StatusCodes.Status404NotFound, response),
                (int)HttpStatusCode.Forbidden => StatusCode(StatusCodes.Status403Forbidden, response),
                (int)HttpStatusCode.Conflict => StatusCode(StatusCodes.Status409Conflict, response),
                (int)HttpStatusCode.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, response),
                (int)HttpStatusCode.UnprocessableEntity => StatusCode(StatusCodes.Status422UnprocessableEntity, response),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response)
            };

            return result;
        }
    }
}
