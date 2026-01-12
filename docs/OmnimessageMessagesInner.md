# com.Messente.Api.Model.OmnimessageMessagesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | Phone number or alphanumeric sender name | 
**Validity** | **int** | After how many minutes this channel is considered as failed and the next channel is attempted.Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Ttl** | **int** | After how many seconds this channel is considered as failed and the next channel is attempted. Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Text** | **string** | Text content of the RCS message | 
**ImageUrl** | **string** | URL for the embedded image    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text | [optional] 
**ButtonUrl** | **string** | URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional) | [optional] 
**ButtonText** | **string** | Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional) | [optional] 
**Channel** | **string** | The channel used to deliver the message | [optional] [default to ChannelEnum.Rcs]
**Video** | [**WhatsAppVideo**](WhatsAppVideo.md) |  | [optional] 
**Autoconvert** | **string** | Defines how non-GSM characters will be treated:    - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace) (default)   - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives   - \&quot;off\&quot; Message content is not modified in any way | [optional] 
**Udh** | **string** | hex-encoded string containing SMS UDH | [optional] 
**Template** | [**WhatsAppTemplate**](WhatsAppTemplate.md) |  | [optional] 
**Image** | [**WhatsAppImage**](WhatsAppImage.md) |  | [optional] 
**Audio** | [**WhatsAppAudio**](WhatsAppAudio.md) |  | [optional] 
**Document** | [**WhatsAppDocument**](WhatsAppDocument.md) |  | [optional] 
**Sticker** | [**WhatsAppSticker**](WhatsAppSticker.md) |  | [optional] 
**Suggestions** | [**List&lt;RcsSuggestion&gt;**](RcsSuggestion.md) | List of suggestions to include with the message | [optional] 
**RichCard** | [**RcsRichCard**](RcsRichCard.md) |  | [optional] 
**ContentInfo** | [**RcsContentInfo**](RcsContentInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

