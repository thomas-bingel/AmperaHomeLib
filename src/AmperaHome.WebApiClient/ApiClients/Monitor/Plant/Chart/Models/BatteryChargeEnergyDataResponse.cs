namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Chart.Models;

public class BatteryChargeEnergyData
{
    [JsonPropertyName("disChargeToLoadEnergy")]
    public double DisChargeToLoadEnergy { get; set; } = default!;

    [JsonPropertyName("disChargeToLoadRate")]
    public double DisChargeToLoadRate { get; set; } = default!;

    [JsonPropertyName("dischargeToGridEnergy")]
    public double DischargeToGridEnergy { get; set; } = default!;

    [JsonPropertyName("dischargeToGridRate")]
    public double DischargeToGridRate { get; set; } = default!;

    [JsonPropertyName("energyUnit")]
    public string EnergyUnit { get; set; } = default!;

    [JsonPropertyName("gridChargeEnergy")]
    public double GridChargeEnergy { get; set; } = default!;

    [JsonPropertyName("gridChargeRate")]
    public double GridChargeRate { get; set; } = default!;

    [JsonPropertyName("pvChargeEnergy")]
    public double PvChargeEnergy { get; set; } = default!;

    [JsonPropertyName("pvChargeRate")]
    public double PvChargeRate { get; set; } = default!;

    [JsonPropertyName("totalChargeEnergy")]
    public double TotalChargeEnergy { get; set; } = default!;

    [JsonPropertyName("totalDischargeEnergy")]
    public double TotalDischargeEnergy { get; set; } = default!;

}
