using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CalculatorService;

using IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(
        (_, services) =>
            services
                .AddTransient<IAdderService, CalculatorPositiveAdder>()
                .AddTransient<IMultiplierService, CalculatorMultiplyByTimesing>()
                .AddTransient<Calculator>()
    )
    .Build();

// Create a scope in which to use our services
using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;

//Use an instance of our created calculator
Calculator calculator = provider.GetRequiredService<Calculator>();
var arg1 = 2.0f;
var arg2 = 3.0f;
var result1 = calculator.Add(arg1, arg2);
Console.WriteLine($"{arg1} + {arg2} = {result1}");

var arg3 = 4.0f;
var arg4 = 5.0f;
var result2 = calculator.Multiply(arg3, arg4);
Console.WriteLine($"{arg3} * {arg4} = {result2}");
