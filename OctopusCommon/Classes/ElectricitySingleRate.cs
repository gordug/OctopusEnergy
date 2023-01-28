namespace OctopusCommon.Classes;

internal class ElectricitySingleRate : IElectricitySingleRate
{
    [JsonPropertyName("electricity_standard")]
    public int ElectricityStandard { get; set; }
}