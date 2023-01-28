using System;
using System.Text.Json.Serialization;

namespace OctopusEnergy.Classes;

internal class ProductData
{
    [JsonPropertyName("code")] public string Code { get; set; }

    [JsonPropertyName("full_name")] public string FullName { get; set; }

    [JsonPropertyName("display_name")] public string DisplayName { get; set; }

    [JsonPropertyName("description")] public string Description { get; set; }

    [JsonPropertyName("is_variable")] public bool IsVariable { get; set; }

    [JsonPropertyName("is_green")] public bool IsGreen { get; set; }

    [JsonPropertyName("is_tracker")] public bool IsTracker { get; set; }

    [JsonPropertyName("is_prepay")] public bool IsPrepay { get; set; }

    [JsonPropertyName("is_business")] public bool IsBusiness { get; set; }

    [JsonPropertyName("is_restricted")] public bool IsRestricted { get; set; }

    [JsonPropertyName("term")] public int Term { get; set; }

    [JsonPropertyName("brand")] public string Brand { get; set; }

    [JsonPropertyName("available_from")] public DateTime AvailableFrom { get; set; }

    [JsonPropertyName("available_to")] public DateTime? AvailableTo { get; set; }

    [JsonPropertyName("links")] public Link[] Links { get; set; }
}