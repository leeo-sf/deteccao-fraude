using System.Text.Json.Serialization;

namespace FraudDetection.Shared.Dto;

public class LastTransactionDto
{
    /// <summary>
    /// Timestamp UTC da transação anterior
    /// </summary>
    /// <example>2026-03-11T14:58:35Z</example>
    public DateTime TimeStamp { get; init; }

    /// <summary>
    /// Distância, em km, entre a transação anterior e a atual
    /// </summary>
    /// <example>18.8626479774</example>
    [JsonPropertyName("km_from_current")]
    public decimal KmFromCurrent { get; init; }
}