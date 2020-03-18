// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

[assembly: Microsoft.Azure.WebJobs.Hosting.WebJobsStartup(typeof(AzureFunctionActionExecutorSample.FunctionApp.Startup))]

namespace AzureFunctionActionExecutorSample.FunctionApp
{
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.AspNetCore.Mvc.Infrastructure;
  using Microsoft.Azure.WebJobs;
  using Microsoft.Azure.WebJobs.Hosting;
  using Microsoft.Extensions.DependencyInjection;

  public sealed class Startup : IWebJobsStartup
  {
    public void Configure(IWebJobsBuilder builder)
      => builder.Services.AddSingleton<IActionResultExecutor<ObjectResult>, HelloWorldActionExecutor>();
  }
}
