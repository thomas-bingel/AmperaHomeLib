namespace AmperaHome.WebApiClient.ApiClients.Monitor.Home.Models;

public class GetSinglePlantStatisticsDataResponse
{

    [JsonPropertyName("batEnergyPercent")]
    public int BatEnergyPercent { get; set; }

    [JsonPropertyName("batteryWorkTime")]
    public int BatteryWorkTime { get; set; }

    [JsonPropertyName("buyEnergy")]
    public int BuyEnergy { get; set; }

    [JsonPropertyName("co2UnitOfWeight")]
    public string Co2UnitOfWeight { get; set; } = default!;

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = default!;

    [JsonPropertyName("deviceSn")]
    public string DeviceSn { get; set; } = default!;

    [JsonPropertyName("deviceSnList")]
    public List<string> DeviceSnList { get; set; } = [];

    [JsonPropertyName("deviceStatus")]
    public int DeviceStatus { get; set; }

    [JsonPropertyName("enableLoad")]
    public int EnableLoad { get; set; }

    [JsonPropertyName("enablePowerOffGuard")]
    public int EnablePowerOffGuard { get; set; }

    [JsonPropertyName("exchangeRateForMoney")]
    public double ExchangeRateForMoney { get; set; }

    [JsonPropertyName("incomeLastMonth")]
    public double IncomeLastMonth { get; set; }

    [JsonPropertyName("incomeMonth")]
    public double IncomeMonth { get; set; }

    [JsonPropertyName("incomeToday")]
    public double IncomeToday { get; set; }

    [JsonPropertyName("incomeTotal")]
    public double IncomeTotal { get; set; }

    [JsonPropertyName("incomeYear")]
    public double IncomeYear { get; set; }

    [JsonPropertyName("isHighVolt")]
    public int IsHighVolt { get; set; }

    [JsonPropertyName("lastDayLoadEnergy")]
    public int LastDayLoadEnergy { get; set; }

    [JsonPropertyName("lastDayPvEnergy")]
    public int LastDayPvEnergy { get; set; }

    [JsonPropertyName("lastMonthLoadEnergy")]
    public int LastMonthLoadEnergy { get; set; }

    [JsonPropertyName("lastMonthPvEnergy")]
    public int LastMonthPvEnergy { get; set; }

    [JsonPropertyName("lastYearLoadEnergy")]
    public int LastYearLoadEnergy { get; set; }

    [JsonPropertyName("lastYearPvEnergy")]
    public int LastYearPvEnergy { get; set; }

    [JsonPropertyName("loadBuyRate")]
    public int LoadBuyRate { get; set; }

    [JsonPropertyName("loadSelfConsumedEnergy")]
    public int LoadSelfConsumedEnergy { get; set; }

    [JsonPropertyName("loadSelfConsumedRate")]
    public int LoadSelfConsumedRate { get; set; }

    [JsonPropertyName("moduleSnList")]
    public List<object> ModuleSnList { get; set; } = [];

    [JsonPropertyName("monthLoadEnergy")]
    public double MonthLoadEnergy { get; set; }

    [JsonPropertyName("monthPvEnergy")]
    public double MonthPvEnergy { get; set; }

    [JsonPropertyName("plantName")]
    public string PlantName { get; set; } = default!;

    [JsonPropertyName("plantUid")]
    public string PlantUid { get; set; } = default!;

    [JsonPropertyName("powerNow")]
    public int PowerNow { get; set; }

    [JsonPropertyName("powerOffGuardStatus")]
    public int PowerOffGuardStatus { get; set; }

    [JsonPropertyName("pvSelfConsumedEnergy")]
    public int PvSelfConsumedEnergy { get; set; }

    [JsonPropertyName("pvSelfConsumedRate")]
    public int PvSelfConsumedRate { get; set; }

    [JsonPropertyName("pvSellRate")]
    public int PvSellRate { get; set; }

    [JsonPropertyName("sellEnergy")]
    public int SellEnergy { get; set; }

    [JsonPropertyName("systemPower")]
    public double SystemPower { get; set; }

    [JsonPropertyName("todayBuyEnergy")]
    public double TodayBuyEnergy { get; set; }

    [JsonPropertyName("todayChargeEnergy")]
    public double TodayChargeEnergy { get; set; }

    [JsonPropertyName("todayDisChargeEnergy")]
    public double TodayDisChargeEnergy { get; set; }

    [JsonPropertyName("todayLoadEnergy")]
    public double TodayLoadEnergy { get; set; }

    [JsonPropertyName("todayPlantTreeNum")]
    public double TodayPlantTreeNum { get; set; }

    [JsonPropertyName("todayPvEnergy")]
    public double TodayPvEnergy { get; set; }

    [JsonPropertyName("todayReduceCo2")]
    public double TodayReduceCo2 { get; set; }

    [JsonPropertyName("todaySellEnergy")]
    public double TodaySellEnergy { get; set; }

    [JsonPropertyName("totalBuyEnergy")]
    public double TotalBuyEnergy { get; set; }

    [JsonPropertyName("totalChargeEnergy")]
    public double TotalChargeEnergy { get; set; }

    [JsonPropertyName("totalCoal")]
    public double TotalCoal { get; set; }

    [JsonPropertyName("totalDisChargeEnergy")]
    public double TotalDisChargeEnergy { get; set; }

    [JsonPropertyName("totalLoadEnergy")]
    public double TotalLoadEnergy { get; set; }

    [JsonPropertyName("totalPlantTreeNum")]
    public double TotalPlantTreeNum { get; set; }

    [JsonPropertyName("totalPvEnergy")]
    public double TotalPvEnergy { get; set; }

    [JsonPropertyName("totalReduceCo2")]
    public double TotalReduceCo2 { get; set; }

    [JsonPropertyName("totalSellEnergy")]
    public double TotalSellEnergy { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("unitOfCapacity")]
    public string UnitOfCapacity { get; set; } = default!;

    [JsonPropertyName("updateDate")]
    public object UpdateDate { get; set; } = default!;

    [JsonPropertyName("usableBatCapacity")]
    public int UsableBatCapacity { get; set; }

    [JsonPropertyName("yearCoal")]
    public double YearCoal { get; set; }

    [JsonPropertyName("yearLoadEnergy")]
    public double YearLoadEnergy { get; set; }

    [JsonPropertyName("yearPlantTreeNum")]
    public double YearPlantTreeNum { get; set; }

    [JsonPropertyName("yearPvEnergy")]
    public double YearPvEnergy { get; set; }

    [JsonPropertyName("yearReduceCo2")]
    public double YearReduceCo2 { get; set; }
}
