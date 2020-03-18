// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

namespace AzureFunctionActionExecutorSample.FunctionApp
{
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.Azure.WebJobs;
  using Microsoft.Azure.WebJobs.Extensions.Http;
  using Microsoft.AspNetCore.Http;

  public static class HelloWorldFunction
  {
    [FunctionName(nameof(RunHelloWorldFunction))]
    public static IActionResult RunHelloWorldFunction(
      [HttpTrigger(AuthorizationLevel.Function, "get", Route = "hello-world")] HttpRequest req)
      => new OkObjectResult("The action executor does not work.");
  }
}
