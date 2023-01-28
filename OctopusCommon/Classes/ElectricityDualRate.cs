namespace OctopusCommon.Classes;

internal abstract class ElectricityDualRate : IElectricityDualRate
{
    [JsonPropertyName("electricity_day")] public int ElectricityDay { get; set; }

    [JsonPropertyName("electricity_night")]
    public int ElectricityNight { get; set; }
}