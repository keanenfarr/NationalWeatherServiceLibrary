# NationalWeatherService.Client.Model.ZoneForecast
An object representing a zone area forecast.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**JsonLdContext**](JsonLdContext.md) |  | [optional] 
**Geometry** | **string** | A geometry represented in Well-Known Text (WKT) format. | [optional] 
**Zone** | **string** | An API link to the zone this forecast is for. | [optional] 
**Updated** | **DateTime** | The time this zone forecast product was published. | [optional] 
**Periods** | [**List&lt;ZoneForecastPeriodsInner&gt;**](ZoneForecastPeriodsInner.md) | An array of forecast periods. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

