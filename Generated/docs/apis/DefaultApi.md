# NationalWeatherService.Client.Api.DefaultApi

All URIs are relative to *https://api.weather.gov*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AlertsActive**](DefaultApi.md#alertsactive) | **GET** /alerts/active |  |
| [**AlertsActiveArea**](DefaultApi.md#alertsactivearea) | **GET** /alerts/active/area/{area} |  |
| [**AlertsActiveCount**](DefaultApi.md#alertsactivecount) | **GET** /alerts/active/count |  |
| [**AlertsActiveRegion**](DefaultApi.md#alertsactiveregion) | **GET** /alerts/active/region/{region} |  |
| [**AlertsActiveZone**](DefaultApi.md#alertsactivezone) | **GET** /alerts/active/zone/{zoneId} |  |
| [**AlertsQuery**](DefaultApi.md#alertsquery) | **GET** /alerts |  |
| [**AlertsSingle**](DefaultApi.md#alertssingle) | **GET** /alerts/{id} |  |
| [**AlertsTypes**](DefaultApi.md#alertstypes) | **GET** /alerts/types |  |
| [**Cwa**](DefaultApi.md#cwa) | **GET** /aviation/cwsus/{cwsuId}/cwas/{date}/{sequence} |  |
| [**Cwas**](DefaultApi.md#cwas) | **GET** /aviation/cwsus/{cwsuId}/cwas |  |
| [**Cwsu**](DefaultApi.md#cwsu) | **GET** /aviation/cwsus/{cwsuId} |  |
| [**Glossary**](DefaultApi.md#glossary) | **GET** /glossary |  |
| [**Gridpoint**](DefaultApi.md#gridpoint) | **GET** /gridpoints/{wfo}/{x},{y} |  |
| [**GridpointForecast**](DefaultApi.md#gridpointforecast) | **GET** /gridpoints/{wfo}/{x},{y}/forecast |  |
| [**GridpointForecastHourly**](DefaultApi.md#gridpointforecasthourly) | **GET** /gridpoints/{wfo}/{x},{y}/forecast/hourly |  |
| [**GridpointStations**](DefaultApi.md#gridpointstations) | **GET** /gridpoints/{wfo}/{x},{y}/stations |  |
| [**Icons**](DefaultApi.md#icons) | **GET** /icons/{set}/{timeOfDay}/{first} |  |
| [**IconsDualCondition**](DefaultApi.md#iconsdualcondition) | **GET** /icons/{set}/{timeOfDay}/{first}/{second} |  |
| [**IconsSummary**](DefaultApi.md#iconssummary) | **GET** /icons |  |
| [**LatestProductTypeLocation**](DefaultApi.md#latestproducttypelocation) | **GET** /products/types/{typeId}/locations/{locationId}/latest |  |
| [**LocationProducts**](DefaultApi.md#locationproducts) | **GET** /products/locations/{locationId}/types |  |
| [**ObsStation**](DefaultApi.md#obsstation) | **GET** /stations/{stationId} |  |
| [**ObsStations**](DefaultApi.md#obsstations) | **GET** /stations |  |
| [**Office**](DefaultApi.md#office) | **GET** /offices/{officeId} |  |
| [**OfficeHeadline**](DefaultApi.md#officeheadline) | **GET** /offices/{officeId}/headlines/{headlineId} |  |
| [**OfficeHeadlines**](DefaultApi.md#officeheadlines) | **GET** /offices/{officeId}/headlines |  |
| [**Point**](DefaultApi.md#point) | **GET** /points/{latitude},{longitude} |  |
| [**PointStations**](DefaultApi.md#pointstations) | **GET** /points/{latitude},{longitude}/stations |  |
| [**Product**](DefaultApi.md#product) | **GET** /products/{productId} |  |
| [**ProductLocations**](DefaultApi.md#productlocations) | **GET** /products/locations |  |
| [**ProductTypes**](DefaultApi.md#producttypes) | **GET** /products/types |  |
| [**ProductsQuery**](DefaultApi.md#productsquery) | **GET** /products |  |
| [**ProductsType**](DefaultApi.md#productstype) | **GET** /products/types/{typeId} |  |
| [**ProductsTypeLocation**](DefaultApi.md#productstypelocation) | **GET** /products/types/{typeId}/locations/{locationId} |  |
| [**ProductsTypeLocations**](DefaultApi.md#productstypelocations) | **GET** /products/types/{typeId}/locations |  |
| [**RadarProfiler**](DefaultApi.md#radarprofiler) | **GET** /radar/profilers/{stationId} |  |
| [**RadarQueue**](DefaultApi.md#radarqueue) | **GET** /radar/queues/{host} |  |
| [**RadarServer**](DefaultApi.md#radarserver) | **GET** /radar/servers/{id} |  |
| [**RadarServers**](DefaultApi.md#radarservers) | **GET** /radar/servers |  |
| [**RadarStation**](DefaultApi.md#radarstation) | **GET** /radar/stations/{stationId} |  |
| [**RadarStationAlarms**](DefaultApi.md#radarstationalarms) | **GET** /radar/stations/{stationId}/alarms |  |
| [**RadarStations**](DefaultApi.md#radarstations) | **GET** /radar/stations |  |
| [**SatelliteThumbnails**](DefaultApi.md#satellitethumbnails) | **GET** /thumbnails/satellite/{area} |  |
| [**Sigmet**](DefaultApi.md#sigmet) | **GET** /aviation/sigmets/{atsu}/{date}/{time} |  |
| [**SigmetQuery**](DefaultApi.md#sigmetquery) | **GET** /aviation/sigmets |  |
| [**SigmetsByATSU**](DefaultApi.md#sigmetsbyatsu) | **GET** /aviation/sigmets/{atsu} |  |
| [**SigmetsByATSUByDate**](DefaultApi.md#sigmetsbyatsubydate) | **GET** /aviation/sigmets/{atsu}/{date} |  |
| [**StationObservationLatest**](DefaultApi.md#stationobservationlatest) | **GET** /stations/{stationId}/observations/latest |  |
| [**StationObservationList**](DefaultApi.md#stationobservationlist) | **GET** /stations/{stationId}/observations |  |
| [**StationObservationTime**](DefaultApi.md#stationobservationtime) | **GET** /stations/{stationId}/observations/{time} |  |
| [**Taf**](DefaultApi.md#taf) | **GET** /stations/{stationId}/tafs/{date}/{time} |  |
| [**Tafs**](DefaultApi.md#tafs) | **GET** /stations/{stationId}/tafs |  |
| [**Zone**](DefaultApi.md#zone) | **GET** /zones/{type}/{zoneId} |  |
| [**ZoneForecast**](DefaultApi.md#zoneforecast) | **GET** /zones/{type}/{zoneId}/forecast |  |
| [**ZoneList**](DefaultApi.md#zonelist) | **GET** /zones |  |
| [**ZoneListType**](DefaultApi.md#zonelisttype) | **GET** /zones/{type} |  |
| [**ZoneObs**](DefaultApi.md#zoneobs) | **GET** /zones/forecast/{zoneId}/observations |  |
| [**ZoneStations**](DefaultApi.md#zonestations) | **GET** /zones/forecast/{zoneId}/stations |  |

<a id="alertsactive"></a>
# **AlertsActive**
> AlertCollectionGeoJson AlertsActive (List<string> status = null, List<string> messageType = null, List<string> varEvent = null, List<string> code = null, List<AreaCode> area = null, string point = null, List<MarineRegionCode> region = null, string regionType = null, List<string> zone = null, List<AlertUrgency> urgency = null, List<AlertSeverity> severity = null, List<AlertCertainty> certainty = null)



Returns all currently active alerts


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | [**List&lt;string&gt;**](string.md) | Status (actual, exercise, system, test, draft) | [optional]  |
| **messageType** | [**List&lt;string&gt;**](string.md) | Message type (alert, update, cancel) | [optional]  |
| **varEvent** | [**List&lt;string&gt;**](string.md) | Event name | [optional]  |
| **code** | [**List&lt;string&gt;**](string.md) | Event code | [optional]  |
| **area** | [**List&lt;AreaCode&gt;**](AreaCode.md) | State/territory code or marine area code This parameter is incompatible with the following parameters: point, region, region_type, zone  | [optional]  |
| **point** | **string** | Point (latitude,longitude) This parameter is incompatible with the following parameters: area, region, region_type, zone  | [optional]  |
| **region** | [**List&lt;MarineRegionCode&gt;**](MarineRegionCode.md) | Marine region code This parameter is incompatible with the following parameters: area, point, region_type, zone  | [optional]  |
| **regionType** | **string** | Region type (land or marine) This parameter is incompatible with the following parameters: area, point, region, zone  | [optional]  |
| **zone** | [**List&lt;string&gt;**](string.md) | Zone ID (forecast or county) This parameter is incompatible with the following parameters: area, point, region, region_type  | [optional]  |
| **urgency** | [**List&lt;AlertUrgency&gt;**](AlertUrgency.md) | Urgency (immediate, expected, future, past, unknown) | [optional]  |
| **severity** | [**List&lt;AlertSeverity&gt;**](AlertSeverity.md) | Severity (extreme, severe, moderate, minor, unknown) | [optional]  |
| **certainty** | [**List&lt;AlertCertainty&gt;**](AlertCertainty.md) | Certainty (observed, likely, possible, unlikely, unknown) | [optional]  |

### Return type

[**AlertCollectionGeoJson**](AlertCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of alerts. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **301** | Certain common queries may be redirected to discrete URLs |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertsactivearea"></a>
# **AlertsActiveArea**
> AlertCollectionGeoJson AlertsActiveArea (AreaCode area)



Returns active alerts for the given area (state or marine area)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **area** | **AreaCode** | State/area ID |  |

### Return type

[**AlertCollectionGeoJson**](AlertCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of alerts. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertsactivecount"></a>
# **AlertsActiveCount**
> AlertsActiveCount200Response AlertsActiveCount ()



Returns info on the number of active alerts


### Parameters
This endpoint does not need any parameter.
### Return type

[**AlertsActiveCount200Response**](AlertsActiveCount200Response.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A data structure showing the counts of active alerts broken down by various categories |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertsactiveregion"></a>
# **AlertsActiveRegion**
> AlertCollectionGeoJson AlertsActiveRegion (MarineRegionCode region)



Returns active alerts for the given marine region


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **MarineRegionCode** | Marine region ID |  |

### Return type

[**AlertCollectionGeoJson**](AlertCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of alerts. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertsactivezone"></a>
# **AlertsActiveZone**
> AlertCollectionGeoJson AlertsActiveZone (string zoneId)



Returns active alerts for the given NWS public zone or county


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | NWS public zone/county identifier |  |

### Return type

[**AlertCollectionGeoJson**](AlertCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of alerts. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertsquery"></a>
# **AlertsQuery**
> AlertCollectionGeoJson AlertsQuery (bool active = null, DateTime start = null, DateTime end = null, List<string> status = null, List<string> messageType = null, List<string> varEvent = null, List<string> code = null, List<AreaCode> area = null, string point = null, List<MarineRegionCode> region = null, string regionType = null, List<string> zone = null, List<AlertUrgency> urgency = null, List<AlertSeverity> severity = null, List<AlertCertainty> certainty = null, int limit = null, string cursor = null)



Returns all alerts


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **active** | **bool** | List only active alerts (use /alerts/active endpoints instead) | [optional]  |
| **start** | **DateTime** | Start time | [optional]  |
| **end** | **DateTime** | End time | [optional]  |
| **status** | [**List&lt;string&gt;**](string.md) | Status (actual, exercise, system, test, draft) | [optional]  |
| **messageType** | [**List&lt;string&gt;**](string.md) | Message type (alert, update, cancel) | [optional]  |
| **varEvent** | [**List&lt;string&gt;**](string.md) | Event name | [optional]  |
| **code** | [**List&lt;string&gt;**](string.md) | Event code | [optional]  |
| **area** | [**List&lt;AreaCode&gt;**](AreaCode.md) | State/territory code or marine area code This parameter is incompatible with the following parameters: point, region, region_type, zone  | [optional]  |
| **point** | **string** | Point (latitude,longitude) This parameter is incompatible with the following parameters: area, region, region_type, zone  | [optional]  |
| **region** | [**List&lt;MarineRegionCode&gt;**](MarineRegionCode.md) | Marine region code This parameter is incompatible with the following parameters: area, point, region_type, zone  | [optional]  |
| **regionType** | **string** | Region type (land or marine) This parameter is incompatible with the following parameters: area, point, region, zone  | [optional]  |
| **zone** | [**List&lt;string&gt;**](string.md) | Zone ID (forecast or county) This parameter is incompatible with the following parameters: area, point, region, region_type  | [optional]  |
| **urgency** | [**List&lt;AlertUrgency&gt;**](AlertUrgency.md) | Urgency (immediate, expected, future, past, unknown) | [optional]  |
| **severity** | [**List&lt;AlertSeverity&gt;**](AlertSeverity.md) | Severity (extreme, severe, moderate, minor, unknown) | [optional]  |
| **certainty** | [**List&lt;AlertCertainty&gt;**](AlertCertainty.md) | Certainty (observed, likely, possible, unlikely, unknown) | [optional]  |
| **limit** | **int** | Limit | [optional] [default to 500] |
| **cursor** | **string** | Pagination cursor | [optional]  |

### Return type

[**AlertCollectionGeoJson**](AlertCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of alerts. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **301** | Certain common queries may be redirected to discrete URLs |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertssingle"></a>
# **AlertsSingle**
> AlertGeoJson AlertsSingle (string id)



Returns a specific alert


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Alert identifier |  |

### Return type

[**AlertGeoJson**](AlertGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/cap+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An alert record |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="alertstypes"></a>
# **AlertsTypes**
> AlertsTypes200Response AlertsTypes ()



Returns a list of alert types


### Parameters
This endpoint does not need any parameter.
### Return type

[**AlertsTypes200Response**](AlertsTypes200Response.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of recognized event types |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cwa"></a>
# **Cwa**
> CenterWeatherAdvisoryGeoJson Cwa (NWSCenterWeatherServiceUnitId cwsuId, DateOnly date, int sequence)



Returns a list of Center Weather Advisories from a CWSU


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cwsuId** | **NWSCenterWeatherServiceUnitId** | NWS CWSU ID |  |
| **date** | **DateOnly** | Date (YYYY-MM-DD format) |  |
| **sequence** | **int** | Sequence number |  |

### Return type

[**CenterWeatherAdvisoryGeoJson**](CenterWeatherAdvisoryGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/vnd.noaa.uswx+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cwas"></a>
# **Cwas**
> CenterWeatherAdvisoryCollectionGeoJson Cwas (NWSCenterWeatherServiceUnitId cwsuId)



Returns a list of Center Weather Advisories from a CWSU


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cwsuId** | **NWSCenterWeatherServiceUnitId** | NWS CWSU ID |  |

### Return type

[**CenterWeatherAdvisoryCollectionGeoJson**](CenterWeatherAdvisoryCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cwsu"></a>
# **Cwsu**
> Office Cwsu (NWSCenterWeatherServiceUnitId cwsuId)



Returns metadata about a Center Weather Service Unit


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cwsuId** | **NWSCenterWeatherServiceUnitId** | NWS CWSU ID |  |

### Return type

[**Office**](Office.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="glossary"></a>
# **Glossary**
> Glossary200Response Glossary ()



Returns glossary terms


### Parameters
This endpoint does not need any parameter.
### Return type

[**Glossary200Response**](Glossary200Response.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A set of glossary terms |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gridpoint"></a>
# **Gridpoint**
> GridpointGeoJson Gridpoint (NWSForecastOfficeId wfo, int x, int y)



Returns raw numerical forecast data for a 2.5km grid area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wfo** | **NWSForecastOfficeId** | Forecast office ID |  |
| **x** | **int** | Forecast grid X coordinate |  |
| **y** | **int** | Forecast grid Y coordinate |  |

### Return type

[**GridpointGeoJson**](GridpointGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gridpoint forecast data |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gridpointforecast"></a>
# **GridpointForecast**
> Gridpoint12hForecastGeoJson GridpointForecast (NWSForecastOfficeId wfo, int x, int y, List<string> featureFlags = null, GridpointForecastUnits units = null)



Returns a textual forecast for a 2.5km grid area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wfo** | **NWSForecastOfficeId** | Forecast office ID |  |
| **x** | **int** | Forecast grid X coordinate |  |
| **y** | **int** | Forecast grid Y coordinate |  |
| **featureFlags** | [**List&lt;string&gt;**](string.md) | Enable future and experimental features (see documentation for more info): * forecast_temperature_qv: Represent temperature as QuantitativeValue * forecast_wind_speed_qv: Represent wind speed as QuantitativeValue  | [optional]  |
| **units** | **GridpointForecastUnits** | Use US customary or SI (metric) units in textual output | [optional]  |

### Return type

[**Gridpoint12hForecastGeoJson**](Gridpoint12hForecastGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.dwml+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A forecast for a gridpoint. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gridpointforecasthourly"></a>
# **GridpointForecastHourly**
> GridpointHourlyForecastGeoJson GridpointForecastHourly (NWSForecastOfficeId wfo, int x, int y, List<string> featureFlags = null, GridpointForecastUnits units = null)



Returns a textual hourly forecast for a 2.5km grid area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wfo** | **NWSForecastOfficeId** | Forecast office ID |  |
| **x** | **int** | Forecast grid X coordinate |  |
| **y** | **int** | Forecast grid Y coordinate |  |
| **featureFlags** | [**List&lt;string&gt;**](string.md) | Enable future and experimental features (see documentation for more info): * forecast_temperature_qv: Represent temperature as QuantitativeValue * forecast_wind_speed_qv: Represent wind speed as QuantitativeValue  | [optional]  |
| **units** | **GridpointForecastUnits** | Use US customary or SI (metric) units in textual output | [optional]  |

### Return type

[**GridpointHourlyForecastGeoJson**](GridpointHourlyForecastGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.dwml+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A forecast for a gridpoint. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gridpointstations"></a>
# **GridpointStations**
> ObservationStationCollectionGeoJson GridpointStations (NWSForecastOfficeId wfo, int x, int y, int limit = null, List<string> featureFlags = null)



Returns a list of observation stations usable for a given 2.5km grid area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wfo** | **NWSForecastOfficeId** | Forecast office ID |  |
| **x** | **int** | Forecast grid X coordinate |  |
| **y** | **int** | Forecast grid Y coordinate |  |
| **limit** | **int** | Limit | [optional] [default to 500] |
| **featureFlags** | [**List&lt;string&gt;**](string.md) | Enable future and experimental features (see documentation for more info): * obs_station_provider: Include the data provider in the metadata about observation stations  | [optional]  |

### Return type

[**ObservationStationCollectionGeoJson**](ObservationStationCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of observation stations. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="icons"></a>
# **Icons**
> System.IO.Stream Icons (string set, string timeOfDay, string first, IconsSizeParameter size = null, int fontsize = null)



Returns a forecast icon. Icon services in API are deprecated.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **set** | **string** | . |  |
| **timeOfDay** | **string** | . |  |
| **first** | **string** | . |  |
| **size** | [**IconsSizeParameter**](IconsSizeParameter.md) | Font size | [optional]  |
| **fontsize** | **int** | Font size | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="iconsdualcondition"></a>
# **IconsDualCondition**
> System.IO.Stream IconsDualCondition (string set, string timeOfDay, string first, string second, IconsSizeParameter size = null, int fontsize = null)



Returns a forecast icon. Icon services in API are deprecated.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **set** | **string** | . |  |
| **timeOfDay** | **string** | . |  |
| **first** | **string** | . |  |
| **second** | **string** | . |  |
| **size** | [**IconsSizeParameter**](IconsSizeParameter.md) | Font size | [optional]  |
| **fontsize** | **int** | Font size | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="iconssummary"></a>
# **IconsSummary**
> IconsSummary200Response IconsSummary ()



Returns a list of icon codes and textual descriptions. Icon services in API are deprecated.


### Parameters
This endpoint does not need any parameter.
### Return type

[**IconsSummary200Response**](IconsSummary200Response.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="latestproducttypelocation"></a>
# **LatestProductTypeLocation**
> TextProductCollection LatestProductTypeLocation (string typeId, string locationId)



Returns latest text products of a given type for a given issuance location with product text


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **typeId** | **string** | . |  |
| **locationId** | **string** | . |  |

### Return type

[**TextProductCollection**](TextProductCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="locationproducts"></a>
# **LocationProducts**
> TextProductTypeCollection LocationProducts (string locationId)



Returns a list of valid text product types for a given issuance location


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **string** | . |  |

### Return type

[**TextProductTypeCollection**](TextProductTypeCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="obsstation"></a>
# **ObsStation**
> ObservationStationGeoJson ObsStation (string stationId, List<string> featureFlags = null)



Returns metadata about a given observation station


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Observation station ID |  |
| **featureFlags** | [**List&lt;string&gt;**](string.md) | Enable future and experimental features (see documentation for more info): * obs_station_provider: Include the data provider in the metadata about observation stations  | [optional]  |

### Return type

[**ObservationStationGeoJson**](ObservationStationGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="obsstations"></a>
# **ObsStations**
> ObservationStationCollectionGeoJson ObsStations (List<string> id = null, List<AreaCode> state = null, int limit = null, string cursor = null, List<string> featureFlags = null)



Returns a list of observation stations.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | [**List&lt;string&gt;**](string.md) | Filter by observation station ID | [optional]  |
| **state** | [**List&lt;AreaCode&gt;**](AreaCode.md) | Filter by state/marine area code | [optional]  |
| **limit** | **int** | Limit | [optional] [default to 500] |
| **cursor** | **string** | Pagination cursor | [optional]  |
| **featureFlags** | [**List&lt;string&gt;**](string.md) | Enable future and experimental features (see documentation for more info): * obs_station_provider: Include the data provider in the metadata about observation stations  | [optional]  |

### Return type

[**ObservationStationCollectionGeoJson**](ObservationStationCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of observation stations. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="office"></a>
# **Office**
> Office Office (NWSOfficeId officeId)



Returns metadata about a NWS forecast office


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **officeId** | **NWSOfficeId** | NWS office ID |  |

### Return type

[**Office**](Office.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="officeheadline"></a>
# **OfficeHeadline**
> OfficeHeadline OfficeHeadline (NWSOfficeId officeId, string headlineId)



Returns a specific news headline for a given NWS office


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **officeId** | **NWSOfficeId** | NWS office ID |  |
| **headlineId** | **string** | Headline record ID |  |

### Return type

[**OfficeHeadline**](OfficeHeadline.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="officeheadlines"></a>
# **OfficeHeadlines**
> OfficeHeadlineCollection OfficeHeadlines (NWSOfficeId officeId)



Returns a list of news headlines for a given NWS office


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **officeId** | **NWSOfficeId** | NWS office ID |  |

### Return type

[**OfficeHeadlineCollection**](OfficeHeadlineCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="point"></a>
# **Point**
> PointGeoJson Point (decimal latitude, decimal longitude)



Returns metadata about a given latitude/longitude point


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **latitude** | **decimal** | Latitude |  |
| **longitude** | **decimal** | Longitude |  |

### Return type

[**PointGeoJson**](PointGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pointstations"></a>
# **PointStations**
> ProblemDetail PointStations (decimal latitude, decimal longitude)



Returns a list of observation stations for a given point


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **latitude** | **decimal** | Latitude |  |
| **longitude** | **decimal** | Longitude |  |

### Return type

[**ProblemDetail**](ProblemDetail.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **301** | redirect to gridpoint stations |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="product"></a>
# **Product**
> TextProduct Product (string productId)



Returns a specific text product


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | . |  |

### Return type

[**TextProduct**](TextProduct.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productlocations"></a>
# **ProductLocations**
> TextProductLocationCollection ProductLocations ()



Returns a list of valid text product issuance locations


### Parameters
This endpoint does not need any parameter.
### Return type

[**TextProductLocationCollection**](TextProductLocationCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="producttypes"></a>
# **ProductTypes**
> TextProductTypeCollection ProductTypes ()



Returns a list of valid text product types and codes


### Parameters
This endpoint does not need any parameter.
### Return type

[**TextProductTypeCollection**](TextProductTypeCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productsquery"></a>
# **ProductsQuery**
> TextProductCollection ProductsQuery (List<string> location = null, DateTime start = null, DateTime end = null, List<string> office = null, List<string> wmoid = null, List<string> type = null, int limit = null)



Returns a list of text products


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **location** | [**List&lt;string&gt;**](string.md) | Location id | [optional]  |
| **start** | **DateTime** | Start time | [optional]  |
| **end** | **DateTime** | End time | [optional]  |
| **office** | [**List&lt;string&gt;**](string.md) | Issuing office | [optional]  |
| **wmoid** | [**List&lt;string&gt;**](string.md) | WMO id code | [optional]  |
| **type** | [**List&lt;string&gt;**](string.md) | Product code | [optional]  |
| **limit** | **int** | Limit | [optional]  |

### Return type

[**TextProductCollection**](TextProductCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productstype"></a>
# **ProductsType**
> TextProductCollection ProductsType (string typeId)



Returns a list of text products of a given type


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **typeId** | **string** | . |  |

### Return type

[**TextProductCollection**](TextProductCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productstypelocation"></a>
# **ProductsTypeLocation**
> TextProductCollection ProductsTypeLocation (string typeId, string locationId)



Returns a list of text products of a given type for a given issuance location


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **typeId** | **string** | . |  |
| **locationId** | **string** | . |  |

### Return type

[**TextProductCollection**](TextProductCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productstypelocations"></a>
# **ProductsTypeLocations**
> TextProductLocationCollection ProductsTypeLocations (string typeId)



Returns a list of valid text product issuance locations for a given product type


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **typeId** | **string** | . |  |

### Return type

[**TextProductLocationCollection**](TextProductLocationCollection.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarprofiler"></a>
# **RadarProfiler**
> Object RadarProfiler (string stationId, ISO8601Interval time = null, string interval = null)



Returns metadata about a given radar wind profiler


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Profiler station ID |  |
| **time** | [**ISO8601Interval**](ISO8601Interval.md) | Time interval | [optional]  |
| **interval** | **string** | Averaging interval | [optional]  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarqueue"></a>
# **RadarQueue**
> Object RadarQueue (string host, int limit = null, ISO8601Interval arrived = null, ISO8601Interval created = null, ISO8601Interval published = null, string station = null, string type = null, string feed = null, int resolution = null)



Returns metadata about a given radar queue


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **host** | **string** | LDM host |  |
| **limit** | **int** | Record limit | [optional]  |
| **arrived** | [**ISO8601Interval**](ISO8601Interval.md) | Range for arrival time | [optional]  |
| **created** | [**ISO8601Interval**](ISO8601Interval.md) | Range for creation time | [optional]  |
| **published** | [**ISO8601Interval**](ISO8601Interval.md) | Range for publish time | [optional]  |
| **station** | **string** | Station identifier | [optional]  |
| **type** | **string** | Record type | [optional]  |
| **feed** | **string** | Originating product feed | [optional]  |
| **resolution** | **int** | Resolution version | [optional]  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarserver"></a>
# **RadarServer**
> Object RadarServer (string id, string reportingHost = null)



Returns metadata about a given radar server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Server ID |  |
| **reportingHost** | **string** | Show records from specific reporting host | [optional]  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarservers"></a>
# **RadarServers**
> Object RadarServers (string reportingHost = null)



Returns a list of radar servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reportingHost** | **string** | Show records from specific reporting host | [optional]  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarstation"></a>
# **RadarStation**
> Object RadarStation (string stationId, string reportingHost = null, string host = null)



Returns metadata about a given radar station


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Radar station ID |  |
| **reportingHost** | **string** | Show RDA and latency info from specific reporting host | [optional]  |
| **host** | **string** | Show latency info from specific LDM host | [optional]  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarstationalarms"></a>
# **RadarStationAlarms**
> Object RadarStationAlarms (string stationId)



Returns metadata about a given radar station alarms


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Radar station ID |  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="radarstations"></a>
# **RadarStations**
> Object RadarStations (List<string> stationType = null, string reportingHost = null, string host = null)



Returns a list of radar stations


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationType** | [**List&lt;string&gt;**](string.md) | Limit results to a specific station type or types | [optional]  |
| **reportingHost** | **string** | Show RDA and latency info from specific reporting host | [optional]  |
| **host** | **string** | Show latency info from specific LDM host | [optional]  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="satellitethumbnails"></a>
# **SatelliteThumbnails**
> System.IO.Stream SatelliteThumbnails (string area)



Returns a thumbnail image for a satellite region. Image services in API are deprecated.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **area** | **string** | . |  |

### Return type

**System.IO.Stream**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/jpeg, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An image file |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sigmet"></a>
# **Sigmet**
> SigmetGeoJson Sigmet (string atsu, DateOnly date, string time)



Returns a specific SIGMET/AIRMET


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **atsu** | **string** | ATSU identifier |  |
| **date** | **DateOnly** | Date (YYYY-MM-DD format) |  |
| **time** | **string** | Time (HHMM format). This time is always specified in UTC (Zulu) time. |  |

### Return type

[**SigmetGeoJson**](SigmetGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/vnd.noaa.uswx+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sigmetquery"></a>
# **SigmetQuery**
> SigmetCollectionGeoJson SigmetQuery (DateTime start = null, DateTime end = null, DateOnly date = null, string atsu = null, string sequence = null)



Returns a list of SIGMET/AIRMETs


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **DateTime** | Start time | [optional]  |
| **end** | **DateTime** | End time | [optional]  |
| **date** | **DateOnly** | Date (YYYY-MM-DD format) | [optional]  |
| **atsu** | **string** | ATSU identifier | [optional]  |
| **sequence** | **string** | SIGMET sequence number | [optional]  |

### Return type

[**SigmetCollectionGeoJson**](SigmetCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sigmetsbyatsu"></a>
# **SigmetsByATSU**
> SigmetCollectionGeoJson SigmetsByATSU (string atsu)



Returns a list of SIGMET/AIRMETs for the specified ATSU


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **atsu** | **string** | ATSU identifier |  |

### Return type

[**SigmetCollectionGeoJson**](SigmetCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sigmetsbyatsubydate"></a>
# **SigmetsByATSUByDate**
> SigmetCollectionGeoJson SigmetsByATSUByDate (string atsu, DateOnly date)



Returns a list of SIGMET/AIRMETs for the specified ATSU for the specified date


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **atsu** | **string** | ATSU identifier |  |
| **date** | **DateOnly** | Date (YYYY-MM-DD format) |  |

### Return type

[**SigmetCollectionGeoJson**](SigmetCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stationobservationlatest"></a>
# **StationObservationLatest**
> ObservationGeoJson StationObservationLatest (string stationId, bool requireQc = null)



Returns the latest observation for a station


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Observation station ID |  |
| **requireQc** | **bool** | Require QC | [optional]  |

### Return type

[**ObservationGeoJson**](ObservationGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.uswx+xml, application/vnd.noaa.obs+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An observation record. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stationobservationlist"></a>
# **StationObservationList**
> ObservationCollectionGeoJson StationObservationList (string stationId, DateTime start = null, DateTime end = null, int limit = null)



Returns a list of observations for a given station


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Observation station ID |  |
| **start** | **DateTime** | Start time | [optional]  |
| **end** | **DateTime** | End time | [optional]  |
| **limit** | **int** | Limit | [optional]  |

### Return type

[**ObservationCollectionGeoJson**](ObservationCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of observation records. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stationobservationtime"></a>
# **StationObservationTime**
> ObservationGeoJson StationObservationTime (string stationId, DateTime time)



Returns a single observation.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Observation station ID |  |
| **time** | **DateTime** | Timestamp of requested observation |  |

### Return type

[**ObservationGeoJson**](ObservationGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.uswx+xml, application/vnd.noaa.obs+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An observation record. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taf"></a>
# **Taf**
> Object Taf (string stationId, DateOnly date, string time)



Returns a single Terminal Aerodrome Forecast.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Observation station ID |  |
| **date** | **DateOnly** | Date (YYYY-MM-DD format) |  |
| **time** | **string** | Time (HHMM format). This time is always specified in UTC (Zulu) time. |  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.wmo.iwxxm+xml, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="tafs"></a>
# **Tafs**
> Object Tafs (string stationId)



Returns Terminal Aerodrome Forecasts for the specified airport station.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **string** | Observation station ID |  |

### Return type

**Object**

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="zone"></a>
# **Zone**
> ZoneGeoJson Zone (NWSZoneType type, string zoneId, DateTime effective = null)



Returns metadata about a given zone


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **NWSZoneType** | Zone type |  |
| **zoneId** | **string** | NWS public zone/county identifier |  |
| **effective** | **DateTime** | Effective date/time | [optional]  |

### Return type

[**ZoneGeoJson**](ZoneGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="zoneforecast"></a>
# **ZoneForecast**
> ZoneForecastGeoJson ZoneForecast (string type, string zoneId)



Returns the current zone forecast for a given zone


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** | Zone type |  |
| **zoneId** | **string** | NWS public zone/county identifier |  |

### Return type

[**ZoneForecastGeoJson**](ZoneForecastGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="zonelist"></a>
# **ZoneList**
> ZoneCollectionGeoJson ZoneList (List<string> id = null, List<AreaCode> area = null, List<RegionCode> region = null, List<NWSZoneType> type = null, string point = null, bool includeGeometry = null, int limit = null, DateTime effective = null)



Returns a list of zones


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | [**List&lt;string&gt;**](string.md) | Zone ID (forecast or county) | [optional]  |
| **area** | [**List&lt;AreaCode&gt;**](AreaCode.md) | State/marine area code | [optional]  |
| **region** | [**List&lt;RegionCode&gt;**](RegionCode.md) | Region code | [optional]  |
| **type** | [**List&lt;NWSZoneType&gt;**](NWSZoneType.md) | Zone type | [optional]  |
| **point** | **string** | Point (latitude,longitude) | [optional]  |
| **includeGeometry** | **bool** | Include geometry in results (true/false) | [optional]  |
| **limit** | **int** | Limit | [optional]  |
| **effective** | **DateTime** | Effective date/time | [optional]  |

### Return type

[**ZoneCollectionGeoJson**](ZoneCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="zonelisttype"></a>
# **ZoneListType**
> ZoneCollectionGeoJson ZoneListType (NWSZoneType type, List<string> id = null, List<AreaCode> area = null, List<RegionCode> region = null, List<NWSZoneType> type2 = null, string point = null, bool includeGeometry = null, int limit = null, DateTime effective = null)



Returns a list of zones of a given type


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **NWSZoneType** | Zone type |  |
| **id** | [**List&lt;string&gt;**](string.md) | Zone ID (forecast or county) | [optional]  |
| **area** | [**List&lt;AreaCode&gt;**](AreaCode.md) | State/marine area code | [optional]  |
| **region** | [**List&lt;RegionCode&gt;**](RegionCode.md) | Region code | [optional]  |
| **type2** | [**List&lt;NWSZoneType&gt;**](NWSZoneType.md) | Zone type | [optional]  |
| **point** | **string** | Point (latitude,longitude) | [optional]  |
| **includeGeometry** | **bool** | Include geometry in results (true/false) | [optional]  |
| **limit** | **int** | Limit | [optional]  |
| **effective** | **DateTime** | Effective date/time | [optional]  |

### Return type

[**ZoneCollectionGeoJson**](ZoneCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="zoneobs"></a>
# **ZoneObs**
> ObservationCollectionGeoJson ZoneObs (string zoneId, DateTime start = null, DateTime end = null, int limit = null)



Returns a list of observations for a given zone


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | NWS public zone/county identifier |  |
| **start** | **DateTime** | Start date/time | [optional]  |
| **end** | **DateTime** | End date/time | [optional]  |
| **limit** | **int** | Limit | [optional]  |

### Return type

[**ObservationCollectionGeoJson**](ObservationCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="zonestations"></a>
# **ZoneStations**
> ObservationStationCollectionGeoJson ZoneStations (string zoneId, int limit = null, string cursor = null, List<string> featureFlags = null)



Returns a list of observation stations for a given zone


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | NWS public zone/county identifier |  |
| **limit** | **int** | Limit | [optional] [default to 500] |
| **cursor** | **string** | Pagination cursor | [optional]  |
| **featureFlags** | [**List&lt;string&gt;**](string.md) | Enable future and experimental features (see documentation for more info): * obs_station_provider: Include the data provider in the metadata about observation stations  | [optional]  |

### Return type

[**ObservationStationCollectionGeoJson**](ObservationStationCollectionGeoJson.md)

### Authorization

[userAgent](../README.md#userAgent)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of observation stations. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |
| **0** | An error response. |  * X-Correlation-Id -  <br>  * X-Request-Id -  <br>  * X-Server-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

