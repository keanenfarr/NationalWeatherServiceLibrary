using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void WeatherConditionIsNotNull()
        {
            var task = service.GetCurrentConditionsAsync(0, 0);

            task.Wait();

            var conditions = task.Result;

            Assert.IsNotNull(conditions);
        }

        [TestMethod]
        public void WeatherConditionCelsiusTempIsCorrect()
        {
            var task = service.GetCurrentConditionsAsync(0, 0);

            task.Wait();

            var conditions = task.Result;

            Assert.IsTrue(conditions.TemperatureCelsius.Value.ToString("0.0").Equals("-4.4"));
        }

        [TestMethod]
        public void WeatherConditionFahrenheitTempIsCorrect()
        {
            var task = service.GetCurrentConditionsAsync(0, 0);

            task.Wait();

            var conditions = task.Result;

            Assert.IsTrue(conditions.TemperatureFahrenheit.Value.ToString("0.0").Equals("27.6"));
        }

        [TestMethod]
        public void WeatherForecastIsNotNull()
        {
            var task = service.GetForecastAsync(0, 0);

            task.Wait();

            var forecast = task.Result;

            Assert.IsNotNull(forecast);
        }

        [TestMethod]
        public void WeatherForecastContains14Periods()
        {
            var task = service.GetForecastAsync(0, 0);

            task.Wait();

            var forecast = task.Result;

            Assert.IsTrue(forecast.Periods.Count.Equals(14));
        }
    }
}
