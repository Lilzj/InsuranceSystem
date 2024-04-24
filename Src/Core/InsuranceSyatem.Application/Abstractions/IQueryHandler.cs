using MediatR;

namespace InsuranceSyatem.Application.Abstractions
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
                  where TQuery : IQueryRequest<TResponse>
    {
    }
}
