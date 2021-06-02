using System;
using Elastic.CommonSchema.Serilog;
using Serilog;

namespace SampleEcs
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerWithEcs = new LoggerConfiguration()
                .WriteTo.Console(new EcsTextFormatter())
                .CreateLogger();
            loggerWithEcs.Information("Hello World With ECS");

            var loggerWithoutEcs = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            loggerWithoutEcs.Information("Hello World Without ECS");
       }
    }
}
