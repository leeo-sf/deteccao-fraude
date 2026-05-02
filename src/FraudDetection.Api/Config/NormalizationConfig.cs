using System.Text.Json.Serialization;

namespace FraudDetection.Api.Config;

public sealed class NormalizationConfig
{
    [JsonPropertyName("max_amount")]
    public decimal MaxAmount { get; init; } = default!;

    [JsonPropertyName("max_installments")]
    public decimal MaxInstallments { get; init; } = default!;

    [JsonPropertyName("amount_vs_avg_ratio")]
    public decimal AmountVsAvgRatio { get; init; } = default!;

    [JsonPropertyName("max_minutes")]
    public decimal MaxMinutes { get; init; } = default!;

    [JsonPropertyName("max_km")]
    public decimal MaxKm { get; init; } = default!;

    [JsonPropertyName("max_tx_count_24h")]
    public decimal MaxTxCount24h { get; init; } = default!;

    [JsonPropertyName("max_merchant_avg_amount")]
    public decimal MaxMerchantAvgAmount { get; init; } = default!;
}