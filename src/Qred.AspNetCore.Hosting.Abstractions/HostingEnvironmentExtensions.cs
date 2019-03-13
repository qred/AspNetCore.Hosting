using System;
using Microsoft.AspNetCore.Hosting;

namespace Qred.AspNetCore.Hosting
{
  public static class HostingEnvironmentExtensions
  {
    public static bool IsTest(this IHostingEnvironment hostingEnvironment)
    {
      return hostingEnvironment.IsEnvironment("Test")
            || hostingEnvironment.IsEnvironment("Testing");
    }
  }
}
