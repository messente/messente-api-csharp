# com.Messente.Api.Model.RcsSuggestedAction
RCS suggested action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The text of the suggested action. Exactly one of the action fields (types) must be provided. | 
**PostbackData** | **string** | The postback data associated with the suggested action. This is sent back to the sender when the user selects the suggested action. | 
**FallbackUrl** | **string** | The fallback URL to open if the suggested action is not supported. | [optional] 
**DialAction** | [**RcsDialAction**](RcsDialAction.md) |  | [optional] 
**ViewLocationAction** | [**RcsViewLocationAction**](RcsViewLocationAction.md) |  | [optional] 
**CreateCalendarEventAction** | [**RcsCreateCalendarEventAction**](RcsCreateCalendarEventAction.md) |  | [optional] 
**OpenUrlAction** | [**RcsOpenUrlAction**](RcsOpenUrlAction.md) |  | [optional] 
**ShareLocationAction** | **Object** | This action does not have any properties. It simply triggers the share location action. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

