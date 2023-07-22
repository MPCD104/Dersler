using FirstDbConnectionApi.Context;
using Microsoft.AspNetCore.Mvc;

namespace FirstDbConnectionApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly FirstDbConnectionContext _connectionContext;
        public WeatherForecastController(FirstDbConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _connectionContext.WeatherForecast.ToList();
        }

        [HttpPost]
        public void Post([FromBody] WeatherForecast weatherForecast)
        {
            _connectionContext.WeatherForecast.Add(weatherForecast);
            _connectionContext.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            WeatherForecast entity = _connectionContext.WeatherForecast.FirstOrDefault(x => x.Id == id);
            _connectionContext.WeatherForecast.Remove(entity);
            _connectionContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Update([FromBody] WeatherForecast weatherForecast, [FromRoute] int id)
        {
            WeatherForecast entity = _connectionContext.WeatherForecast.Find(id);
            entity.Date = weatherForecast.Date;
            entity.TemperatureC = weatherForecast.TemperatureC;
            entity.Summary = weatherForecast.Summary;
            _connectionContext.WeatherForecast.Update(entity);
            _connectionContext.SaveChanges();
        }
        [HttpGet("{id}")]
        public WeatherForecast Get([FromRoute] int id) 
        {
             return _connectionContext.WeatherForecast.Find(id);
            
        }
    }
}