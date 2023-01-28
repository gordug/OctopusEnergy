namespace OctopusCommon.Classes;

internal abstract class Tariffs : ITariffs
{
    [JsonPropertyName("_A")] public ITariff? TariffA { get; set; }
    [JsonPropertyName("_B")] public ITariff? TariffB { get; set; }
}