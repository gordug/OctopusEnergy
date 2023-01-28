using System.Text.Json.Serialization;

namespace OctopusEnergy.Classes;

internal class Products
{
    [JsonPropertyName("count")] public int Count { get; set; }

    [JsonPropertyName("next")] public string Next { get; set; }

    [JsonPropertyName("previous")] public object Previous { get; set; }

    [JsonPropertyName("results")] public ProductData[] ProductData { get; set; }
}