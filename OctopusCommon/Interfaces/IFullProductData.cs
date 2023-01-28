namespace OctopusCommon.Interfaces;

public interface IFullProductData : IProductData
{
    [JsonPropertyName("single_register_electricity_tariffs")]
    ITariffs Tariffs { get; set; }

    [JsonPropertyName("dual_register_electricity_tariffs")]
    ITariffs DualRegisterElectricityTariffs { get; set; }

    [JsonPropertyName("single_register_gas_tariffs")]
    ITariffs SingleRegisterGasTariffs { get; set; }

    [JsonPropertyName("sample_quotes")] ISampleQuotes SampleQuotes { get; set; }

    [JsonPropertyName("sample_consumption")]
    ISampleConsumption SampleConsumption { get; set; }
}