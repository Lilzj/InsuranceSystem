using FluentValidation;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InsuranceSystem.Application.Feature.Policy.Command.CreatePolicy
{
    public class CreatePolicyCommandValidation : AbstractValidator<CreatePolicyCommandRequest>
    {
        public CreatePolicyCommandValidation()
        {
            RuleFor(_ => _.PolicyRequest.PolicyNumber)
                .NotEmpty()
                .NotNull()
                .WithMessage("Policy number is required");
            RuleFor(_ => _.PolicyRequest.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name is required");
            RuleFor(_ => _.PolicyRequest.Surname)
                .NotEmpty()
                .NotNull()
                .WithMessage("Surname is required");
            RuleFor(_ => _.PolicyRequest.NationalID)
                .NotEmpty()
                .NotNull()
                .WithMessage("National Id is required");
            RuleFor(_ => _.PolicyRequest.DOB)
                .NotEmpty()
                .NotNull()
                .WithMessage("Date of birth is required")
                .Must(BeAValidDate)
                .WithMessage("Enter a valid date");
        }

        private bool BeAValidDate(string value)
        {
            DateTime date;
            return DateTime.TryParse(value, out date);
        }
    }
}
