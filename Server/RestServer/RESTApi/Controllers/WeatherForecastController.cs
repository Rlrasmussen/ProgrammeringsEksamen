using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace RESTApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private const string dataDirectory = "tmp";
        private static readonly string serverPrivateKey, serverPublicKey, usersFile = dataDirectory + "/users.json";
        private static readonly object fileLock = new object();

        static WeatherForecastController()
        {

            lock (fileLock)
            {
                if (!Directory.Exists(dataDirectory))
                {
                    Directory.CreateDirectory(dataDirectory);
                }

                if (!System.IO.File.Exists(usersFile))
                {
                    System.IO.File.WriteAllText("[]", usersFile); //Opretter ny
                }
            }
        }

        #region Deleted
        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}
        #endregion

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


        [HttpHead("Heartbeat")]
        public ActionResult Ping()
        {
            return Ok();
        }
    }
}
