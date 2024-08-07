# com.Messente.Api.Model.DeliveryResult
A delivery report

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **Status** |  | [optional] 
**Channel** | **Channel** |  | [optional] 
**MessageId** | **Guid** | Unique identifier for the message | [optional] 
**Error** | **string** | Human-readable description of what went wrong, *null* in case of success or if the message has not been processed yet | [optional] 
**Err** | **ErrorCodeOmnichannelMachine** |  | [optional] 
**Timestamp** | **DateTime** | When this status was received by Omnichannel API | [optional] 
**PriceInfo** | [**PriceInfo**](PriceInfo.md) |  | [optional] 
**Sender** | **string** | the sender of the message | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

