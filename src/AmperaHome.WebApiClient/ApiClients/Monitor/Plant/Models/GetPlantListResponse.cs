using static AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Models.GetPlantListResponse;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Plant.Models;

public class GetPlantListResponse : BaseList<PlantBean>
{
    public class PlantBean
    {
        [JsonPropertyName("address")]
        public string Address { get; set; } = default!;

        [JsonPropertyName("createDate")]
        public string CreateDate { get; set; } = default!;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;

        [JsonPropertyName("currencyName")]
        public string CurrencyName { get; set; } = default!;

        [JsonPropertyName("batteryQuantity")]
        public int BatteryQuantity { get; set; } = default!;

        [JsonPropertyName("enableEdit")]
        public int EnableEdit { get; set; } = default!;

        [JsonPropertyName("enableDelete")]
        public int EnableDelete { get; set; } = default!;

        [JsonPropertyName("enableMovePlant")]
        public int EnableMovePlant { get; set; } = default!;

        [JsonPropertyName("enableNavigation")]
        public int EnableNavigation { get; set; } = default!;

        [JsonPropertyName("enablePlantMap")]
        public int EnablePlantMap { get; set; } = default!;

        [JsonPropertyName("enableRemote")]
        public int EnableRemote { get; set; } = default!;

        [JsonPropertyName("inverterQuantity")]
        public int InverterQuantity { get; set; } = default!;

        [JsonPropertyName("isFavorite")]
        public int IsFavorite { get; set; } = default!;

        [JsonPropertyName("isInstallCharger")]
        public int IsInstallCharger { get; set; } = default!;

        [JsonPropertyName("isInstallMeter")]
        public int IsInstallMeter { get; set; } = default!;

        [JsonPropertyName("isInstallWisdomDevice")]
        public int IsInstallWisdomDevice { get; set; } = default!;

        [JsonPropertyName("isOnline")]
        public string IsOnline { get; set; } = default!;

        [JsonPropertyName("isShared")]
        public int IsShared { get; set; } = default!;

        [JsonPropertyName("isTop")]
        public int IsTop { get; set; } = default!;

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; } = default!;

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; } = default!;

        [JsonPropertyName("plantAccessNature")]
        public int PlantAccessNature { get; set; } = default!;

        [JsonPropertyName("plantName")]
        public string PlantName { get; set; } = default!;

        [JsonPropertyName("plantNo")]
        public string PlantNo { get; set; } = default!;
        
        [JsonPropertyName("plantUid")]
        public string PlantUid { get; set; } = default!;

        [JsonPropertyName("powerNow")]
        public double PowerNow { get; set; } = default!;

        [JsonPropertyName("projectPic")]
        public string ProjectPic { get; set; } = default!;

        [JsonPropertyName("runningState")]
        public int RunningState { get; set; } = default!;

        [JsonPropertyName("systemPower")]
        public double SystemPower { get; set; } = default!;

        [JsonPropertyName("todayEnergy")]
        public double TodayEnergy { get; set; } = default!;

        [JsonPropertyName("totalEnergy")]
        public double TotalEnergy { get; set; } = default!;

        [JsonPropertyName("type")]
        public int Type { get; set; } = default!;

        [JsonPropertyName("visitorQuantity")]
        public int VisitorQuantity { get; set; } = default!;

        [JsonPropertyName("wisdomDeviceSn")]
        public string WisdomDeviceSn { get; set; } = default!;
    }
}
