using static AmperaHome.WebApiClient.ApiClients.Monitor.Battery.Models.GetBatteryListResponse;

namespace AmperaHome.WebApiClient.ApiClients.Monitor.Battery.Models;

public class GetBatteryListResponse : BaseList<ListBean>
{
    public class ListBean
    {
        [JsonPropertyName("batCapacity")] 
        public int BatCapacity { get; set; } = default!;

        [JsonPropertyName("batInstallType")] 
        public int BatInstallType { get; set; } = default!;

        [JsonPropertyName("batModel")]
        public string BatModel { get; set; } = default!;

        [JsonPropertyName("batModule")]
        public string BatModule { get; set; } = default!;

        [JsonPropertyName("batSn")]
        public string BatSn { get; set; } = default!;

        [JsonPropertyName("batType")]
        public int BatType { get; set; } = default!;

        [JsonPropertyName("batteryType")]
        public int BatteryType { get; set; } = default!;

        [JsonPropertyName("bmsSn")]
        public string BmsSn { get; set; } = default!;

        [JsonPropertyName("bmsSoftwareVersion")]
        public string BmsSoftwareVersion { get; set; } = default!;

        [JsonPropertyName("isHistory")]
        public int IsHistory { get; set; } = default!;


        /// <summary>
        /// 3 = Standby
        /// </summary>
        [JsonPropertyName("runningState")] 
        public int RunningState { get; set; } = default!;

        [JsonPropertyName("warrantyEndTime")]
        public string WarrantyEndTime { get; set; } = default!;

        [JsonPropertyName("warrantyStartTime")]
        public string WarrantyStartTime { get; set; } = default!;
    }
}
