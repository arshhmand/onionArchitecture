using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace ProcessOrder;

public class LogWriter
{
    [FunctionName("BlobTriggerCSharp")]        
    public static void Run([BlobTrigger("samples-workitems/{name}", Connection = "")] Stream myBlob, string name, ILogger log)
    {
        log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
    }
}