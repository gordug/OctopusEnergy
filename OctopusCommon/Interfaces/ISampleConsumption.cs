namespace OctopusCommon.Interfaces;

public interface ISampleConsumption
{
    [JsonPropertyName("electricity_single_rate")]
    IElectricitySingleRate ElectricitySingleRate { get; set; }

    [JsonPropertyName("electricity_dual_rate")]
    IElectricityDualRate ElectricityDualRate { get; set; }

    [JsonPropertyName("dual_fuel_single_rate")]
    IDualFuelSingleRate DualFuelSingleRate { get; set; }

    [JsonPropertyName("dual_fuel_dual_rate")]
    IDualFuelDualRate DualFuelDualRate { get; set; }
}