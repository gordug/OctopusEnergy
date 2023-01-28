namespace OctopusCommon.Classes;

internal abstract class DualFuelDualRate : ElectricityDualRate, IDualFuelDualRate
{
    [JsonPropertyName("gas_standard")] public int GasStandard { get; set; }
}