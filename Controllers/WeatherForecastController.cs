using CarManagement.DTOs.Command;
using CarManagement.DTOs.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IMediator _mediator;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("{id}/car")]
    public async Task<IActionResult> GetCarById(int id)
    {
        var query = new GetCarQuery
        {
            Id = id
        };

        var car = await _mediator.Send(query);

        return Ok(car);
    }

    [HttpPost("car")]
    public async Task<IActionResult> CreateCar([FromBody] CreateCarCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}
