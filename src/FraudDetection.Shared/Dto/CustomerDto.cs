using System.Text.Json.Serialization;

namespace FraudDetection.Shared.Dto;

public class CustomerDto
{
    /// <summary>
    /// Média histórica de gasto do portador do cartão
    /// </summary>
    /// <example>769.76</example>
    [JsonPropertyName("avg_amount")]
    public decimal AvgAmount { get; init; }

    /// <summary>
    /// Quantidade de transações do portador nas últimas 24h
    /// </summary>
    /// <example>3</example>
    [JsonPropertyName("tx_count_24h")]
    public int TxCount24Hours { get; init; }

    /// <summary>
    /// Comerciantes já utilizados pelo portador
    /// </summary>
    /// <example>["MERC-009", "MERC-001", "MERC-001"]</example>
    [JsonPropertyName("known_merchants")]
    public IEnumerable<string> KnownMerchants { get; init; } = Enumerable.Empty<string>();
}