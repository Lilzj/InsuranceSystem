using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSystem.Application.Dtos.Request.Claims;
using InsuranceSystem.Application.Dtos.Response.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaimById
{
    public record GetClaimByIdQueryRequest(string Id) : IQueryRequest<BaseResponse>
    {
    }
}
