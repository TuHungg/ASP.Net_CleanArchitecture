using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.WeatherData.Dtos;
using CleanArchitecture.Application.WeatherData.Queries.GetWeatherForecastIn7Days;
using CleanArchitecture.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace learn_CleanArchitecture.Web.Controllers;
public class WeatherController : ApiControllerBase
{
    // GET: api/<WeatherController>
    [HttpGet]
    public async Task<ActionResult<Response<WeatherForecastDto>>> GetForecastWeatherIn7Days([FromQuery] GetWeatherForecastIn7daysQuery request)
    {
        var response = await Mediator.Send(request);
        if (response.Succeeded)
        {
            return response;
        }
        else
        {
            return BadRequest(response);
        }
    }

    // GET api/<WeatherController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<WeatherController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<WeatherController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<WeatherController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
