namespace OctopusCommon.Interfaces;

public interface ITariffs
{
    [JsonPropertyName("_A")] ITariff? TariffA { get; set; }
    [JsonPropertyName("_B")] ITariff? TariffB { get; set; }
}