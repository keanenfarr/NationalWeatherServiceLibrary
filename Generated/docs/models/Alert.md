# NationalWeatherService.Client.Model.Alert
An object representing a public alert message. Unless otherwise noted, the fields in this object correspond to the National Weather Service CAP v1.2 specification, which extends the OASIS Common Alerting Protocol (CAP) v1.2 specification and USA Integrated Public Alert and Warning System (IPAWS) Profile v1.0. Refer to this documentation for more complete information. http://docs.oasis-open.org/emergency/cap/v1.2/CAP-v1.2-os.html http://docs.oasis-open.org/emergency/cap/v1.2/ipaws-profile/v1.0/cs01/cap-v1.2-ipaws-profile-cs01.html https://vlab.noaa.gov/web/nws-common-alerting-protocol/cap-documentation 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the alert message. | [optional] 
**AreaDesc** | **string** | A textual description of the area affected by the alert. | [optional] 
**Geocode** | [**AlertGeocode**](AlertGeocode.md) |  | [optional] 
**AffectedZones** | **List&lt;string&gt;** | An array of API links for zones affected by the alert. This is an API-specific extension field and is not part of the CAP specification.  | [optional] 
**References** | [**List&lt;AlertReferencesInner&gt;**](AlertReferencesInner.md) | A list of prior alerts that this alert updates or replaces. | [optional] 
**Sent** | **DateTime** | The time of the origination of the alert message. | [optional] 
**Effective** | **DateTime** | The effective time of the information of the alert message. | [optional] 
**Onset** | **DateTime** | The expected time of the beginning of the subject event of the alert message. | [optional] 
**Expires** | **DateTime** | The expiry time of the information of the alert message. | [optional] 
**Ends** | **DateTime** | The expected end time of the subject event of the alert message. | [optional] 
**Status** | **AlertStatus** |  | [optional] 
**MessageType** | **AlertMessageType** |  | [optional] 
**Category** | **string** | The code denoting the category of the subject event of the alert message. | [optional] 
**Severity** | **AlertSeverity** |  | [optional] 
**Certainty** | **AlertCertainty** |  | [optional] 
**Urgency** | **AlertUrgency** |  | [optional] 
**Event** | **string** | The text denoting the type of the subject event of the alert message. | [optional] 
**Sender** | **string** | Email address of the NWS webmaster. | [optional] 
**SenderName** | **string** | The text naming the originator of the alert message. | [optional] 
**Headline** | **string** | The text headline of the alert message. | [optional] 
**Description** | **string** | The text describing the subject event of the alert message. | [optional] 
**Instruction** | **string** | The text describing the recommended action to be taken by recipients of the alert message.  | [optional] 
**Response** | **string** | The code denoting the type of action recommended for the target audience. This corresponds to responseType in the CAP specification.  | [optional] 
**Parameters** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** | System-specific additional parameters associated with the alert message. The keys in this object correspond to parameter definitions in the NWS CAP specification.  | [optional] 
**Scope** | **string** | The code denoting the intended distribution of the alert message. | [optional] 
**Code** | **string** | The code denoting the special handling of the alert message. | [optional] 
**Language** | **string** | The code denoting the language of the info sub-element of the alert message. | [optional] 
**Web** | **string** | The identifier of the hyperlink associating additional information within the alert message. | [optional] 
**EventCode** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** | System-specific code identifiying the event type of the alert message The keys in this object correspond to eventCode definitions in the NWS CAP specification.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

