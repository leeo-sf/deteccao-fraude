using FraudDetection.Shared.Request;
using FraudDetection.Shared.Response;

namespace FraudDetection.Api.Endpoints;

internal static class FraudDetectionEndpoints
{
    public static void AddFraudEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/fraud")
            .WithTags("Fraud");

        group.MapGet("ready", ReadyAsync)
            .Produces(StatusCodes.Status204NoContent);

        group.MapPost("score", FraudScoreAsync)
            .Produces<FraudScoreResponse>(StatusCodes.Status200OK);
    }

    private static async ValueTask<IResult> ReadyAsync() =>
        Results.NoContent();

    private static async ValueTask<IResult> FraudScoreAsync(FraudScoreRequest request) =>
        Results.Ok();
}