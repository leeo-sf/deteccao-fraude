using FraudDetection.Shared.Request;
using MediatR;
using OperationResult;

namespace FraudDetection.Domain.Handler;

public class ReadyForRunHandler : IRequestHandler<ReadyForRunRequest, Result>
{
    public Task<Result> Handle(ReadyForRunRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}