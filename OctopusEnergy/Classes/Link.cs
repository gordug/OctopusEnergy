using System.Text.Json.Serialization;

namespace OctopusEnergy.Classes;

internal class Link
{
    [JsonPropertyName("href")] public string Href { get; set; }

    [JsonPropertyName("method")] public string Method { get; set; }

    [JsonPropertyName("rel")] public string Rel { get; set; }
}