namespace OctopusCommon.Interfaces;

public interface IConsumptionData
{
    [JsonPropertyName("consumption")] float Consumption { get; set; }
    [JsonPropertyName("interval_start")] DateTime IntervalStart { get; set; }
    [JsonPropertyName("interval_end")] DateTime IntervalEnd { get; set; }
}