namespace OctopusCommon.Classes;

internal abstract class SampleQuotes : ISampleQuotes
{
    [JsonPropertyName("_A")] public IDirectDebtQuote QuoteA { get; set; }
    [JsonPropertyName("_B")] public IDirectDebtQuote QuoteB { get; set; }
}