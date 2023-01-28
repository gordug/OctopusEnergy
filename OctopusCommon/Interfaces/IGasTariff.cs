namespace OctopusCommon.Interfaces;

public interface IGasTariff
{
    [JsonPropertyName("gas_standard")] int GasStandard { get; set; }
}