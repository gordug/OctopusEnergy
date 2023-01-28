namespace OctopusCommon.Classes;

internal class ConsumptionData : IConsumptionData
{
    [JsonPropertyName("consumption")] public float Consumption { get; set; }

    [JsonPropertyName("interval_start")] public DateTime IntervalStart { get; set; }

    [JsonPropertyName("interval_end")] public DateTime IntervalEnd { get; set; }
}