namespace OctopusCommon.Interfaces;

public interface IMeter
{
    [JsonPropertyName("gsp")] string Gsp { get; set; }
    [JsonPropertyName("mpan")] string Mpan { get; set; }
    [JsonPropertyName("profile_class")] int ProfileClass { get; set; }
}