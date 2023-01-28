namespace OctopusCommon.Interfaces;

public interface IDirectDebit
{
    [JsonPropertyName("code")] string Code { get; set; }

    [JsonPropertyName("standard_unit_rate_exc_vat")]
    float StandardUnitRateExcVat { get; set; }

    [JsonPropertyName("standard_unit_rate_inc_vat")]
    float StandardUnitRateIncVat { get; set; }

    [JsonPropertyName("standing_charge_exc_vat")]
    float StandingChargeExcVat { get; set; }

    [JsonPropertyName("standing_charge_inc_vat")]
    float StandingChargeIncVat { get; set; }

    [JsonPropertyName("online_discount_exc_vat")]
    int OnlineDiscountExcVat { get; set; }

    [JsonPropertyName("online_discount_inc_vat")]
    int OnlineDiscountIncVat { get; set; }

    [JsonPropertyName("dual_fuel_discount_exc_vat")]
    int DualFuelDiscountExcVat { get; set; }

    [JsonPropertyName("dual_fuel_discount_inc_vat")]
    int DualFuelDiscountIncVat { get; set; }

    [JsonPropertyName("exit_fees_exc_vat")]
    int ExitFeesExcVat { get; set; }

    [JsonPropertyName("exit_fees_inc_vat")]
    int ExitFeesIncVat { get; set; }

    [JsonPropertyName("exit_fees_type")] string ExitFeesType { get; set; }
    [JsonPropertyName("links")] ILink[] Links { get; set; }
}