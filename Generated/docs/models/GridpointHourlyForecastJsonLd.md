# NationalWeatherService.Client.Model.GridpointHourlyForecastJsonLd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**JsonLdContext**](JsonLdContext.md) |  | 
**Geometry** | **string** | A geometry represented in Well-Known Text (WKT) format. | 
**Units** | **GridpointForecastUnits** |  | [optional] 
**ForecastGenerator** | **string** | The internal generator class used to create the forecast text (used for NWS debugging). | [optional] 
**GeneratedAt** | **DateTime** | The time this forecast data was generated. | [optional] 
**UpdateTime** | **DateTime** | The last update time of the data this forecast was generated from. | [optional] 
**ValidTimes** | [**ISO8601Interval**](ISO8601Interval.md) |  | [optional] 
**Elevation** | [**QuantitativeValue**](QuantitativeValue.md) |  | [optional] 
**Periods** | [**List&lt;GridpointHourlyForecastPeriod&gt;**](GridpointHourlyForecastPeriod.md) | An array of forecast periods. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

