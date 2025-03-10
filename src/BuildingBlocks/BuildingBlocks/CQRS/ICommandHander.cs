﻿using MediatR;
namespace BuildingBlocks.CQRS;

public interface ICommandHander<in TCommand>
    : ICommandHander<TCommand, Unit>
    where TCommand : ICommand<Unit>
{
}

public interface ICommandHander<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse>
     where TCommand : ICommand<TResponse>
     where TResponse : notnull
{
}
