namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Models;

public class GetPlantDetailResponse
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = default!;

    [JsonPropertyName("batteryQuantity")]
    public int BatteryQuantity { get; set; } = default!;

    [JsonPropertyName("createDate")]
    public string CreateDate { get; set; } = default!;

    [JsonPropertyName("enableEdit")]
    public int EnableEdit { get; set; } = default!;

    [JsonPropertyName("enableInstallerEdit")]
    public string EnableInstallerEdit { get; set; } = default!;

    [JsonPropertyName("enableOwnerEdit")]
    public string EnableOwnerEdit { get; set; } = default!;

    [JsonPropertyName("enableShare")]
    public string EnableShare { get; set; } = default!;

    [JsonPropertyName("informationPercentage")]
    public int InformationPercentage { get; set; } = default!;

    [JsonPropertyName("installerOfficeName")]
    public string InstallerOfficeName { get; set; } = default!;

    [JsonPropertyName("installerOperatorEmail")]
    public string InstallerOperatorEmail { get; set; } = default!;

    [JsonPropertyName("installerOperatorName")]
    public string InstallerOperatorName { get; set; } = default!;

    [JsonPropertyName("installerOperatorTel")]
    public string InstallerOperatorTel { get; set; } = default!;

    [JsonPropertyName("inverterQuantity")]
    public int InverterQuantity { get; set; } = default!;

    [JsonPropertyName("ownerEmail")]
    public string OwnerEmail { get; set; } = default!;

    [JsonPropertyName("ownerName")]
    public string OwnerName { get; set; } = default!;

    [JsonPropertyName("ownerPhone")]
    public string OwnerPhone { get; set; } = default!;

    [JsonPropertyName("plantName")]
    public string PlantName { get; set; } = default!;

    [JsonPropertyName("plantNo")] 
    public string PlantNo { get; set; } = default!;
    
    [JsonPropertyName("plantUid")] 
    public string PlantUid { get; set; } = default!;

    [JsonPropertyName("projectPic")]
    public string ProjectPic { get; set; } = default!;

    [JsonPropertyName("roleType")]
    public string RoleType { get; set; } = default!;

    [JsonPropertyName("systemPower")]
    public double SystemPower { get; set; } = default!;

    [JsonPropertyName("visitorQuantity")]
    public int VisitorQuantity { get; set; } = default!;
}
