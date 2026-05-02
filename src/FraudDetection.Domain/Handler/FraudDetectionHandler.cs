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

    private decimal Limit(decimal value) => Math.Clamp(value, 0.0m, 1.0m);

    private float[] Vectorize(FraudScoreRequest request)
    {
        var vector = new float[14];

        return vector;
    }
}