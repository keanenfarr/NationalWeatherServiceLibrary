using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWS.Model
{
    public interface IWeatherDataProvider
    {
        Task<CurrentConditionsResponse> GetCurrentConditionsAsync(decimal lat, decimal lng, StateTypes state);

        Task<ForecastResponse> GetForecastAsync(decimal lat, decimal lng);
    }
}
