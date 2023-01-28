namespace OctopusCommon.Interfaces;

public interface IDirectDebitRateQuote
{
    [JsonPropertyName("electricity_single_rate")]
    IQuoteCosts? ElectricitySingleRate { get; set; }

    [JsonPropertyName("electricity_dual_rate")]
    IQuoteCosts? ElectricityDualRate { get; set; }

    [JsonPropertyName("dual_fuel_single_rate")]
    IQuoteCosts? DualFuelSingleRate { get; set; }

    [JsonPropertyName("dual_fuel_dual_rate")]
    IQuoteCosts? DualFuelDualRate { get; set; }
}