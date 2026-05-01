using FraudDetection.Shared.Dto;
using FraudDetection.Shared.Response;
using MediatR;
using OperationResult;
using System.Text.Json.Serialization;

namespace FraudDetection.Shared.Request;

public record FraudScoreRequest : IRequest<Result<FraudScoreResponse>>
{
    /// <summary>
    /// Identificador da transação
    /// </summary>
    /// <example>tx-3576980410</example>
    public string Id { get; init; } = string.Empty;

    /// <summary>
    /// Dados da transação
    /// </summary>
    public required TransactionDto Transaction { get; init; }

    /// <summary>
    /// Informações do cliente
    /// </summary>
    public required CustomerDto Customer { get; init; }

    /// <summary>
    /// Informações do comerciante
    /// </summary>
    public required MerchantDto Merchant { get; init; }

    /// <summary>
    /// Informações da forma com que a compra foi feita (online, etc)
    /// </summary>
    public required TerminalDto Terminal { get; init; }

    /// <summary>
    /// Informações da última compra
    /// </summary>
    [JsonPropertyName("last_transaction")]
    public LastTransactionDto? LastTransaction { get; init; }
}