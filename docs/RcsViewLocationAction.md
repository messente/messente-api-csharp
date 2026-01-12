# com.Messente.Api.Model.RcsViewLocationAction
Action to view a location on a map.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LatLong** | [**RcsLatLng**](RcsLatLng.md) |  | [optional] 
**Label** | **string** | The label of the pin dropped at latLong. | [optional] 
**Query** | **string** | (Optional, only supported on Android Messages clients) Instead of specifying a latLong (and optionally, a label), the agent can specify a query string. For default map apps that support search functionality (including Google Maps), tapping this suggested action results in a location search centered around the user&#39;s current location.              For instance, setting the query string to \&quot;Growing Tree Bank\&quot; will show all Growing Tree Bank locations in the user&#39;s vicinity. Setting the query string to \&quot;1600 Amphitheater Parkway, Mountain View, CA 94043\&quot; will select that specific address, regardless of the user&#39;s location.        | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

