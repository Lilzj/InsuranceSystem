using InsuranceSyatem.Application.Abstractions;
using InsuranceSyatem.Application.Dtos.Response;
using InsuranceSyatem.Application.Feature.Claims.Command.CreateClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
