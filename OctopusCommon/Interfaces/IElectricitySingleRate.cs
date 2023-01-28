namespace OctopusCommon.Interfaces;

public interface IElectricitySingleRate
{
    [JsonPropertyName("electricity_standard")]
    int ElectricityStandard { get; set; }
}