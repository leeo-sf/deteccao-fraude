using System.Text.Json.Serialization;

namespace FraudDetection.Shared.Dto;

public class MerchantDto
{
    /// <summary>
    /// Identificador do comerciante
    /// </summary>
    /// <example>MERC-001</example>
    public string Id { get; init; } = string.Empty;

    /// <summary>
    /// MCC (Merchant Category Code), código da categoria do comerciante
    /// </summary>
    /// <example>"5912"</example>
    public string Mcc { get; init; } = string.Empty;

    /// <summary>
    /// Ticket médio do comerciante
    /// </summary>
    /// <example>298.95</example>
    [JsonPropertyName("avg_amount")]
    public decimal AvgAmount { get; init; }
}