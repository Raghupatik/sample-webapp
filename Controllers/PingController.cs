using Microsoft.AspNetCore.Mvc;

namespace dotnet6.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public PingController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {

        // connect to db

        // server , username, password
        return "Server is Healthy";
    }
}
