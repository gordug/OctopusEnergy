namespace OctopusCommon.Classes;

internal abstract class Link : ILink
{
    [JsonPropertyName("href")] public string Href { get; set; }

    [JsonPropertyName("method")] public string Method { get; set; }

    [JsonPropertyName("rel")] public string Rel { get; set; }
}