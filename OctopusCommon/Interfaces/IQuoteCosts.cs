namespace OctopusCommon.Interfaces;

public interface IQuoteCosts
{
    [JsonPropertyName("annual_cost_inc_vat")]
    int AnnualCostIncVat { get; set; }

    [JsonPropertyName("annual_cost_exc_vat")]
    int AnnualCostExcVat { get; set; }
}