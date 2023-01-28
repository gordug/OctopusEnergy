namespace OctopusCommon.Classes;

internal abstract class DirectDebit : IDirectDebit
{
    [JsonPropertyName("code")] public string Code { get; set; }

    [JsonPropertyName("standard_unit_rate_exc_vat")]
    public float StandardUnitRateExcVat { get; set; }

    [JsonPropertyName("standard_unit_rate_inc_vat")]
    public float StandardUnitRateIncVat { get; set; }

    [JsonPropertyName("standing_charge_exc_vat")]
    public float StandingChargeExcVat { get; set; }

    [JsonPropertyName("standing_charge_inc_vat")]
    public float StandingChargeIncVat { get; set; }

    [JsonPropertyName("online_discount_exc_vat")]
    public int OnlineDiscountExcVat { get; set; }

    [JsonPropertyName("online_discount_inc_vat")]
    public int OnlineDiscountIncVat { get; set; }

    [JsonPropertyName("dual_fuel_discount_exc_vat")]
    public int DualFuelDiscountExcVat { get; set; }

    [JsonPropertyName("dual_fuel_discount_inc_vat")]
    public int DualFuelDiscountIncVat { get; set; }

    [JsonPropertyName("exit_fees_exc_vat")]
    public int ExitFeesExcVat { get; set; }

    [JsonPropertyName("exit_fees_inc_vat")]
    public int ExitFeesIncVat { get; set; }

    [JsonPropertyName("exit_fees_type")] public string ExitFeesType { get; set; }
    [JsonPropertyName("links")] public ILink[] Links { get; set; }
}