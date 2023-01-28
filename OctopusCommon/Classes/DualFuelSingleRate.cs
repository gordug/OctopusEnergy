namespace OctopusCommon.Classes;

internal abstract class DualFuelSingleRate : ElectricitySingleRate, IDualFuelSingleRate
{
    [JsonPropertyName("gas_standard")] public int GasStandard { get; set; }
}