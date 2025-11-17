# NationalWeatherService.Client.Model.GridpointHazardsValuesInnerValueInner
A value object representing an expected hazard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Phenomenon** | **string** | Hazard code. This value will correspond to a P-VTEC phenomenon code as defined in NWS Directive 10-1703.  | 
**Significance** | **string** | Significance code. This value will correspond to a P-VTEC significance code as defined in NWS Directive 10-1703. This will most frequently be \&quot;A\&quot; for a watch or \&quot;Y\&quot; for an advisory.  | 
**EventNumber** | **int** | Event number. If this hazard refers to a national or regional center product (such as a Storm Prediction Center convective watch), this value will be the sequence number of that product.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

