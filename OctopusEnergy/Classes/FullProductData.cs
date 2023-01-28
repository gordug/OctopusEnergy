using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace OctopusEnergy.Classes
{

    internal class FullProductData : ProductData
    {
        [JsonPropertyName("single_register_electricity_tariffs")]
        public SingleRegisterElectricityTariffs SingleRegisterElectricityTariffs { get; set; }
        [JsonPropertyName("dual_register_electricity_tariffs")]
        public DualRegisterElectricityTariffs DualRegisterElectricityTariffs { get; set; }
        [JsonPropertyName("single_register_gas_tariffs")]
        public SingleRegisterGasTariffs SingleRegisterGasTariffs { get; set; }
        [JsonPropertyName("sample_quotes")]
        public SampleQuotes SampleQuotes { get; set; }
        [JsonPropertyName("sample_consumption")]
        public SampleConsumption SampleConsumption { get; set; }
    }

    internal class SingleRegisterElectricityTariffs
    {
        [JsonPropertyName("_A")]
        public Tariff? TariffA { get; set; }
        [JsonPropertyName("_B")]
        public Tariff? TariffB { get; set; }
    }

    internal class Tariff
    {
        [JsonPropertyName("direct_debit_monthly")]
        public DirectDebit? DirectDebitMonthly { get; set; }
        [JsonPropertyName("direct_debit_quarterly")]
        public DirectDebit? DirectDebitQuarterly { get; set; }
    }

    internal class DirectDebit
    {
        public string code { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link[] links { get; set; }
    }

    internal class DualRegisterElectricityTariffs
    {
    }

    internal class SingleRegisterGasTariffs
    {
    }

    internal class SampleQuotes
    {
        public _A1 _A { get; set; }
        public _B1 _B { get; set; }
    }

    internal class _A1
    {
        public Direct_Debit_Monthly1 direct_debit_monthly { get; set; }
        public Direct_Debit_Quarterly1 direct_debit_quarterly { get; set; }
    }

    internal class Direct_Debit_Monthly1
    {
        public Electricity_Single_Rate electricity_single_rate { get; set; }
        public Electricity_Dual_Rate electricity_dual_rate { get; set; }
        public Dual_Fuel_Single_Rate dual_fuel_single_rate { get; set; }
        public Dual_Fuel_Dual_Rate dual_fuel_dual_rate { get; set; }
    }

    internal class Electricity_Single_Rate
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    internal class Electricity_Dual_Rate
    {
    }

    internal class Dual_Fuel_Single_Rate
    {
    }

    internal class Dual_Fuel_Dual_Rate
    {
    }

    internal class Direct_Debit_Quarterly1
    {
    }

    internal class _B1
    {
    }

    internal class SampleConsumption
    {
        public Electricity_Single_Rate1 electricity_single_rate { get; set; }
        public Electricity_Dual_Rate1 electricity_dual_rate { get; set; }
        public Dual_Fuel_Single_Rate1 dual_fuel_single_rate { get; set; }
        public Dual_Fuel_Dual_Rate1 dual_fuel_dual_rate { get; set; }
    }

    internal class Electricity_Single_Rate1
    {
        public int electricity_standard { get; set; }
    }

    internal class Electricity_Dual_Rate1
    {
        public int electricity_day { get; set; }
        public int electricity_night { get; set; }
    }

    internal class Dual_Fuel_Single_Rate1
    {
        public int electricity_standard { get; set; }
        public int gas_standard { get; set; }
    }

    internal class Dual_Fuel_Dual_Rate1
    {
        public int electricity_day { get; set; }
        public int electricity_night { get; set; }
        public int gas_standard { get; set; }
    }

    internal class Link1
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

}
