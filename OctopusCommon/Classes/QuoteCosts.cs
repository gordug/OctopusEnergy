namespace OctopusCommon.Classes;

internal abstract class QuoteCosts : IQuoteCosts
{
    [JsonPropertyName("annual_cost_inc_vat")]
    public int AnnualCostIncVat { get; set; }

    [JsonPropertyName("annual_cost_exc_vat")]
    public int AnnualCostExcVat { get; set; }
}