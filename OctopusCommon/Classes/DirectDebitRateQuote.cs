namespace OctopusCommon.Classes;

internal abstract class DirectDebitRateQuote : IDirectDebitRateQuote
{
    [JsonPropertyName("annual_cost_inc_vat")]
    public IQuoteCosts? ElectricitySingleRate { get; set; }

    [JsonPropertyName("electricity_dual_rate")]
    public IQuoteCosts? ElectricityDualRate { get; set; }

    [JsonPropertyName("dual_fuel_single_rate")]
    public IQuoteCosts? DualFuelSingleRate { get; set; }

    [JsonPropertyName("dual_fuel_dual_rate")]
    public IQuoteCosts? DualFuelDualRate { get; set; }
}