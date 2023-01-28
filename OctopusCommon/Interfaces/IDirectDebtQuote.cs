namespace OctopusCommon.Interfaces;

public interface IDirectDebtQuote
{
    [JsonPropertyName("direct_debit_monthly")]
    IDirectDebitRateQuote? DirectDebitMonthly { get; set; }

    [JsonPropertyName("direct_debit_quarterly")]
    IDirectDebitRateQuote? DirectDebitQuarterly { get; set; }
}