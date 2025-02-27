using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fetching ConfigurationManager Instance...");

        
        Parallel.Invoke(
            () => { ConfigurationManager config1 = ConfigurationManager.Instance; },
            () => { ConfigurationManager config2 = ConfigurationManager.Instance; }
        );

        ConfigurationManager config = ConfigurationManager.Instance;
        Console.WriteLine(config.GetConfigValue("AppTheme"));
    }
}
