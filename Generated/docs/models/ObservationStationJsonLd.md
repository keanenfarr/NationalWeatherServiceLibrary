# NationalWeatherService.Client.Model.ObservationStationJsonLd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**JsonLdContext**](JsonLdContext.md) |  | 
**Geometry** | **string** | A geometry represented in Well-Known Text (WKT) format. | 
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**Elevation** | [**QuantitativeValue**](QuantitativeValue.md) |  | [optional] 
**StationIdentifier** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**VarTimeZone** | **string** |  | [optional] 
**Provider** | **string** | The data provider for this station. E.g., \&quot;ASOS,\&quot; \&quot;MesoWest,\&quot; etc. | [optional] 
**SubProvider** | **string** | The sub-provider of for this station. E.g., \&quot;FAA,\&quot; \&quot;DOT,\&quot; etc. | [optional] 
**Forecast** | **string** | A link to the NWS public forecast zone containing this station. | [optional] 
**County** | **string** | A link to the NWS county zone containing this station. | [optional] 
**FireWeatherZone** | **string** | A link to the NWS fire weather forecast zone containing this station. | [optional] 
**Distance** | [**QuantitativeValue**](QuantitativeValue.md) |  | [optional] 
**Bearing** | [**QuantitativeValue**](QuantitativeValue.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

