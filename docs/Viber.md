# com.Messente.Api.Model.Viber
Viber message content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | Phone number or alphanumeric sender name | [optional] 
**Validity** | **int** | After how many minutes this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Ttl** | **int** | After how many seconds this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Text** | **string** | Plaintext content for Viber | [optional] 
**ImageUrl** | **string** | URL for the embedded image    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text | [optional] 
**ButtonUrl** | **string** | URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional) | [optional] 
**ButtonText** | **string** | Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional) | [optional] 
**Channel** | **string** | The channel used to deliver the message | [optional] [default to ChannelEnum.Viber]
**Video** | [**ViberVideo**](ViberVideo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

