namespace OctopusCommon.Classes;

internal class Products : IProducts
{
    [JsonPropertyName("count")] public int Count { get; set; }

    [JsonPropertyName("next")] public string Next { get; set; }

    [JsonPropertyName("previous")] public object Previous { get; set; }

    [JsonPropertyName("results")] public IProductData[] ProductData { get; set; }
}