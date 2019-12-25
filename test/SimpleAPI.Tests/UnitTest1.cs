using Microsoft.Extensions.Logging;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        private ILogger<WeatherForecastController> logger;

        [Fact]
        public void GetReturnsCorrectNumber()
        {
            WeatherForecastController controller = new WeatherForecastController(logger);
            var returnValue = controller.Get(1);

            Assert.Equal("Freezing", returnValue.Value);
        }
    }
}
