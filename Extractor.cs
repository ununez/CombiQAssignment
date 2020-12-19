using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Saver
{
    public static class Extractor
    {
        [FunctionName("Extractor")]
        public static void Run([QueueTrigger("outqueue", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"Info: {myQueueItem}");
        }
    }
}
