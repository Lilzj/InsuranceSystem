using FluentValidation;
using InsuranceSystem.Application.Feature.Expense.Command.UpdateExpense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim
{
    public sealed class CreateClaimCommandValidator : AbstractValidator<CreateClaimCommandRequest>
    {
        public CreateClaimCommandValidator()
        {
            RuleFor(_ => _.ClaimRequest.NationalId)
            .NotEmpty()
            .WithMessage("National Id is required")
            .MinimumLength(1)
            .WithMessage("Id number should not be less than 5 characters");
            RuleForEach(_ => _.ClaimRequest.Expenses)
                .ChildRules(_ =>
                {
                    _.RuleFor(_ => _.ExpenseType)
                     .IsInEnum()
                     .WithMessage("Expense type provided is not a valid expense, expenses should be: (Procedures, Prescriptions");
                    _.RuleFor(_ => _.Description)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Expense description is needed");
                    _.RuleFor(_ => _.Amount)
                    .Null()
                    .NotEmpty()
                    .WithMessage("Expense cost is needed")
                    .LessThan(1)
                    .WithMessage("Expense cost cannot be zero");
                });
            
        }
    }
}
