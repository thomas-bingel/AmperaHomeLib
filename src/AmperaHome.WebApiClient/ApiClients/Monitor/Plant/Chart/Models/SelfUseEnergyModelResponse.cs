namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;

public class SelfUseEnergyModel
{

    [JsonPropertyName("buyEnergy")]
    public double BuyEnergy { get; set; }

    [JsonPropertyName("chargeEnergy")]
    public double ChargeEnergy { get; set; }

    [JsonPropertyName("dischargeEnergy")]
    public double DischargeEnergy { get; set; }

    [JsonPropertyName("ekdLoadEnergy")]
    public double EkdLoadEnergy { get; set; }

    [JsonPropertyName("energyUnit")]
    public string EnergyUnit { get; set; } = default!;

    [JsonPropertyName("loadBuyRate")]
    public double LoadBuyRate { get; set; }

    [JsonPropertyName("loadEnergy")]
    public double LoadEnergy { get; set; }

    [JsonPropertyName("loadSelfConsumedEnergy")]
    public double LoadSelfConsumedEnergy { get; set; }


    /// <summary>
    /// Autarkie
    /// </summary>
    [JsonPropertyName("loadSelfConsumedRate")]
    public double LoadSelfConsumedRate { get; set; }

    [JsonPropertyName("pvEnergy")]
    public double PvEnergy { get; set; }

    [JsonPropertyName("pvSelfConsumedEnergy")]
    public double PvSelfConsumedEnergy { get; set; }

    [JsonPropertyName("pvSelfConsumedRate")]
    public double PvSelfConsumedRate { get; set; }

    [JsonPropertyName("pvSellRate")]
    public double PvSellRate { get; set; }

    [JsonPropertyName("sellEnergy")]
    public double SellEnergy { get; set; }
}
