namespace OctopusCommon.Interfaces;

public interface ILink
{
    [JsonPropertyName("href")] string Href { get; set; }
    [JsonPropertyName("method")] string Method { get; set; }
    [JsonPropertyName("rel")] string Rel { get; set; }
}