using AmperaHome.ConsoleApp;
using AmperaHome.WebApiClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Globalization;

var cultureInfo = new CultureInfo("de-DE");

AmperaWebApiClient client = BuildAmperaWebApiClient();

// List all plants
Console.WriteLine("Plants:");
var plants = await client.Monitor.Plants.List();
foreach (var plant in plants.List)
{
    Console.WriteLine(string.Format("\tPlant UID: {0}", plant.PlantUid));

    var plantDetails = await client.Monitor.Plants[plant.PlantUid].Details();
    Console.WriteLine(string.Format("\tPlant Name: {0}", plantDetails.PlantName));
}


// List all devices
Console.WriteLine("Devices:");
var devices = await client.Monitor.Devices.List();
foreach (var device in devices.List)
{
    Console.WriteLine(string.Format("\tDevice Serial Number: {0}", device.DeviceSn));
}


// List all batteries
Console.WriteLine("Batteries:");
var batteries = await client.Monitor.Batteries.List();
foreach (var battery in batteries.List)
{
    Console.WriteLine(string.Format("\tBattery Serial Number: {0}",
        battery.BatSn));
}


// Consumption

var deviceEnergyFlowData = await client.Monitor.Home.GetDeviceEnergyFlowData(
    plantUid: plants.List[0].PlantUid,
    deviceSn: devices.List[0].DeviceSn);

var selfUseEnergyData = await client.Monitor.Plants[plants.List[0].PlantUid].Chart.GetSelfUseEnergyDataByDay(DateTime.Now);
// or
//var selfUseEnergyData = await client.Monitor.Devices[devices.List[0].DeviceSn].Chart.GetSelfUseEnergyDataByDay(DateTime.Now);

Console.WriteLine($"Aktuell werden {(deviceEnergyFlowData.EkdTotalLoadPowerwatt / 1000.0).ToString("0.##", cultureInfo.NumberFormat)} Kilowatt verbraucht.");
Console.WriteLine($"Die aktuelle Autarkie beträgt {(selfUseEnergyData.LoadSelfConsumedRate * 100.0).ToString("0.00", cultureInfo.NumberFormat)} Prozent.");
Console.WriteLine($"Es wurden {(selfUseEnergyData.PvEnergy).ToString("0.00", cultureInfo.NumberFormat)} Kilowattstunden erzeugt.");

var batPower = deviceEnergyFlowData.BatPower / 1000.0;
var message = $"Der Speicher ist zu {deviceEnergyFlowData.BatEnergyPercent.ToString("0.##", cultureInfo.NumberFormat)} Prozent geladen";
switch (deviceEnergyFlowData.BatteryDirection)
{
    case 0:
        message += ".";
        break;
    case 1:
        message += $" und wird mit {batPower.ToString("0.##", cultureInfo.NumberFormat)} Kilowatt entladen.";
        break;
    case -1:
        message += $" und wird mit {batPower.ToString("0.##", cultureInfo.NumberFormat)} Kilowatt geladen.";
        break;
}
Console.WriteLine(message);


var currentPvPowerGenerationInKiloWatt = deviceEnergyFlowData.TotalPvPower / 1000.0;
if (currentPvPowerGenerationInKiloWatt > 0)
{
    message = $"Aktuell werden {currentPvPowerGenerationInKiloWatt.ToString("0.##", cultureInfo.NumberFormat)} Kilowatt erzeugt.";
}
else
{
    message = "Aktuell wird kein Strom erzeugt.";
}
Console.WriteLine(message);


var userInfo = await client.Sys.User.GetUserInfo();
Console.WriteLine($"User: {userInfo.LoginName}");


var powerAnalysisDada = await client.Monitor.Plants[plants.List[0].PlantUid].Chart.GetStorePowerAnalysisData(devices.List[0].DeviceSn, DateTime.Now);
Console.WriteLine($"Power analysis: {System.Text.Json.JsonSerializer.Serialize(powerAnalysisDada)}");



static AmperaWebApiClient BuildAmperaWebApiClient()
{
    var configuration = MyConfigurationProvider.GetConfiguration();

    var services = new ServiceCollection();

    services.AddLogging(logging =>
    {
        logging.AddConfiguration(configuration.GetSection("Logging"));
        logging.AddConsole();
    });

    services.AddAmperaHome(options =>
    {
        configuration.GetSection("AmperaHome").Bind(options);
    });

    var sp = services.BuildServiceProvider();

    var client = sp.GetRequiredService<AmperaWebApiClient>();
    return client;
}

