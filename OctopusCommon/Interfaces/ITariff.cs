namespace OctopusCommon.Interfaces;

public interface ITariff
{
    [JsonPropertyName("direct_debit_monthly")]
    IDirectDebit? DirectDebitMonthly { get; set; }

    [JsonPropertyName("direct_debit_quarterly")]
    IDirectDebit? DirectDebitQuarterly { get; set; }
}