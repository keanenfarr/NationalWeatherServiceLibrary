# NationalWeatherService.Client.Model.Zone

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**JsonLdContext**](JsonLdContext.md) |  | [optional] 
**Geometry** | **string** | A geometry represented in Well-Known Text (WKT) format. | [optional] 
**Id2** | **string** |  | [optional] 
**Type2** | **string** |  | [optional] 
**Id** | **string** | UGC identifier for a NWS forecast zone or county. The first two letters will correspond to either a state code or marine area code (see #/components/schemas/StateTerritoryCode and #/components/schemas/MarineAreaCode for lists of valid letter combinations). The third letter will be Z for public/fire zone or C for county.  | [optional] 
**Type** | **NWSZoneType** |  | [optional] 
**Name** | **string** |  | [optional] 
**EffectiveDate** | **DateTime** |  | [optional] 
**ExpirationDate** | **DateTime** |  | [optional] 
**State** | **string** |  | [optional] 
**ForecastOffice** | **string** |  | [optional] 
**GridIdentifier** | **string** |  | [optional] 
**AwipsLocationIdentifier** | **string** |  | [optional] 
**Cwa** | [**List&lt;NWSForecastOfficeId&gt;**](NWSForecastOfficeId.md) |  | [optional] 
**ForecastOffices** | **List&lt;string&gt;** |  | [optional] 
**VarTimeZone** | **List&lt;string&gt;** |  | [optional] 
**ObservationStations** | **List&lt;string&gt;** |  | [optional] 
**RadarStation** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

