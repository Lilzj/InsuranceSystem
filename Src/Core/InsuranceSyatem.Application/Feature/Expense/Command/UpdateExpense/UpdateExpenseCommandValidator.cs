using FluentValidation;

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
