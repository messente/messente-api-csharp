# com.Messente.Api.Model.Rcs
RCS message object. Exactly one of 'text', 'content_info' or 'rich_card' must be provided.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | The channel used to deliver the message | [optional] [default to ChannelEnum.Rcs]
**Sender** | **string** | Phone number or alphanumeric sender name | 
**Validity** | **int** | After how many minutes this channel is considered as failed and the next channel is attempted.Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Ttl** | **int** | After how many seconds this channel is considered as failed and the next channel is attempted. Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Text** | **string** | Text content of the RCS message | [optional] 
**Suggestions** | [**List&lt;RcsSuggestion&gt;**](RcsSuggestion.md) | List of suggestions to include with the message | [optional] 
**RichCard** | [**RcsRichCard**](RcsRichCard.md) |  | [optional] 
**ContentInfo** | [**RcsContentInfo**](RcsContentInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

