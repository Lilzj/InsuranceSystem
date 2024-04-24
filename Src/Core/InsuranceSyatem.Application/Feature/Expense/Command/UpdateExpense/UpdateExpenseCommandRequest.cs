using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSyatem.Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Feature.Expense.Command.UpdateExpense
{
    public record UpdateExpenseCommandRequest(ExpenseDto AddExpense) : ICommandRequest<BaseResponse>
    {
    }
}
