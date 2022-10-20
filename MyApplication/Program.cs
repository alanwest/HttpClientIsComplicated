using System;
using OpenTelemetry;
using OpenTelemetry.Trace;

namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tracerProvider = Sdk.CreateTracerProviderBuilder()
                .SetSampler(new AlwaysOnSampler())
                .AddHttpClientInstrumentation()
                .AddConsoleExporter()
                .Build();

            NetFrameworkLibrary.SomeClass.MakeAnHttpCall().GetAwaiter().GetResult();
            NetStandardLibrary.SomeClass.MakeAnHttpCall().GetAwaiter().GetResult();

            tracerProvider.Dispose();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
