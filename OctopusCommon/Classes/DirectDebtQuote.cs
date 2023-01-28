namespace OctopusCommon.Classes;

internal abstract class DirectDebtQuote : IDirectDebtQuote
{
    [JsonPropertyName("direct_debit_monthly")]
    public IDirectDebitRateQuote? DirectDebitMonthly { get; set; }

    [JsonPropertyName("direct_debit_quarterly")]
    public IDirectDebitRateQuote? DirectDebitQuarterly { get; set; }
}