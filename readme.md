# Ampera Home Web API Library - Photovoltaik - Energiekonzepte Deutschland (EKD)

A C# library to consume the Ampera Home web API.

The API allows to list plants, devices, batteries and to get the current status of the system as well as statistics.

There is no official documentation available. The library is based on reverse engineering.

A sample console application is included to show how to use the library.


## Usage

Set Username and Password in user secrets or appsettings.json
```json
{
  "AmperaHome": {
    "Username": "xxx",
    "Password": "xxx"
  }
}
```

```csharp
var services = new ServiceCollection();
services.AddAmperaHome(options =>
{
    configuration.GetSection("AmperaHome").Bind(options);
});

var sp = services.BuildServiceProvider();

var client = sp.GetRequiredService<AmperaWebApiClient>();
var plants = await client.Monitor.Plants.List();
var devices = await client.Monitor.Devices.List();

var plantDetails = await client.Monitor.Plants["PlantUid"].Details();
```


Console Output:

```text
Plants:
        Plant UID: xx
        Plant Name: xx
Devices:
        Device Serial Number: xx
Batteries:
        Battery Serial Number: xx
        Battery Serial Number: xx
        Battery Serial Number: xx
Aktuell werden 1,74 Kilowatt verbraucht.
Die aktuelle Autarkie beträgt 70,80 Prozent.
Es wurden 9,00 Kilowattstunden erzeugt.
Der Speicher ist zu 20 Prozent geladen.
Aktuell wird kein Strom erzeugt.
User: xxx
Power analysis: {DATA}
```

 
