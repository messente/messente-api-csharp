# com.Messente.Api.Model.Telegram
Telegram message content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | Phone number or alphanumeric sender name | [optional] 
**Validity** | **int** | After how many minutes this channel is considered as failed and the next channel is attempted | [optional] 
**Text** | **string** | Plaintext content for Telegram | [optional] 
**ImageUrl** | **string** | URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;audio_url\&quot; | [optional] 
**DocumentUrl** | **string** | URL for the embedded image. Mutually exclusive with \&quot;audio_url\&quot; and \&quot;image_url\&quot; | [optional] 
**AudioUrl** | **string** | URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;image_url\&quot; | [optional] 
**Channel** | **string** | The channel used to deliver the message | [optional] [default to ChannelEnum.Telegram]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

