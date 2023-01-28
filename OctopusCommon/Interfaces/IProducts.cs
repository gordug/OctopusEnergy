namespace OctopusCommon.Interfaces;

public interface IProducts
{
    [JsonPropertyName("count")] int Count { get; set; }
    [JsonPropertyName("next")] string Next { get; set; }
    [JsonPropertyName("previous")] object Previous { get; set; }
    [JsonPropertyName("results")] IProductData[] ProductData { get; set; }
}