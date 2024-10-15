using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace AmperaHome.ConsoleApp;

internal static class MyConfigurationProvider
{
    private static IConfiguration? _config;

    public static IConfiguration GetConfiguration()
    {

        if (_config == null)
        {
            var configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configurationBuilder.AddUserSecrets(Assembly.GetExecutingAssembly(), true);

            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (environmentName != null)
            {
                string environmentConfigFileName = $"appsettings.{environmentName}.json";
                if (File.Exists(environmentConfigFileName))
                    configurationBuilder.AddJsonFile(environmentConfigFileName, optional: true, reloadOnChange: true);
            }

            configurationBuilder.AddEnvironmentVariables();

            _config = configurationBuilder.Build();
        }
        return _config;
    }
}
