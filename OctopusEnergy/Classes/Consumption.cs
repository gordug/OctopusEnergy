using System.Text.Json.Serialization;

namespace OctopusEnergy.Classes;

internal class Consumption
{
    [JsonPropertyName("count")] public int Count { get; set; }

    [JsonPropertyName("next")] public object Next { get; set; }

    [JsonPropertyName("previous")] public object Previous { get; set; }

    [JsonPropertyName("results")] public ConsumptionData[] ConsumptionData { get; set; }
}