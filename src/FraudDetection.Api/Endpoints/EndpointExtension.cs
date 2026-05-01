using MediatR;
using OperationResult;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace FraudDetection.Api.Endpoints;

internal static class EndpointExtension
{
    public static async ValueTask<IResult> SendCommand<T>(this IMediator mediator, IRequest<Result<T>> req, int statusCode = StatusCodes.Status200OK)
    {
        var response = await mediator.Send(req);

        return response.IsSuccess
            ? Results.Json(response.Value, statusCode: statusCode)
            : HandleError(response.Exception);
    }

    public static async ValueTask<IResult> SendCommand(this IMediator mediator, IRequest<Result> req, int statusCode = StatusCodes.Status200OK)
    {
        var response = await mediator.Send(req);

        return response.IsSuccess
            ? Results.StatusCode(statusCode)
            : HandleError(response.Exception);
    }

    private static IResult HandleError(Exception error)
        => error switch
        {
            ApplicationException applicationException => Results.Json(new { applicationException.Message }, statusCode: StatusCodes.Status422UnprocessableEntity),
            _ => Results.Json(new { Message = "An unexpected error occurred." }, statusCode: StatusCodes.Status500InternalServerError)
        };
}