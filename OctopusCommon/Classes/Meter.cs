namespace OctopusCommon.Classes;

internal class Meter : IMeter
{
    [JsonPropertyName("gsp")] public string Gsp { get; set; }

    [JsonPropertyName("mpan")] public string Mpan { get; set; }

    [JsonPropertyName("profile_class")] public int ProfileClass { get; set; }
}