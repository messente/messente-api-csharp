# com.Messente.Api.Api.OmnimessageApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelScheduledMessage**](OmnimessageApi.md#cancelscheduledmessage) | **DELETE** /omnimessage/{omnimessageId} | Cancels a scheduled Omnimessage |
| [**SendOmnimessage**](OmnimessageApi.md#sendomnimessage) | **POST** /omnimessage | Sends an Omnimessage |

<a id="cancelscheduledmessage"></a>
# **CancelScheduledMessage**
> Object CancelScheduledMessage (Guid omnimessageId)

Cancels a scheduled Omnimessage

### Example
```csharp
using System.Collections.Generic;
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
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new OmnimessageApi(config);
            var omnimessageId = "omnimessageId_example";  // Guid | UUID of the scheduled omnimessage to be cancelled

            try
            {
                // Cancels a scheduled Omnimessage
                Object result = apiInstance.CancelScheduledMessage(omnimessageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmnimessageApi.CancelScheduledMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelScheduledMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancels a scheduled Omnimessage
    ApiResponse<Object> response = apiInstance.CancelScheduledMessageWithHttpInfo(omnimessageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OmnimessageApi.CancelScheduledMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **omnimessageId** | **Guid** | UUID of the scheduled omnimessage to be cancelled |  |

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Scheduled omnimessage successfully cancelled |  -  |
| **401** | Unauthorized |  -  |
| **404** | If the omnimessage has already been sent or no such message exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendomnimessage"></a>
# **SendOmnimessage**
> OmniMessageCreateSuccessResponse SendOmnimessage (Omnimessage omnimessage)

Sends an Omnimessage

### Example
```csharp
using System.Collections.Generic;
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
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new OmnimessageApi(config);
            var omnimessage = new Omnimessage(); // Omnimessage | Omnimessage to be sent

            try
            {
                // Sends an Omnimessage
                OmniMessageCreateSuccessResponse result = apiInstance.SendOmnimessage(omnimessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmnimessageApi.SendOmnimessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendOmnimessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sends an Omnimessage
    ApiResponse<OmniMessageCreateSuccessResponse> response = apiInstance.SendOmnimessageWithHttpInfo(omnimessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OmnimessageApi.SendOmnimessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **omnimessage** | [**Omnimessage**](Omnimessage.md) | Omnimessage to be sent |  |

### Return type

[**OmniMessageCreateSuccessResponse**](OmniMessageCreateSuccessResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Omnimessage success response |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

