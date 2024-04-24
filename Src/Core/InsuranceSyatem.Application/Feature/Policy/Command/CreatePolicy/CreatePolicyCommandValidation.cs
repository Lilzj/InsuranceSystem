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
                .WithMessage("You must be 18 and above to be a policy holder");
        }

        private bool BeAValidDate(DateTime value)
        {
            var currentYear = DateTime.Now.Year;
            var dateOfBirth = Convert.ToDateTime(value);
            int age = currentYear - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;
            return age > 18;
        }
    }
}
