using static AmperaHome.WebApiClient.ApiClients.Monitor.Device.Models.GetInverterListResponse;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Device.Models;

public class GetInverterListResponse : BaseList<InverterBean>
{
    public class InverterBean
    {
        [JsonPropertyName("aliases")]
        public string Aliases { get; set; } = default!;

        [JsonPropertyName("batEnergyPercent")]
        public double BatEnergyPercent { get; set; } = default!;

        [JsonPropertyName("batteryDirection")]
        public int BatteryDirection { get; set; } = default!;

        [JsonPropertyName("createDate")]
        public string CreateDate { get; set; } = default!;
        
        [JsonPropertyName("devicePic")]
        public string DevicePic { get; set; } = default!;

        [JsonPropertyName("deviceSn")]
        public string DeviceSn { get; set; } = default!;
        
        [JsonPropertyName("deviceStatus")]
        public string DeviceStatus { get; set; } = default!;
        
        [JsonPropertyName("enableDelete")]
        public int EnableDelete { get; set; } = default!;
        
        [JsonPropertyName("enableEdit")]
        public int EnableEdit { get; set; } = default!;
        
        [JsonPropertyName("enableRemote")]
        public int EnableRemote { get; set; } = default!;

        [JsonPropertyName("powerNow")]
        public double PowerNow { get; set; } = default!;

        [JsonPropertyName("runningState")]
        public int RunningState { get; set; } = default!;

        [JsonPropertyName("solarPower")]
        public double SolarPower { get; set; } = default!;

        [JsonPropertyName("todayEnergy")]
        public double TodayEnergy { get; set; } = default!;

        [JsonPropertyName("totalEnergy")]
        public double TotalEnergy { get; set; } = default!;

        [JsonPropertyName("type")]
        public int Type { get; set; } = default!;

        [JsonPropertyName("warrantyEndTime")]
        public string WarrantyEndTime { get; set; } = default!;
    }
}
