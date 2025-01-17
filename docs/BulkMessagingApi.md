# com.Messente.Api.Api.BulkMessagingApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SendBulkOmnimessage**](BulkMessagingApi.md#sendbulkomnimessage) | **POST** /omnimessages | Sends a bulk Omnimessage |

<a id="sendbulkomnimessage"></a>
# **SendBulkOmnimessage**
> BulkOmniMessageCreateSuccessResponse SendBulkOmnimessage (BulkOmnimessage bulkOmnimessage)

Sends a bulk Omnimessage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class SendBulkOmnimessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BulkMessagingApi(config);
            var bulkOmnimessage = new BulkOmnimessage(); // BulkOmnimessage | Bulk Omnimessage to be sent

            try
            {
                // Sends a bulk Omnimessage
                BulkOmniMessageCreateSuccessResponse result = apiInstance.SendBulkOmnimessage(bulkOmnimessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkMessagingApi.SendBulkOmnimessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendBulkOmnimessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sends a bulk Omnimessage
    ApiResponse<BulkOmniMessageCreateSuccessResponse> response = apiInstance.SendBulkOmnimessageWithHttpInfo(bulkOmnimessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkMessagingApi.SendBulkOmnimessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bulkOmnimessage** | [**BulkOmnimessage**](BulkOmnimessage.md) | Bulk Omnimessage to be sent |  |

### Return type

[**BulkOmniMessageCreateSuccessResponse**](BulkOmniMessageCreateSuccessResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Bulk Omnimessage success response |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

