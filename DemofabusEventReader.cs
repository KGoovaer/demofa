using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace KGoovaer.Function
{
    public class DemofabusEventReader
    {
        [FunctionName("DemofabusEventReader")]
        public void Run([ServiceBusTrigger("demofabusqueue", Connection = "AzureWebJobsServiceBus")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
