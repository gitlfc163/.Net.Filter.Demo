using Microsoft.AspNetCore.Mvc;
using Net6.Filter.Demo.Filters;
using Net6.Filter.Demo.Models;

namespace Net6.Filter.Demo.Controllers.FilterDemo;

public class FilterDemoController : AreaController
{
    private static readonly string[] Summaries = new[]
    {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

    private readonly ILogger<FilterDemoController> _logger;

    public FilterDemoController(ILogger<FilterDemoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    //[CustomerActionFilter(Order =1)]
    //[CustomerAuthorizationFilter]
    //[CustomerResourceFilter]
    [CustomerExceptionFilter]
    public IEnumerable<WeatherForecast> Get()
    {
        Console.WriteLine("GetWeatherForecast¿ªÊ¼");
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}