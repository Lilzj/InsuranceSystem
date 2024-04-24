using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;

namespace InsuranceSystem.Application.Feature.Expense.Command.UpdateExpense
{
    public class UpdateExpenseCommandHandler : ICommandHandler<UpdateExpenseCommandRequest, BaseResponse>
    {
        public Task<BaseResponse> Handle(UpdateExpenseCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
