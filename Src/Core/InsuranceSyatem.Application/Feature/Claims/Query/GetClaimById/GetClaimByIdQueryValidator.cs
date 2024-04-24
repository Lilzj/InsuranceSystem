using FluentValidation;
using InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Query.GetClaimById
{
    public class GetClaimByIdQueryValidator : AbstractValidator<GetClaimByIdQueryRequest>
    {
        public GetClaimByIdQueryValidator()
        {
            RuleFor(_ => _.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Claim Id is required");
        }
    }
}
