namespace OctopusCommon.Classes;

internal abstract class Tariff : ITariff
{
    [JsonPropertyName("direct_debit_monthly")]
    public IDirectDebit? DirectDebitMonthly { get; set; }

    [JsonPropertyName("direct_debit_quarterly")]
    public IDirectDebit? DirectDebitQuarterly { get; set; }
}