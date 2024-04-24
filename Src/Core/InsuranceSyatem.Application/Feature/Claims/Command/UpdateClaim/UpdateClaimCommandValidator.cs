using FluentValidation;
using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Claims.Command.UpdateClaim
{
    public sealed class UpdateClaimCommandValidator : AbstractValidator<UpdateClaimCommandRequest>
    {
        public UpdateClaimCommandValidator()
        {
            RuleFor(_ => _.updateClaim.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Claim Id is required");
            RuleFor(_ => _.updateClaim.ClaimsStatus)
                .NotEmpty()
                .NotNull()
                .WithMessage("Claim status is required")
                .NotEqual("Submitted")
                .WithMessage("Claim status provided is not a valid status, status should be: Approve, Decline, InReview")
                .IsInEnum()
                .WithMessage("Claim status provided is not a valid status, status should be: Approve, Decline, InReview");
        }
    }
}
