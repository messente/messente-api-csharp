# com.Messente.Api.Model.WhatsApp
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | Phone number or alphanumeric sender name | [optional] 
**Validity** | **int?** | After how many minutes this channel is   considered as failed and the next channel is attempted | [optional] 
**Ttl** | **int?** | After how many seconds this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Text** | [**WhatsAppText**](WhatsAppText.md) |  | [optional] 
**Image** | [**WhatsAppImage**](WhatsAppImage.md) |  | [optional] 
**Document** | [**WhatsAppDocument**](WhatsAppDocument.md) |  | [optional] 
**Audio** | [**WhatsAppAudio**](WhatsAppAudio.md) |  | [optional] 
**Channel** | **string** | The channel used to deliver the message | [optional] [default to ChannelEnum.Whatsapp]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

