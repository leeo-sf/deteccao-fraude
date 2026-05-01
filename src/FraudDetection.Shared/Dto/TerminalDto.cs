using System.Text.Json.Serialization;

namespace FraudDetection.Shared.Dto;

public class TerminalDto
{
    /// <summary>
    /// Indica se a transação é online ou presencial
    /// </summary>
    /// <example>false</example>
    [JsonPropertyName("is_online")]
    public bool IsOnline { get; init; }

    /// <summary>
    /// Indica se o cartão está presente no terminal
    /// </summary>
    /// <example>true</example>
    [JsonPropertyName("card_present")]
    public bool CardPresent { get; init; }

    /// <summary>
    /// Distância, em km, do endereço do portador
    /// </summary>
    /// <example>13.7090520965</example>
    [JsonPropertyName("km_from_home")]
    public decimal KmFromHome { get; init; }
}