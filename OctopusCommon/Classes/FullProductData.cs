namespace OctopusCommon.Classes;

internal class FullProductData : ProductData, IFullProductData
{
    [JsonPropertyName("single_register_electricity_tariffs")]
    public ITariffs Tariffs { get; set; }

    [JsonPropertyName("dual_register_electricity_tariffs")]
    public ITariffs DualRegisterElectricityTariffs { get; set; }

    [JsonPropertyName("single_register_gas_tariffs")]
    public ITariffs SingleRegisterGasTariffs { get; set; }

    [JsonPropertyName("sample_quotes")] public ISampleQuotes SampleQuotes { get; set; }

    [JsonPropertyName("sample_consumption")]
    public ISampleConsumption SampleConsumption { get; set; }
}