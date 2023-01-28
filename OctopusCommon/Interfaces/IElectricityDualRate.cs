namespace OctopusCommon.Interfaces;

public interface IElectricityDualRate
{
    [JsonPropertyName("electricity_day")] 
    int ElectricityDay { get; set; }

    [JsonPropertyName("electricity_night")]
    int ElectricityNight { get; set; }
}