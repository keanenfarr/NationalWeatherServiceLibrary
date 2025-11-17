# NationalWeatherService.Client.Model.Gridpoint12hForecastPeriod
An object containing forecast information for a specific time period (generally 12-hour or 1-hour). 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **int** | Sequential period number. | [optional] 
**Name** | **string** | A textual identifier for the period. This value will not be present for hourly forecasts.  | [optional] 
**StartTime** | **DateTime** | The starting time that this forecast period is valid for. | [optional] 
**EndTime** | **DateTime** | The ending time that this forecast period is valid for. | [optional] 
**IsDaytime** | **bool** | Indicates whether this period is daytime or nighttime. | [optional] 
**Temperature** | [**GridpointHourlyForecastPeriodTemperature**](GridpointHourlyForecastPeriodTemperature.md) |  | [optional] 
**TemperatureUnit** | **string** | The unit of the temperature value (Fahrenheit or Celsius). This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request.  | [optional] 
**TemperatureTrend** | **string** | If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day)  | [optional] 
**ProbabilityOfPrecipitation** | [**QuantitativeValue**](QuantitativeValue.md) |  | [optional] 
**WindSpeed** | [**GridpointHourlyForecastPeriodWindSpeed**](GridpointHourlyForecastPeriodWindSpeed.md) |  | [optional] 
**WindGust** | [**GridpointHourlyForecastPeriodWindGust**](GridpointHourlyForecastPeriodWindGust.md) |  | [optional] 
**WindDirection** | **string** | The prevailing direction of the wind for the period, using a 16-point compass. | [optional] 
**Icon** | **string** | A link to an icon representing the forecast summary. | [optional] 
**ShortForecast** | **string** | A brief textual forecast summary for the period. | [optional] 
**DetailedForecast** | **string** | A detailed textual forecast for the period. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

