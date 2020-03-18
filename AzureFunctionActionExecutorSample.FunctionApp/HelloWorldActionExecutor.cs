// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

namespace AzureFunctionActionExecutorSample.FunctionApp
{
  using System.Net.Mime;
  using System.Text;
  using System.Threading.Tasks;

  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.AspNetCore.Mvc.Infrastructure;

  internal sealed class HelloWorldActionExecutor : IActionResultExecutor<ObjectResult>
  {
    public Task ExecuteAsync(ActionContext context, ObjectResult result)
      => WriteAsync(context.HttpContext.Response);

    private static async Task WriteAsync(HttpResponse response)
    {
      response.StatusCode = StatusCodes.Status200OK;
      response.ContentType = MediaTypeNames.Application.Json;

      var bytes = Encoding.UTF8.GetBytes("{ \"message\": \"Hello World\" }");

      await response.Body.WriteAsync(bytes);
    }
  }
}
