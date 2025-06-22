using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace safety_api;

public class OpenSafetyQueueFunction
{
    private readonly ILogger<OpenSafetyQueueFunction> _logger;

    public OpenSafetyQueueFunction(ILogger<OpenSafetyQueueFunction> logger)
    {
        _logger = logger;
    }

    [Function(nameof(OpenSafetyQueueFunction))]
    public void Run([QueueTrigger("opensafetyreqs", Connection = "")] QueueMessage message)
    {
        _logger.LogInformation("C# Queue trigger function processed: {messageText}", message.MessageText);
    }
}

