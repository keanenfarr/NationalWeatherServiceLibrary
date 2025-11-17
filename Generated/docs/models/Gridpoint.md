# NationalWeatherService.Client.Model.Gridpoint
Raw forecast data for a 2.5km grid square. This is a list of all potential data layers that may appear. Some layers may not be present in all areas. * temperature * dewpoint * maxTemperature * minTemperature * relativeHumidity * apparentTemperature * heatIndex * windChill * wetBulbGlobeTemperature * skyCover * windDirection * windSpeed * windGust * weather * hazards: Watch and advisory products in effect * probabilityOfPrecipitation * quantitativePrecipitation * iceAccumulation * snowfallAmount * snowLevel * ceilingHeight * visibility * transportWindSpeed * transportWindDirection * mixingHeight * hainesIndex * lightningActivityLevel * twentyFootWindSpeed * twentyFootWindDirection * waveHeight * wavePeriod * waveDirection * primarySwellHeight * primarySwellDirection * secondarySwellHeight * secondarySwellDirection * wavePeriod2 * windWaveHeight * dispersionIndex * pressure: Barometric pressure * probabilityOfTropicalStormWinds * probabilityOfHurricaneWinds * potentialOf15mphWinds * potentialOf25mphWinds * potentialOf35mphWinds * potentialOf45mphWinds * potentialOf20mphWindGusts * potentialOf30mphWindGusts * potentialOf40mphWindGusts * potentialOf50mphWindGusts * potentialOf60mphWindGusts * grasslandFireDangerIndex * probabilityOfThunder * davisStabilityIndex * atmosphericDispersionIndex * lowVisibilityOccurrenceRiskIndex * stability * redFlagThreatIndex 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**JsonLdContext**](JsonLdContext.md) |  | [optional] 
**Geometry** | **string** | A geometry represented in Well-Known Text (WKT) format. | [optional] 
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**UpdateTime** | **DateTime** |  | [optional] 
**ValidTimes** | [**ISO8601Interval**](ISO8601Interval.md) |  | [optional] 
**Elevation** | [**QuantitativeValue**](QuantitativeValue.md) |  | [optional] 
**ForecastOffice** | **string** |  | [optional] 
**GridId** | **string** |  | [optional] 
**GridX** | **int** |  | [optional] 
**GridY** | **int** |  | [optional] 
**Weather** | [**GridpointWeather**](GridpointWeather.md) |  | [optional] 
**Hazards** | [**GridpointHazards**](GridpointHazards.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

