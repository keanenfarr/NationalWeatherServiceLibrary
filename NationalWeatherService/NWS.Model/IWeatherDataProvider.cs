using System;
using System.Collections.Generic;
using System.Text;

namespace NWS.Model
{
    public interface IWeatherDataProvider
    {
        CurrentConditionsResponse GetCurrentConditions(decimal lat, decimal lng);

        ForecastResponse GetForecast(decimal lat, decimal lng);
    }
}
