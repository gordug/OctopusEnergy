namespace OctopusCommon.Classes;

internal class Consumption : IConsumption
{
    [JsonPropertyName("count")] public int Count { get; set; }

    [JsonPropertyName("next")] public object Next { get; set; }

    [JsonPropertyName("previous")] public object Previous { get; set; }

    [JsonPropertyName("results")] public IConsumptionData[] ConsumptionData { get; set; }
}