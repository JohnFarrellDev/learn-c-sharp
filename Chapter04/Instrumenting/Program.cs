using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
  class Program
  {
    static void Main(string[] args)
    {
      Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
      Trace.AutoFlush = true;
      Debug.WriteLine("Debug is here");
      Trace.WriteLine("Trace is here");

      var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json",
        optional: true, reloadOnChange: true);

      IConfigurationRoot configuration = builder.Build();

      var ts = new TraceSwitch(
        displayName: "PacktSwitch",
        description: "This switch is set via JSON config"
      );

      configuration.GetSection("PacktSwitch").Bind(ts);

      Trace.WriteLine(ts.TraceError, "error");
      Trace.WriteLine(ts.TraceWarning, "warning");
      Trace.WriteLine(ts.TraceInfo, "info");
      Trace.WriteLine(ts.TraceVerbose, "verbose");
    }
  }
}
