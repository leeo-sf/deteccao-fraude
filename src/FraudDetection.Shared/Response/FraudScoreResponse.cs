namespace FraudDetection.Shared.Response;

public record FraudScoreResponse(bool Approved, decimal Score);