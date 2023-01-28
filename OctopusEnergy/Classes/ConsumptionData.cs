using System;
using System.Text.Json.Serialization;

namespace OctopusEnergy.Classes;

internal class ConsumptionData
{
    [JsonPropertyName("consumption")] public float Consumption { get; set; }

    [JsonPropertyName("interval_start")] public DateTime IntervalStart { get; set; }

    [JsonPropertyName("interval_end")] public DateTime IntervalEnd { get; set; }
}