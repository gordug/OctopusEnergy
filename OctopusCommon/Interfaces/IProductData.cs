namespace OctopusCommon.Interfaces;

public interface IProductData
{
    [JsonPropertyName("code")] string Code { get; set; }
    [JsonPropertyName("full_name")] string FullName { get; set; }
    [JsonPropertyName("display_name")] string DisplayName { get; set; }
    [JsonPropertyName("description")] string Description { get; set; }
    [JsonPropertyName("is_variable")] bool IsVariable { get; set; }
    [JsonPropertyName("is_green")] bool IsGreen { get; set; }
    [JsonPropertyName("is_tracker")] bool IsTracker { get; set; }
    [JsonPropertyName("is_prepay")] bool IsPrepay { get; set; }
    [JsonPropertyName("is_business")] bool IsBusiness { get; set; }
    [JsonPropertyName("is_restricted")] bool IsRestricted { get; set; }
    [JsonPropertyName("term")] int Term { get; set; }
    [JsonPropertyName("brand")] string Brand { get; set; }
    [JsonPropertyName("available_from")] DateTime AvailableFrom { get; set; }
    [JsonPropertyName("available_to")] DateTime? AvailableTo { get; set; }
    [JsonPropertyName("links")] ILink[] Links { get; set; }
}