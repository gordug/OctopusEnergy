namespace OctopusCommon.Interfaces;

public interface ISampleQuotes
{
    [JsonPropertyName("_A")] IDirectDebtQuote QuoteA { get; set; }
    [JsonPropertyName("_B")] IDirectDebtQuote QuoteB { get; set; }
}