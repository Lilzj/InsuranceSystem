using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSyatem.Application.Abstractions
{
    public interface ICommandRequest<out TResponse> : IRequest<TResponse>
    {
    }
}
