# com.Messente.Api.Api.OmnimessageApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelScheduledMessage**](OmnimessageApi.md#cancelscheduledmessage) | **DELETE** /omnimessage/{omnimessageId} | Cancels a scheduled Omnimessage
[**SendOmnimessage**](OmnimessageApi.md#sendomnimessage) | **POST** /omnimessage | Sends an Omnimessage


<a name="cancelscheduledmessage"></a>
# **CancelScheduledMessage**
> EmptyObject CancelScheduledMessage (string omnimessageId)

Cancels a scheduled Omnimessage

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class CancelScheduledMessageExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OmnimessageApi();
            var omnimessageId = omnimessageId_example;  // string | UUID of the scheduled omnimessage to be cancelled

            try
            {
                // Cancels a scheduled Omnimessage
                EmptyObject result = apiInstance.CancelScheduledMessage(omnimessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmnimessageApi.CancelScheduledMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omnimessageId** | **string**| UUID of the scheduled omnimessage to be cancelled | 

### Return type

[**EmptyObject**](EmptyObject.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendomnimessage"></a>
# **SendOmnimessage**
> OmniMessageCreateSuccessResponse SendOmnimessage (Omnimessage omnimessage)

Sends an Omnimessage

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class SendOmnimessageExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OmnimessageApi();
            var omnimessage = new Omnimessage(); // Omnimessage | Omnimessage to be sent

            try
            {
                // Sends an Omnimessage
                OmniMessageCreateSuccessResponse result = apiInstance.SendOmnimessage(omnimessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmnimessageApi.SendOmnimessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omnimessage** | [**Omnimessage**](Omnimessage.md)| Omnimessage to be sent | 

### Return type

[**OmniMessageCreateSuccessResponse**](OmniMessageCreateSuccessResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

