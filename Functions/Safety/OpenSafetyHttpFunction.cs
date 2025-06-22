using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace safety_api;

public class OpenSafetyHttpFunction
{
    private readonly ILogger<OpenSafetyHttpFunction> _logger;

    public OpenSafetyHttpFunction(ILogger<OpenSafetyHttpFunction> logger)
    {
        _logger = logger;
    }

    [Function("OpenSafetyHttpFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
