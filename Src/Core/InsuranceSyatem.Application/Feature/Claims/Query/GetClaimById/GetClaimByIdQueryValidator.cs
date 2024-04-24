using FluentValidation;

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
