using System.Text.Json.Serialization;

namespace FraudDetection.Shared.Dto;

public class TransactionDto
{
    /// <summary>
    /// Valor da transação
    /// </summary>
    /// <example>384.88</example>
    public decimal Amount { get; init; }

    /// <summary>
    /// Número de parcelas
    /// </summary>
    /// <example>3</example>
    public int Installments { get; init; }

    /// <summary>
    /// Timestamp UTC da requisição
    /// </summary>
    /// <example>2026-03-11T20:23:35Z</example>
    [JsonPropertyName("requested_at")]
    public DateTime RequestedAt { get; init; }
}