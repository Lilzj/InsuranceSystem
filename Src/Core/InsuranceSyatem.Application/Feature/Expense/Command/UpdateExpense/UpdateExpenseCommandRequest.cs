using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.Feature.Expense.Command.UpdateExpense
{
    public record UpdateExpenseCommandRequest(ExpenseDto AddExpense) : ICommandRequest<BaseResponse>
    {
    }
}
