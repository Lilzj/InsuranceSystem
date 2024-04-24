﻿using MediatR;

namespace InsuranceSyatem.Application.Abstractions
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
                  where TCommand : ICommandRequest<TResponse>
    {
    }
}
