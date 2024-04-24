using FluentValidation;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Expense.Command.UpdateExpense
{
    public class UpdateExpenseCommandValidator : AbstractValidator<UpdateExpenseCommandRequest>
    {
        public UpdateExpenseCommandValidator()
        {
            RuleFor(_ => _.AddExpense.Amount)
                .NotEmpty()
                .WithMessage("Amount is needed");
        }
    }
}
