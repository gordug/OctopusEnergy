using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace OctopusEnergy;

public class OctopusEnergyTracker
{
    [FunctionName("GetUsage")]
    public void Run([TimerTrigger("0 0 * * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
    }
}