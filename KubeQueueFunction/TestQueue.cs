using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace KubeQueueFunction
{
    public class TestQueue
    {
        [FunctionName("TestQueue")]
        public void Run([QueueTrigger("testlocalqueue", Connection = "testlocalqueue")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
