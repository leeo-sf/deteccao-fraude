using MediatR;
using OperationResult;

namespace FraudDetection.Shared.Request;

public record ReadyForRunRequest() : IRequest<Result>;