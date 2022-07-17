using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;

namespace CalculatorAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("/add/{paramOne}/{paramTwo}")]
    public double Addition(int paramOne, int paramTwo)
    {
        return Calculator.Calculate(paramOne, paramTwo, "+");

    }

    [HttpGet]
    [Route("/subtract/{paramOne}/{paramTwo}")]
    public double Subtraction(int paramOne, int paramTwo)
    {
        return Calculator.Calculate(paramOne, paramTwo, "-");

    }

    [HttpGet]
    [Route("/multiply/{paramOne}/{paramTwo}")]
    public double Multiplication(int paramOne, int paramTwo)
    {
        return Calculator.Calculate(paramOne, paramTwo, "*");

    }

    [HttpGet]
    [Route("/divide/{paramOne}/{paramTwo}")]
    public double Division(int paramOne, int paramTwo)
    {
        return Calculator.Calculate(paramOne, paramTwo, "/");

    }
}
