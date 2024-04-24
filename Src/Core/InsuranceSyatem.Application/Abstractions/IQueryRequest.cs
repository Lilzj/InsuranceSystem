using MediatR;

namespace InsuranceSyatem.Application.Abstractions
{
    public interface IQueryRequest<out TResponse> : IRequest<TResponse>
    {
    }
}
