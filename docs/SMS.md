# com.Messente.Api.Model.SMS
SMS message content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Text content of the SMS | 
**Sender** | **string** | Phone number or alphanumeric sender name | [optional] 
**Validity** | **int** | After how many minutes this channel is considered as failed and the next channel is attempted.                     Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Ttl** | **int** | After how many seconds this channel is considered as failed and the next channel is attempted.                     Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used. | [optional] 
**Autoconvert** | **string** | Defines how non-GSM characters will be treated:    - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace) (default)   - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives   - \&quot;off\&quot; Message content is not modified in any way | [optional] 
**Udh** | **string** | hex-encoded string containing SMS UDH | [optional] 
**Channel** | **string** | The channel used to deliver the message | [optional] [default to ChannelEnum.Sms]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

