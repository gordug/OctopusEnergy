namespace OctopusCommon.Interfaces;

public interface IConsumption
{
    [JsonPropertyName("count")] int Count { get; set; }
    [JsonPropertyName("next")] object Next { get; set; }
    [JsonPropertyName("previous")] object Previous { get; set; }
    [JsonPropertyName("results")] IConsumptionData[] ConsumptionData { get; set; }
}