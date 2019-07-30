using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using NWS.WebClient;
using NWS.Model;

namespace NWS.WeatherDataService.Tests
{
    [TestClass]
    public class WeatherDataServiceUnitTests
    {
        IWebClient webClient;
        IWeatherDataProvider service;

        [TestInitialize()]
        public void Initialize()
        {
            webClient = new WebClients.CurrentConditionsValidWebClient();
            service = new WeatherDataService(webClient);
        }

        [TestMethod]
        public async Task WeatherConditionIsNotNull()
        {
            var conditions = await service.GetCurrentConditionsAsync(0, 0);
            
            Assert.IsNotNull(conditions);
        }

        [TestMethod]
        public async Task WeatherConditionCelsiusTempIsCorrect()
        {
            var conditions = await service.GetCurrentConditionsAsync(0, 0);

            Assert.IsTrue(conditions.TemperatureCelsius.Value.ToString("0.0").Equals("-4.4"));
        }

        [TestMethod]
        public async Task WeatherConditionFahrenheitTempIsCorrect()
        {
            var conditions = await service.GetCurrentConditionsAsync(0, 0);

            Assert.IsTrue(conditions.TemperatureFahrenheit.Value.ToString("0.0").Equals("24.1"));
        }

        [TestMethod]
        public async Task WeatherForecastIsNotNull()
        {
            var forecast = await service.GetForecastAsync(0, 0);

            Assert.IsNotNull(forecast);
        }

        [TestMethod]
        public async Task WeatherForecastContains14Periods()
        {
            var forecast = await service.GetForecastAsync(0, 0);

            Assert.IsTrue(forecast.Periods.Count.Equals(14));
        }
    }
}
