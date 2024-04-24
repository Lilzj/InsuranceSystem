using MediatR;

namespace InsuranceSyatem.Application.Abstractions
{
    public interface ICommandRequest<out TResponse> : IRequest<TResponse>
    {
    }
}
