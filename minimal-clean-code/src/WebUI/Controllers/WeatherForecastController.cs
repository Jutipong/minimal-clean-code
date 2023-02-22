using Microsoft.AspNetCore.Mvc;
using minimal_clean_code.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace minimal_clean_code.WebUI.Controllers;
public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
