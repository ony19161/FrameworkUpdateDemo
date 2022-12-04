using DotNetCoreRestAPI.Models.Commons;
using DotNetCoreRestAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DotNetCoreRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICounterRepository _counterRepository;
        private readonly AppConfiguration _appConfiguration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IOptions<AppConfiguration> options,
            ICounterRepository counterRepository)
        {
            _logger = logger;
            _counterRepository = counterRepository;
            _appConfiguration = options.Value;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            _logger.LogInformation("Calling GetWeatherForecast");
            var list = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return Ok(new
            {
                data = list,
                count = _counterRepository.GetCount()
            });
        }
    }
}