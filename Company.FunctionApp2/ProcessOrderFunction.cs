using System.Net; // For HttpStatusCode
using Microsoft.Azure.Functions.Worker; // For Function and HttpTrigger attributes
using Microsoft.Azure.Functions.Worker.Http; // For HttpRequestData and HttpResponseData
using Microsoft.Extensions.Logging; // For ILogger

namespace Order;

public static class ProcessOrderFunction
{
    [Function(nameof(ProcessOrderFunction))]
    public static HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequestData req,
        FunctionContext executionContext)
    {
        var logger = executionContext.GetLogger(nameof(ProcessOrderFunction));
        logger.LogInformation("Message logged from HTTP Trigger function.");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        response.WriteString("Welcome to .NET isolated worker!");

        return response;
    }
}