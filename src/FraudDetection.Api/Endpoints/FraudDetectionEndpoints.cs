using FraudDetection.Shared.Request;
using FraudDetection.Shared.Response;
using MediatR;

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

    private static async ValueTask<IResult> ReadyAsync(IMediator mediator) =>
        await mediator.SendCommand(new ReadyForRunRequest(), StatusCodes.Status204NoContent);

    private static async ValueTask<IResult> FraudScoreAsync(IMediator mediator, FraudScoreRequest request) =>
        await mediator.SendCommand(request, StatusCodes.Status200OK);
}