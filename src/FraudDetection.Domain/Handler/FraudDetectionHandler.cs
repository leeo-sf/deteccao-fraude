using FraudDetection.Shared.Request;
using FraudDetection.Shared.Response;
using MediatR;
using OperationResult;

namespace FraudDetection.Domain.Handler;

public class FraudDetectionHandler : IRequestHandler<FraudScoreRequest, Result<FraudScoreResponse>>
{
    public Task<Result<FraudScoreResponse>> Handle(FraudScoreRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}