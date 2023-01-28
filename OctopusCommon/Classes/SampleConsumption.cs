namespace OctopusCommon.Classes;

internal abstract class SampleConsumption : ISampleConsumption
{
    [JsonPropertyName("electricity_single_rate")]
    public IElectricitySingleRate ElectricitySingleRate { get; set; }

    [JsonPropertyName("electricity_dual_rate")]
    public IElectricityDualRate ElectricityDualRate { get; set; }

    [JsonPropertyName("dual_fuel_single_rate")]
    public IDualFuelSingleRate DualFuelSingleRate { get; set; }

    [JsonPropertyName("dual_fuel_dual_rate")]
    public IDualFuelDualRate DualFuelDualRate { get; set; }
}